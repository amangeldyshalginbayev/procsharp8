using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using Path = System.IO.Path;

namespace DataParallelismWithForEach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // New Window-level variable
        private CancellationTokenSource _cancellationToken = new CancellationTokenSource();
        
        public MainWindow()
        {
            InitializeComponent();   
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            // This will be used to tell all the worker threads to stop
            _cancellationToken.Cancel();
        }

        private void cmdProcess_Click(object sender, EventArgs e)
        {
            // Start a new "task" to process the files
            Task.Factory.StartNew(() => ProcessFilesWithCancellationOption());
            // Can also be written as
            //Task.Factory.StartNew(ProcessFiles);
            //Task.Factory.StartNew(ProcessFilesWithCancellationOption);
            //this.Title = "Processing Complete";
        }

        private void ProcessFiles()
        {
            var basePath = Directory.GetCurrentDirectory();
            var pictureDirectory = Path.Combine(basePath, "TestPictures");
            var outputDirectory = Path.Combine(basePath, "ModifiedPictures");
            Directory.CreateDirectory(outputDirectory);

            
            string[] files = Directory.GetFiles(pictureDirectory, "*.jpg", SearchOption.AllDirectories);
            
            // Process image data in a blocking mannner
            // foreach (var currentFile in files)
            // {
            //     
            //     string fileName = System.IO.Path.GetFileName(currentFile);
            //    
            //     using (Bitmap bitMap = new Bitmap(currentFile))
            //     {
            //         bitMap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            //         bitMap.Save(System.IO.Path.Combine(outputDirectory,fileName));
            //         // Print out the ID of the thread processing the current image
            //         this.Title = $"Processing {fileName} on thread {Thread.CurrentThread.ManagedThreadId}";
            //     }
            // }
            Parallel.ForEach(files, currentFile =>
            {
                string fileName = Path.GetFileName(currentFile);

                using (Bitmap bitmap = new Bitmap(currentFile))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(Path.Combine(outputDirectory, fileName));

                    Dispatcher?.Invoke(() =>
                    {
                        this.Title = $"Processing {fileName} on thread {Thread.CurrentThread.ManagedThreadId}";
                    });
                }
            });
        }

        private void ProcessFilesWithCancellationOption()
        {
            // Use ParallelOptions instance to store the CancellationToken
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = _cancellationToken.Token;
            parallelOptions.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
            
            // Load up all *.jpg files,and make a new folder for the modified data.
            string[] files = Directory.GetFiles(@".\TestPictures", "*.jpg", SearchOption.AllDirectories);
            string outputDirectory = @".\ModifiedPictures";
            Directory.CreateDirectory(outputDirectory);

            try
            {
                // Process the image data in a parallel manner
                Parallel.ForEach(files, parallelOptions, currentFile =>
                {
                    parallelOptions.CancellationToken.ThrowIfCancellationRequested();
                    string fileName = Path.GetFileName(currentFile);
                    using (Bitmap bitmap = new Bitmap(currentFile))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(outputDirectory,fileName));
                        Dispatcher?.Invoke(() =>
                        {
                            this.Title = $"Processing {fileName} on thread {Thread.CurrentThread.ManagedThreadId}";
                        });
                    }
                });
                Dispatcher?.Invoke(() => this.Title = "Done!");
            }
            catch (OperationCanceledException ex)
            {
                Dispatcher?.Invoke(() => this.Title = ex.Message);
            }
        }
    }
}