﻿using SystemWrapper.IO;
using pdfforge.PDFCreator.Conversion.Processing.ITextProcessing;
using pdfforge.PDFCreator.Conversion.Processing.PdfProcessingInterface;
using pdfforge.PDFCreator.IntegrationTest.Conversion.PDFProcessing.Base;

namespace pdfforge.PDFCreator.IntegrationTest.Conversion.PDFProcessing.IText
{
    class ITextEncryptionTest : EncryptionTestBase
    {
        protected override bool IsIText => true;
        protected override IPdfProcessor BuildPdfProcessor()
        {
            return new ITextPdfProcessor(new FileWrap(), new DefaultProcessingPasswordsProvider());
        }
    }
}
