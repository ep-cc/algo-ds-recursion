using FileSystem.CLI;

var fs = new MemFileSystem();

fs.CreateFolder("theory");
fs.CreateFolder("practice");
fs.CD("theory");
fs.CreateFolder("javascript");
fs.CreateFolder("dotnet");
fs.CreateFolder("devops");
fs.CD("devops");
fs.CreateFolder("docker");
fs.CDUp();

fs.LS();

fs.CD("javascript");

fs.PWD();

fs.CreateFile("React", "It is a library, not a framework");
fs.CDUp();
fs.CreateFile("workbook.md", "the concept of library");
fs.CDUp();

fs.PWD();

fs.SearchContent("library");

