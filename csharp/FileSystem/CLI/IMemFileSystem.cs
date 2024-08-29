namespace FileSystem.CLI;

public interface IMemFileSystem
{
  void PWD();
  void CDUp();
  void LS();
  void CD(string folderName);
  void CreateFolder(string folderName);
  void CreateFile(string name, string content);
  void SearchContent(string searchValue);
}
