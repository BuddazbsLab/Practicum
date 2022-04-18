using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;

namespace ASCII_Art
{
    internal class WebCab
    {
        private  FilterInfoCollection videoDevices;

        public void ShowWebCam()
        {
            // enumerate video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // create video source
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            // set NewFrame event handler
            videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            // start the video source
            videoSource.Start();

            // signal to stop when you no longer need capturing
            videoSource.SignalToStop();
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;
        }

    }
}
