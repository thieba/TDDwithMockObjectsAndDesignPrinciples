using System;
using System.IO;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter.SomeDependencies
{
    public class aTextConverterClient2
    {
		// A class with the only goal of simulating a dependency on UnicodeFileToHtmTextConverter
		// that has impact on the refactoring.


        public aTextConverterClient2()
        {
            using (var fileStream = new FileStream("anotherFilename.txt", FileMode.Open))
            {
                var html = UnicodeStreamToHtmlTextConverter.ConvertToHtml(fileStream);
            }
        }

    }
}
