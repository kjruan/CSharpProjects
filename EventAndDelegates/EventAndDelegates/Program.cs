using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "My Vidoe!" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var msgService = new MessageService(); // subscriber

            videoEncoder.videoEncoded += mailService.OnVideoEncoded;
            videoEncoder.videoEncoded += msgService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    public class Video
    {
        public string Title { get; set; } 
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler videoEncoded; 

        public void Encode(Video video)
        {         
            Console.WriteLine("Encoding Video ...");
            Thread.Sleep(3000);

            onVideoEncoded(video); 
        }

        protected virtual void onVideoEncoded(Video video)
        {
            if (videoEncoded != null)
                videoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email ... {0}", e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a message ... {0}", e.Video.Title);
        }
    }
}
