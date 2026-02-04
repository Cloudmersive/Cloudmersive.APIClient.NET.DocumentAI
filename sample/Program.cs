using System;
using System.IO;
using Newtonsoft.Json;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;

namespace Cloudmersive.APIClient.NET.DocumentAI.Sample
{
    class TestSettings
    {
        public string ApiKey { get; set; }
        public string BasePath { get; set; }
    }

    class Program
    {
        private static readonly string TestSettingsPath = @"C:\BuildTools\test-settings.json";
        private static readonly string TestFilesFolder = "test-files";

        static int Main(string[] args)
        {
            Console.WriteLine("Cloudmersive Document AI Sample Application");
            Console.WriteLine("============================================");
            Console.WriteLine();

            // Load settings from external file
            if (!File.Exists(TestSettingsPath))
            {
                Console.WriteLine($"ERROR: Test settings file not found: {TestSettingsPath}");
                Console.WriteLine("Please create a test-settings.json file with ApiKey and BasePath properties.");
                return 1;
            }

            TestSettings settings;
            try
            {
                var json = File.ReadAllText(TestSettingsPath);
                settings = JsonConvert.DeserializeObject<TestSettings>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Failed to read test settings: {ex.Message}");
                return 1;
            }

            if (string.IsNullOrEmpty(settings.ApiKey) || string.IsNullOrEmpty(settings.BasePath))
            {
                Console.WriteLine("ERROR: ApiKey and BasePath must be set in test-settings.json");
                return 1;
            }

            // Configure the API client
            var config = new Configuration();
            config.BasePath = settings.BasePath;
            config.AddApiKey("Apikey", settings.ApiKey);
            config.Timeout = TimeSpan.FromMinutes(20);

            var extractApi = new ExtractApi(config);

            // Find all PDF files in the test-files folder
            var testFilesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TestFilesFolder);
            if (!Directory.Exists(testFilesPath))
            {
                Console.WriteLine($"ERROR: Test files folder not found: {testFilesPath}");
                Console.WriteLine("Please create the test-files folder and add one or more PDF files.");
                return 1;
            }

            var pdfFiles = Directory.GetFiles(testFilesPath, "*.pdf");
            if (pdfFiles.Length == 0)
            {
                Console.WriteLine($"ERROR: No PDF files found in: {testFilesPath}");
                return 1;
            }

            Console.WriteLine($"Found {pdfFiles.Length} PDF file(s) to process.");
            Console.WriteLine();

            int failureCount = 0;

            foreach (var pdfFile in pdfFiles)
            {
                var fileName = Path.GetFileName(pdfFile);
                Console.WriteLine($"Processing: {fileName}");
                Console.WriteLine(new string('-', 50));

                // Test Extract Text
                if (!TestExtractText(extractApi, pdfFile))
                    failureCount++;

                // Test Extract All Fields and Tables
                if (!TestExtractAllFieldsAndTables(extractApi, pdfFile))
                    failureCount++;

                // Test Extract Summary
                if (!TestExtractSummary(extractApi, pdfFile))
                    failureCount++;

                Console.WriteLine();
            }

            Console.WriteLine("============================================");
            if (failureCount == 0)
            {
                Console.WriteLine("All tests passed!");
                return 0;
            }
            else
            {
                Console.WriteLine($"Tests completed with {failureCount} failure(s).");
                return 1;
            }
        }

        private static void PrintResultJson(object result)
        {
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine("    Result JSON:");
            Console.WriteLine(json);
            Console.WriteLine();
        }

        private static bool TestExtractText(ExtractApi extractApi, string filePath)
        {
            Console.WriteLine("  Extract Text...");
            try
            {
                using (var fileStream = File.OpenRead(filePath))
                {
                    var result = extractApi.ExtractText(inputFile: fileStream);
                    PrintResultJson(result);

                    if (result.Successful != true)
                    {
                        Console.WriteLine($"    FAILED: Successful flag was not true.");
                        return false;
                    }

                    // Assert non-zero length results
                    if (result.PageResults == null || result.PageResults.Count == 0)
                    {
                        Console.WriteLine($"    FAILED: PageResults was null or empty.");
                        return false;
                    }

                    Console.WriteLine($"    PASSED: Extracted text from {result.PageResults.Count} page(s).");
                    return true;
                }
            }
            catch (ApiException ex)
            {
                Console.WriteLine($"    FAILED: API Error {ex.ErrorCode} - {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"    FAILED: Exception - {ex.Message}");
                return false;
            }
        }

        private static bool TestExtractAllFieldsAndTables(ExtractApi extractApi, string filePath)
        {
            Console.WriteLine("  Extract All Fields and Tables...");
            try
            {
                using (var fileStream = File.OpenRead(filePath))
                {
                    var result = extractApi.ExtractAllFieldsAndTables(inputFile: fileStream);
                    PrintResultJson(result);

                    if (result.Successful != true)
                    {
                        Console.WriteLine($"    FAILED: Successful flag was not true.");
                        return false;
                    }

                    // Assert non-zero length results (fields or tables)
                    int fieldCount = result.FieldResults?.Count ?? 0;
                    int tableCount = result.TableResults?.Count ?? 0;

                    if (fieldCount == 0 && tableCount == 0)
                    {
                        Console.WriteLine($"    FAILED: No fields or tables were extracted.");
                        return false;
                    }

                    Console.WriteLine($"    PASSED: Extracted {fieldCount} field(s) and {tableCount} table(s).");
                    return true;
                }
            }
            catch (ApiException ex)
            {
                Console.WriteLine($"    FAILED: API Error {ex.ErrorCode} - {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"    FAILED: Exception - {ex.Message}");
                return false;
            }
        }

        private static bool TestExtractSummary(ExtractApi extractApi, string filePath)
        {
            Console.WriteLine("  Extract Summary...");
            try
            {
                using (var fileStream = File.OpenRead(filePath))
                {
                    var result = extractApi.ExtractSummary(inputFile: fileStream);
                    PrintResultJson(result);

                    if (result.Successful != true)
                    {
                        Console.WriteLine($"    FAILED: Successful flag was not true.");
                        return false;
                    }

                    // Assert non-empty summary text
                    if (string.IsNullOrWhiteSpace(result.DocumentSummaryText))
                    {
                        Console.WriteLine($"    FAILED: DocumentSummaryText was null or empty.");
                        return false;
                    }

                    Console.WriteLine($"    PASSED: Summary length = {result.DocumentSummaryText.Length} chars.");
                    return true;
                }
            }
            catch (ApiException ex)
            {
                Console.WriteLine($"    FAILED: API Error {ex.ErrorCode} - {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"    FAILED: Exception - {ex.Message}");
                return false;
            }
        }
    }
}
