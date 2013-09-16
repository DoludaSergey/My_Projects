using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Test_WIN_API
{
    
    class Program
    {
        enum TipoUnidades : int
        {
            // Индийский также значения API (начинаются с нуля и идут один в один)
            UNKNOWN,       // 0 DRIVE_UNKNOWN       The drive type cannot be determined.
            NO_ROOT_DIR,   // 1 DRIVE_NO_ROOT_DIR   The root path is invalid;
            //                                      for example, there is no volume mounted at the path.
            REMOVABLE,     // 2 DRIVE_REMOVABLE     The drive has removable media;
            //                                      for example, a floppy drive or flash card reader.
            //                                      Las llaves USB los da como extraibles.
            FIXED,         // 3 DRIVE_FIXED         The drive has fixed media;
            //                                      for example, a hard drive, flash drive, or thumb drive.
            //                                      Los discos duros normales enchufados por USB son fijos.
            REMOTE,        // 4 DRIVE_REMOTE        The drive is a remote (network) drive.
            CDROM,         // 5 DRIVE_CDROM         The drive is a CD-ROM drive.
            
            RAMDISK,       // 6 DRIVE_RAMDISK       The drive is a RAM disk.
        };

        // Для типа диска
        //Частные Заявляют Функция GetDriveType Библиотека "kernel32.dll" Псевдоним "GetDriveTypeA" _
        //        (ByVal nDrive As String) As TipoUnidades

        [DllImport("kernel32.dll")]
        private extern static TipoUnidades GetDriveType(string nDrive);

        // Для логических дисков свободных и занятых
        //Частные Заявляют Функция GetLogicalDrives Библиотека "kernel32.dll" () As Integer

        [DllImport("kernel32.dll")]
        private extern static int GetLogicalDrives();

        [DllImport("kernel32.dll")]
        public static extern int GetVolumeInformation(string strPathName,
                                                    StringBuilder strVolumeNameBuffer,
                                                    int lngVolumeNameSize,
                                                    out long lngVolumeSerialNumber,
                                                    out int lngMaximumComponentLength,
                                                    out int lngFileSystemFlags,
                                                    StringBuilder strFileSystemNameBuffer,
                                                    int lngFileSystemNameSize);

        [DllImport("coredll.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
                                              out ulong lpFreeBytesAvailable,
                                              out ulong lpTotalNumberOfBytes,
                                              out ulong lpTotalNumberOfFreeBytes);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool GetDiskFreeSpace(string lpRootPathName,
        out uint lpSectorsPerCluster,
        out uint lpBytesPerSector,
        out uint lpNumberOfFreeClusters,
        out uint lpTotalNumberOfClusters);

        

        //[DllImport("coredll.dll", SetLastError=true, CharSet=CharSet.Auto, EntryPoint="GetDiskFreeSpaceEx")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool InternalGetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);

        //static GetDiskFreeSpaceEx(string directoryName, out ulong freeBytesAvailable, out ulong totalNumberOfBytes, out totalNumberOfFreeBytes);
        //{
        //  if (!GetDiskFreeSpaceEx(directoryName, out freeBytesAvailable, out totalNumberOfBytes, out totalNumberOfFreeBytes))
        //    throw new System.ComponentModel.Win32Exception();
        //}


        static void Main()
        {
            int ret;
            TipoUnidades retType;
            StringBuilder sbLibres = new StringBuilder();
            StringBuilder sbOcupadas = new StringBuilder();
            const int MAX_SIZE = 256;
            //метка диска
            StringBuilder volname = new StringBuilder(MAX_SIZE);
            //серийный номер диска
            long sn = new long();
            int maxcomplen; ;//максимальное кол-во компонент
            int sysflags;//системные флаги
            StringBuilder sysname = new StringBuilder(MAX_SIZE);//файловая система
            

            //String[] drives = Environment.GetLogicalDrives();
            //foreach (var driv in drives)
            //{
            //    MessageBox.Show(driv.ToString());
            //}

            ret = GetLogicalDrives();
            //Функция getlogicaldrives возвращает число-битовую маску в которой храняться все
            //доступные диски. 

            //dword getlogicaldrives(void);

            //Параметры:
            //Эта функция не имеет параметров. 

            //Возвращаемое значение:
            //Если функция вызвана правильно, то она возвращает число-битовую маску в которой
            //храняться все доступные диски ( если 0 бит равен 1, то диск "a:" присутствует, и т.д. 
            //)
            //Если функция вызвана не правильно, то она возвращает 0.
            //Пример:
            //int n;
            //char dd[4];
            //dword dr = getlogicaldrives();

            //for( int i = 0; i < 26; i++ )
            //{
            //n = ((dr>>i)&0x00000001);
            //if( n == 1 ) 
            //{
            //dd[0] = char(65+i);
            //dd[1] = ':';
            //dd[2] = '\';
            //dd[3] = 0;
            //cout << "available disk drives : " << dd << endl;
            //}
            //}
            
            if (ret > 0)
            {
                //Console.WriteLine("ret = {0}", ret);

                for (int i = 0; i <= 25; i++)
                {
                    string sUnidad = (char)(i + 65) + ":\\";

                    retType = GetDriveType(sUnidad);
                    //Функция GetDriveType возвращает тип диска (removable, fixed, cd-rom,
                    //ram disk, или network drive). 

                    //uint getdrivetype(lpctstr lprootpathname);
                    //Параметры:
                    //lprootpathname
                    //[in] Указатель на не нулевую стоку в которой хранится имя
                    //главной директории на диске. 
                    //Обратный слэш должен присутствовать!
                    //Если lprootpathname равно null, то функция использует текущую директорию. 

                    //Возвращаемое значение:
                    //Функция возвращает тип диска. 
                    //Могут быть следующие значения: 

                    //Значение	Описание	
                    //drive_unknown	Не известный тип.	
                    //drive_no_root_dir	Не правильный путь.	
                    //drive_removable	Съёмный диск.	
                    //drive_fixed	Фиксированный диск.	
                    //drive_remote	Удалённый или network диск.	
                    //drive_cdrom	cd-rom диск.	
                    //drive_ramdisk	ram диск.	

                    //Пример:
                    //int d;

                    //d = getdrivetype( "c:\" );
                    //if( d == drive_unknown ) cout << " unknown" << endl;
                    //if( d == drive_no_root_dir ) cout << " drive no root dir" << endl;
                    //if( d == drive_removable ) cout << " removable" << endl;
                    //if( d == drive_fixed ) cout << " fixed" << endl;
                    //if( d == drive_remote ) cout << " remote" << endl;
                    //if( d == drive_cdrom ) cout << " cdrom" << endl;
                    //if( d == drive_ramdisk ) cout << " ramdisk" << endl;

                    // Если бит равен нулю, значит нет диска или не отображении
                    if ((ret & (int)System.Math.Pow(2, i)) == 0)
                    {
                        // Добавляем имена свободных дисков
                        sbLibres.AppendFormat("{0}, ", sUnidad);
                    }
                    else
                    {
                        // Добавляем имена  занятых дисков
                        sbOcupadas.AppendFormat("{0} ({1})\t", sUnidad, retType);

                        int vi=GetVolumeInformation(sUnidad, volname, MAX_SIZE, out sn, out maxcomplen, out sysflags, sysname, MAX_SIZE);
                        //getvolumeinformation

                        //Функция getvolumeinformation возвращает информацию о файловой системе и 
                        //дисках( директориях ). 

                        //bool getvolumeinformation(
                        //lpctstr lprootpathname, // имя диска(директории) [in]
                        //lptstr lpvolumenamebuffer, // название диска [out]
                        //dword nvolumenamesize, // длина буфера названия диска [in] 
                        //lpdword lpvolumeserialnumber, // сериальный номер диска [out]
                        //lpdword lpmaximumcomponentlength, // максимальная длина фыйла [out]
                        //lpdword lpfilesystemflags, // опции файловой системы [out]
                        //lptstr lpfilesystemnamebuffer, // имя файловой системы [out]
                        //dword nfilesystemnamesize // длина буфера имени файл. 
                        //сист. 
                        //[in]
                        //);

                        //Возвращаемое значение:
                        //Если функция вызвана правильно, то она возвращает не нулевое значение(true).
                        //Если функция вызвана не правильно, то она возвращает 0(false).
                        //Пример:
                        //char volumenamebuffer[100];
                        //char filesystemnamebuffer[100];
                        //unsigned long volumeserialnumber;

                        //bool getvolumeinformationflag = getvolumeinformationa(
                        //"c:\",
                        //volumenamebuffer,
                        //100,
                        //&volumeserialnumber,
                        //null, //&maximumcomponentlength,
                        //null, //&filesystemflags,
                        //filesystemnamebuffer,
                        //100
                        //);

                        //if(getvolumeinformationflag != 0) 
                        //{
                        //cout << "	volume name is " << volumenamebuffer << endl;
                        //cout << "	volume serial number is " << volumeserialnumber << endl;
                        //cout << "	file system is " << filesystemnamebuffer << endl;
                        //}
                        //else cout << "	not present (getvolumeinformation)" << endl;
                        if (vi != 0)
                        {
                            Console.WriteLine("Информация о диске - {0}", sUnidad.ToString());
                            Console.WriteLine("Метка тома - {0}", ((volname.ToString() != "") ? volname.ToString() : "неопределена!!!"));
                            Console.WriteLine("Серийный номер диска - {0}", sn.ToString());
                            Console.WriteLine("Система - {0}", sysname.ToString());
                            //Console.WriteLine();
                        }
                        else 
                        {
                            Console.WriteLine("Информация о диске - {0} отсутствует", sUnidad.ToString());
                            Console.WriteLine();
                        }

                        uint SectorsPerCluster; 
                        uint BytesPerSector; 
                        uint NumberOfFreeClusters; 
                        uint TotalNumberOfClusters;
                        GetDiskFreeSpace(sUnidad, out SectorsPerCluster, out BytesPerSector, out NumberOfFreeClusters, out TotalNumberOfClusters); 
                        Console.WriteLine ("секторов в кластере: {0}", SectorsPerCluster) ; 
                        Console.WriteLine ("байт в секторе: {0}", BytesPerSector); 
                        Console.WriteLine ("Число свободных кластеров: {0}", NumberOfFreeClusters); 
                        Console.WriteLine ("общее количество кластеров: {0}" , TotalNumberOfClusters);    
                        // * SectorsPerCluster BytesPerSection даст вам сколько байт доступно на сектор 
                        // И, умножая результат с NumberOfFreeClusters дает свободного пространства в байтах. долго Bytes = (длинный) NumberOfFreeClusters * SectorsPerCluster * BytesPerSector; 
                        
                        //Console.WriteLine ("суммарного свободного пространства в байтах: {0}", байт);// десятичных килобайтах = (десятичные) байт / 1024; 
                        //Console.WriteLine ("суммарного свободного пространства в байтах килограмм: {0}", килобайтах); //десятичные мегабайты = (десятичное) килобайт / 1024; 
                        //Console.WriteLine ("Всего свободного места в мега байт: {0}", мегабайтах); десятичных гигабайт = (десятичные) мегабайт / 1024; 
                        //Console.WriteLine ("суммарного свободного пространства в байтах Giga: { 0} ", гигабайт); 
                        //Console.WriteLine ("Пожалуйста, введите любую клавишу для выхода ..."); 
                        //Console.ReadLine ();
                        // SectorsPerCluster * BytesPerSection will give you how many bytes are available per sector
                        // And by multiplying the result with NumberOfFreeClusters gives you the free space in bytes.
                        long Bytes = (long)NumberOfFreeClusters * SectorsPerCluster * BytesPerSector;
                        Console.WriteLine("Total Free Space in bytes: {0} ", Bytes);

                        decimal KiloBytes = (decimal)Bytes / 1024;
                        Console.WriteLine("Total Free Space in kilo bytes: {0}", KiloBytes);

                        decimal MegaBytes = (decimal)KiloBytes / 1024;
                        Console.WriteLine("Total Free Space in mega bytes: {0}", MegaBytes);

                        decimal GigaBytes = (decimal)MegaBytes / 1024;
                        Console.WriteLine("Total Free Space in giga bytes: {0}", GigaBytes);
                        Console.WriteLine();
                        
                        //ulong FreeBytesAvailable;
                        //ulong TotalNumberOfBytes;
                        //ulong TotalNumberOfFreeBytes;

                        //bool success = GetDiskFreeSpaceEx(sUnidad, out FreeBytesAvailable, out  
                        //            TotalNumberOfBytes, out TotalNumberOfFreeBytes);
                        //if (!success)
                        //    throw new System.ComponentModel.Win32Exception();

                        //Console.WriteLine("Free Bytes Available:      {0,15:D}", FreeBytesAvailable);
                        //Console.WriteLine("Total Number Of Bytes:     {0,15:D}", TotalNumberOfBytes);
                        //Console.WriteLine("Total Number Of FreeBytes: {0,15:D}", TotalNumberOfFreeBytes);
                        //getdiskfreespaceex

                        //Функция getdiskfreespaceex выдаёт информацию о доступном месте на диске.
                        //bool getdiskfreespaceex(
                        //lpctstr lpdirectoryname, // имя диска(директории) [in]
                        //pularge_integer lpfreebytesavailable, // доступно для использования(байт) [out]
                        //pularge_integer lptotalnumberofbytes, // максимальный объём( в байтах ) [out]
                        //pularge_integer lptotalnumberoffreebytes // свободно на диске( в байтах ) [out]
                        //);

                        //Возвращаемое значение:
                        //Если функция вызвана правильно, то она возвращает не нулевое значение(true).
                        //Если функция вызвана не правильно, то она возвращает 0(false).
                        //Пример:
                        //dword freebytesavailable;
                        //dword totalnumberofbytes;
                        //dword totalnumberoffreebytes;

                        //bool getdiskfreespaceflag = getdiskfreespaceex(
                        //"c:\",	 // directory name
                        //(pularge_integer)&freebytesavailable, // bytes available to caller
                        //(pularge_integer)&totalnumberofbytes, // bytes on disk
                        //(pularge_integer)&totalnumberoffreebytes // free bytes on disk
                        //);

                        //if(getdiskfreespaceflag != 0) 
                        //{
                        //cout << "	total number of free bytes = " << (unsigned long)totalnumberoffreebytes 
                        //<< "( " << double(unsigned long(totalnumberoffreebytes))/1024/1000 
                        //<< " mb )" << endl;
                        //cout << "	total number of bytes = " << (unsigned long)totalnumberofbytes 
                        //<< "( " << double(unsigned long(totalnumberofbytes))/1024/1000 
                        //<< " mb )" << endl;
                        //}
                        //else	cout << "	not present (getdiskfreespace)" << endl;


                        
                    }

                }
                Console.WriteLine("Определенные устройства:");
                Console.WriteLine(sbOcupadas.ToString());
                Console.WriteLine();
                Console.WriteLine("Неопределенные устройства:");
                Console.WriteLine(sbLibres.ToString());
            }
            else
            {
                Console.WriteLine("Не удалось получить информацию о логических дисках");
            }


            // Чтобы увидеть диски, используя классы .NET
            Console.WriteLine();
            Console.WriteLine("логические диски, используя класс environment :");
            string[] drives = Environment.GetLogicalDrives();
            Console.WriteLine("GetLogicalDrives: {0}", String.Join(", ", drives));

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter");
            Console.ReadLine();

            //Program snippets = new Program();

            //string path = System.IO.Directory.GetCurrentDirectory();
            //string filter = "*.exe";

            ////snippets.PrintFileSystemEntries(path);
            ////snippets.PrintFileSystemEntries(path, filter);
            //snippets.GetLogicalDrives();
            ////snippets.GetParent(path);
            ////snippets.Move("C:\\proof", "C:\\Temp");
            //Console.ReadLine();

        }

        //void PrintFileSystemEntries(string path)
        //{

        //    try
        //    {
        //        // Obtain the file system entries in the directory path.
        //        string[] directoryEntries =
        //            System.IO.Directory.GetFileSystemEntries(path);

        //        foreach (string str in directoryEntries)
        //        {
        //            System.Console.WriteLine(str);
        //        }
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, " +
        //            "or contains invalid characters.");
        //    }
        //    catch (System.IO.DirectoryNotFoundException)
        //    {
        //        System.Console.WriteLine("The path encapsulated in the " +
        //            "Directory object does not exist.");
        //    }
        //}
        //void PrintFileSystemEntries(string path, string pattern)
        //{
        //    try
        //    {
        //        // Obtain the file system entries in the directory
        //        // path that match the pattern.
        //        string[] directoryEntries =
        //            System.IO.Directory.GetFileSystemEntries(path, pattern);

        //        foreach (string str in directoryEntries)
        //        {
        //            System.Console.WriteLine(str);
        //        }
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, " +
        //            "or contains invalid characters.");
        //    }
        //    catch (System.IO.DirectoryNotFoundException)
        //    {
        //        System.Console.WriteLine("The path encapsulated in the " +
        //            "Directory object does not exist.");
        //    }
        //}

        //// Print out all logical drives on the system.
        //void GetLogicalDrives()
        //{
        //    try
        //    {
        //        string[] drives = System.IO.Directory.GetLogicalDrives();

        //        foreach (string str in drives)
        //        {
        //            System.Console.WriteLine(str);
        //        }
        //    }
        //    catch (System.IO.IOException)
        //    {
        //        System.Console.WriteLine("An I/O error occurs.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //}
        //void GetParent(string path)
        //{
        //    try
        //    {
        //        System.IO.DirectoryInfo directoryInfo =
        //            System.IO.Directory.GetParent(path);

        //        System.Console.WriteLine(directoryInfo.FullName);
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, or " +
        //            "contains invalid characters.");
        //    }
        //}

        //void Move(string sourcePath, string destinationPath)
        //{
        //    try
        //    {
        //        System.IO.Directory.Move(sourcePath, destinationPath);
        //        System.Console.WriteLine("The directory move is complete.");
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, " +
        //            "or contains invalid characters.");
        //    }
        //    catch (System.IO.IOException)
        //    {
        //        System.Console.WriteLine("An attempt was made to move a " +
        //            "directory to a different " +
        //            "volume, or destDirName " +
        //            "already exists.");
        //    }

    }
}
