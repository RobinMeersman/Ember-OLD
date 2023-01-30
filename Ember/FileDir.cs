namespace Ember
{
    public class FileDir
    {
        private object fileDirObject;
        private long size;

        public FileDir(long size, object obj)
        {
            this.size = size;
            fileDirObject = obj;
        }

        public object getFileDirObject()
        {
            return fileDirObject;
        }
        public void setFileDirObject(object f)
        {
            fileDirObject = f;
        }
        
        public long getSize()
        {
            return size;
        }
        public void setSize(long size)
        {
            this.size = size;
        }
    }
}