using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;
using NAudio.Wave;



namespace DiscordClone.Business.AudioProcessor
{
    public class AudioProcessorExample
    {

        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        public string fileLocation;
        public string FileName { get; set; }
        public AudioProcessorExample()
        {
            waveIn = new WaveInEvent();
            waveIn.BufferMilliseconds = 50;
            waveIn.WaveFormat = new WaveFormat(44100, 16, 1);
            waveIn.DataAvailable += OnDataAvailable;

        }

        //This method will START recording Audio from your connected 
        public string SetFileName(string name)
        {
            //Sets the file name
            FileName = $"{name}.wav";

            //Set the directory of this apps wwwroot/files folder
            var fileDirectory = $"{Environment.CurrentDirectory}\\wwwroot\\files";

            //Checks if directory exists and creates it if it does NOT
            if (!Directory.Exists(fileDirectory))
                Directory.CreateDirectory(fileDirectory);

            fileLocation = $"{fileDirectory}\\{FileName}";
            writer = new WaveFileWriter(fileLocation, waveIn.WaveFormat);

            return fileLocation;
        }
        public void Start()
        {
            if (FileName is not null)
                waveIn.StartRecording();
        }

        //This method will STOP recording Audio from your connected 
        public void Stop()
        {
            waveIn.StopRecording();
        }

        //This will write the file stream to a new file while audio is recording
        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        //This will dispose of this class when finished with
        public void Dispose()
        {
            waveIn?.StopRecording();
            waveIn?.Dispose();
            writer?.Dispose();
        }
    }

}
