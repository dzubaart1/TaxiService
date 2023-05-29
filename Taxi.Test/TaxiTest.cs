using TaxiBusiness.Services;
using Xunit;

namespace Taxi.Test
{
    public class Tests
    {
        [Fact]
        public void UploadWithoutFiles_CreatedNewFiles()
        {
            MainService.Upload();
            Assert.That(MainService.GetJsonPath(), Is.EqualTo("C:\\Users\\HYPERPC\\Documents\\GitHub\\TaxiService\\WinFormsApp1\\bin\\Debug\\net6.0-windows\\data"));
            Assert.That(MainService.GetIdFilePath(), Is.EqualTo("\"C:\\Users\\HYPERPC\\Documents\\GitHub\\TaxiService\\WinFormsApp1\\bin\\Debug\\net6.0-windows\\data\\id.json\""));
            Assert.That(MainService.GetUserPath(), Is.EqualTo("\"C:\\Users\\HYPERPC\\Documents\\GitHub\\TaxiService\\WinFormsApp1\\bin\\Debug\\net6.0-windows\\data\\users.json\""));
        }
    }
}