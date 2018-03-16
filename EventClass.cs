using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Serialization_App
{
    /// <summary>
    /// Class Video
    /// </summary>
    class Video
    {
        private static ILog log
     = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Class Video having properties
        /// </summary>
        public String Title { get; set; }
    }
    class VideoEncoder
    {
        /// <summary>
        /// creating Delegates
        /// </summary>
        /// <param name="obj">Source object</param>
        /// <param name="args">EventData</param>
        public delegate void VideEncodingEventHandler(object obj, EventArgs args);
        /// <summary>
        /// creting Event using Delegates(Name With NamingConvention)
        /// </summary>
        public event VideEncodingEventHandler Event;
        /// <summary>
        /// Method of class VideoEncoder
        /// </summary>
        /// <param name="video">passing Video class Object instance</param>
        public void Encoder(Video video)
        {
            Console.WriteLine("Lecture runnning ...........");
            Thread.Sleep(5000);///lecture is running for 5 sec
            OnVideoEncoder();///EventHandler method Call
        }
        /// <summary>
        /// Raising Event 
        /// </summary>
        protected virtual void OnVideoEncoder()
        {
            if (Event != null)
                Event(this, EventArgs.Empty);

        }
    }
    public class EventClass
    {
        /// <summary>
        /// main method Entry point Code 
        /// </summary>
        static void Main(string[] args)
        {
            Video v = new Video() { Title = "Lecture" };///setting value through anayomous class 
            VideoEncoder vedio = new VideoEncoder();//publisher
            MailService ms = new MailService();//subscriber
            MessageService messageService = new MessageService();//subscriber
            vedio.Event += ms.OnVideoEncoded;///multicast delegates
            vedio.Event += messageService.OnVideoEncoded;///multicast delegates
            vedio.Encoder(v);///passing video class instance to Encode method
            Console.ReadKey();

        }
    }
    /// <summary>
    /// Mail service Subscriber
    /// </summary>
    public class MailService
    {
        /// <summary>
        /// On completion of duration MailServcie sent to Publiser
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public void OnVideoEncoded(object obj, EventArgs args)
        {
            Console.WriteLine("Mail Sending..................");
        }
    }
    public class MessageService
    {
        /// <summary>
        /// Event Handler
        /// </summary>
        /// <param name="source">Source Object</param>
        /// <param name="args">Event data</param>
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("sending text Message............");
        }
    }
}