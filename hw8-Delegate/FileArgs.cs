using System;

namespace hw8_Delegate;

public class FileArgs : EventArgs
{
	public string FileName { get; }
	public bool IsCancel { get; set; }
	public FileArgs(string fileName)
	{
		FileName = fileName;
		IsCancel = false;
	}

}
