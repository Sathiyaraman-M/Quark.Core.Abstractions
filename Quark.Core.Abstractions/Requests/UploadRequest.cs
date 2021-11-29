namespace Quark.Core.Abstractions.Requests;

public class UploadRequest
{
    public string FileName { get; set; }
    public string Extension { get; set; }
    public string UploadPath { get; set; }
    public byte[] Data { get; set; }
}