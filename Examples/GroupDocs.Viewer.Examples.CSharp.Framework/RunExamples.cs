﻿using System;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Caching;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Loading;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Loading.LoadingDocumentsFromDifferentSources;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.CommonRenderingOptions;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingArchiveFiles;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingCadDrawings;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingEMailMessages;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingImageFiles;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingMsProjectDocuments;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingOutlookDataFiles;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingPdfDocuments;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingPresentationDocuments;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingSpreadsheets;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingWordProcessingDocuments;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingTextDocuments;
using GroupDocs.Viewer.Examples.CSharp.BasicUsage;
using GroupDocs.Viewer.Examples.CSharp.BasicUsage.ProcessingAttachments;
using GroupDocs.Viewer.Examples.CSharp.BasicUsage.RenderDocumentToHtml;
using GroupDocs.Viewer.Examples.CSharp.BasicUsage.RenderDocumentToImage;
using GroupDocs.Viewer.Examples.CSharp.BasicUsage.RenderDocumentToPdf;
using GroupDocs.Viewer.Examples.CSharp.HowTo;
using GroupDocs.Viewer.Examples.CSharp.QuickStart;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingWebDocuments;
using GroupDocs.Viewer.Examples.CSharp.AdvancedUsage.Rendering.RenderingOptionsByDocumentType.RenderingLotusNotesDataFiles;

namespace GroupDocs.Viewer.Examples.CSharp
{
    class RunExamples
    {
        static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            #region Quick Start

            SetLicenseFromFile.Run();
            //SetLicenseFromStream.Run();
            //SetMeteredLicense.Run();
            HelloWorld.Run();

            #endregion

            #region Basic Usage

            //GetSupportedFileFormats.Run();
            //GetViewInfo.Run();
            //CheckFileIsEncrypted.Run();

            #region Processing attachments

            //RetrieveAndPrintDocumentAttachments.Run();
            //RetrieveAndSaveDocumentAttachments.Run();
            //RenderDocumentAttachments.Run();

            #endregion

            #region Render document to HTML

            //RenderToHtmlWithEmbeddedResources.Run();
            //RenderToHtmlWithExternalResources.Run();
            //
            //ExcludingFontsFromOutputHtml.Run();
            //MinifyHtmlDocument.Run();
            //RenderToResponsiveHtml.Run();

            #endregion

            #region Render document to Image

            //RenderToPng.Run();
            //RenderToJpg.Run();
            //
            //GetTextCoordinates.Run();
            //RenderForDisplayWithText.Run();
            //AdjustQualityWhenRenderingToJpg.Run();
            //AdjustImageSize.Run();

            #endregion

            #region Render document to PDF

            //RenderToPdf.Run();
            //GetPdfStream.Run();

            //AdjustQualityOfJpgImages.Run();
            //ProtectPdfDocument.Run();

            #endregion

            #endregion

            #region Advanced Usage

            #region Common rendering options

            //AddWatermark.Run();
            //RenderDocumentWithComments.Run();
            //RenderDocumentWithNotes.Run();
            //RenderHiddenPages.Run();
            //RenderNConsecutivePages.Run();
            //RenderSelectedPages.Run();
            //ReplaceMissingFont.Run();
            //ReorderPages.Run();
            //FlipRotatePages.Run();
            //RenderWithCustomFonts.Run();
            //RenderingTxt.Run();

            #endregion

            #region Rendering options by document type

            #region Rendering Archive Files

            //GetViewInfoForArchiveFile.Run();
            //RenderArchiveFolder.Run();
            //SpecifyFilenameWhenRenderingArchiveFiles.Run();
            //RenderingRar.Run();
            //RenderingArchivesToMultipleAndSinglePagesHtml.Run();

            #endregion

            #region Rendering CAD Drawings

            //GetViewInfoForCadDrawing.Run();
            //RenderAllLayouts.Run();
            //RenderLayers.Run();
            //RenderSingleLayout.Run();
            //SplitDrawingIntoTiles.Run();
            //AdjustOutputImageSize.Run();
            //RenderingPlt.Run();
            //RenderingObj.Run();
            //RenderingCf2.Run();
            //RenderingHpg.Run();
            //SetImageBackgroundColor.Run();
            //RenderingFodp.Run();
            //RenderingIgs.Run();
            //RenderingNotes.Run();
            //RenderingFodgAndOdg.Run();
            //RenderingPstAndOst.Run();
            //RenderingSvgAndSvgz.Run();

            #endregion

            #region Rendering E-Mail Messages

            //AdjustPageSize.Run();
            //RenameEmailFields.Run();

            #endregion

            #region Lotus Notes data files
            //RenderingNsf.Run();
            #endregion

            #region Rendering Outlook Data Files

            //FilterMessages.Run();
            //GetViewInfoForOutlookDataFile.Run();
            //LimitCountOfItemsToRender.Run();
            //RenderOutlookDataFileFolder.Run();

            #endregion

            #region Rendering PDF Documents

            //DisableCharactersGrouping.Run();
            //EnableFontHinting.Run();
            //GetViewInfoForPdfDocument.Run();
            //AdjustImageQuality.Run();
            //EnableLayeredRendering.Run();
            //RenderOriginalPageSize.Run();

            #endregion

            #region Rendering MS Project Documents

            //AdjustTimeUnit.Run();
            //GetViewInfoForProjectDocument.Run();
            //RenderProjectTimeInterval.Run();

            #endregion

            #region Rendering Spreadsheets

            //AdjustTextOverflowInCells.Run();
            //RenderGridLines.Run();
            //RenderHiddenRowsAndColumns.Run();
            //RenderPrintAreas.Run();
            //SkipRenderingOfEmptyColumns.Run();
            //SkipRenderingOfEmptyRows.Run();
            //SplitWorksheetsIntoPages.SplitByRows();
            //SplitWorksheetsIntoPages.SplitByRowsAndColumns();
            //RenderRowAndColumnHeadings.Run();
            //GetWorksheetsNames.Run();
            //RenderingNumbers.Run();
            //RenderingXmlSpreadSheetML.Run();

            #endregion

            #region Rendering Word Processing Documents
            //RenderTrackedChanges.Run();
            #endregion

            #region Rendering Web documents
            //RenderingHtmlWithUserDefinedMargins.Run();
            #endregion

            #endregion

            #region Caching

            //UseCacheWhenProcessingDocuments.Run();
            //HowToUseCustomCacheImplementation.Run();

            #endregion

            #region Loading

            //LoadPasswordProtectedDocument.Run();
            //LoadDocumentsWithEncoding.Run();
            //SpecifyFileTypeWhenLoadingDocument.Run();
            //SetResourceLoadingTimeout.Run();

            #region Loading documents from different sources

            //LoadDocumentFromLocalDisk.Run();
            //LoadDocumentFromStream.Run();
            //LoadDocumentFromUrl.Run();
            //LoadDocumentFromFtp.Run();
            //LoadDocumentFromAmazonS3.Run();
            //LoadDocumentFromAzureBlobStorage.Run();

            #endregion

            #endregion

            #endregion

            #region HowTo
            //HowToDetermineFileType.FromFileExtension();
            //HowToDetermineFileType.FromMediaType();
            //HowToDetermineFileType.FromStream();
            #endregion

            Console.WriteLine();
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}
