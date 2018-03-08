﻿namespace ClangPowerTools
{
  public class TaskError
  {
    #region Properties

    public string Message { get; set; }
    public string FullMessage { get; set; }
    public string FilePath { get; set; }
    public int Line { get; set; }
    public EnvDTE.vsTaskPriority Type { get; set; }

    #endregion

    #region Constructor

    public TaskError(string aFilePath, string aFullMessage,
      string aMessage, int aLine, EnvDTE.vsTaskPriority aType)
    {
      FilePath = aFilePath;
      FullMessage = aFullMessage;
      Message = aMessage;
      Line = aLine;
      Type = aType;
    }

    #endregion

    #region Public Methods

    public override bool Equals(object obj)
    {
      var otherObj = obj as TaskError;
      if (null == otherObj)
        return false;

      return Line == otherObj.Line &&
        FilePath == otherObj.FilePath &&
        FullMessage == otherObj.FullMessage;
    }

    public override int GetHashCode()
    {
      return $"{Line.ToString()}{FilePath}{FullMessage}".GetHashCode();
    }

    #endregion

  }
}
