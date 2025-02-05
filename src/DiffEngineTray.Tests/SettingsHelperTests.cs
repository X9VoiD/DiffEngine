﻿[UsesVerify]
public class SettingsHelperTests :
    XunitContextBase
{
    [Fact]
    public async Task ReadWrite()
    {
        var tempFile = "ReadWrite.txt";
        File.Delete(tempFile);
        try
        {
            SettingsHelper.FilePath = tempFile;
            await SettingsHelper.Write(
                new()
                {
                    AcceptAllHotKey = new()
                    {
                        Key = "T"
                    }
                });
            var result = await SettingsHelper.Read();
            await Verify(result);
        }
        finally
        {
            File.Delete(tempFile);
        }
    }

    public SettingsHelperTests(ITestOutputHelper output) :
        base(output)
    {
    }
}