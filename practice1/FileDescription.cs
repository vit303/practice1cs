using System;


namespace practice1
{
    internal class FileDescription
    {
        public String Name;
        public long Size;
        public String FileExtension;
        public String Date;
        public String Time;
        public bool IsDirectory;

        public FileDescription(){
            this.Name = "undefined";
            this.Size = 0;
            this.FileExtension = "exe";
            this.Date = "today";
            this.Time = "5 p.m.";
            this.IsDirectory = false;
        }

        public FileDescription(String Name, long Size, String FileExtension, String Date, String Time, bool IsDirectory) {
            this.Name = Name;
            this.Size = Size;
            this.FileExtension = FileExtension;
            this.Date = Date;
            this.Time = Time;
            this.IsDirectory = IsDirectory;
        }
    }
}
