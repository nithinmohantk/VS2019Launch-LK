using CSharp8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public static class CSLauncher
    {

        public static void LaunchDefaultImplementation()
        {
            IConferenceSpeaker _conferenceSpeaker = new ConferenceSpeaker();

            Console.WriteLine("Your Default Speaker is :: " + _conferenceSpeaker.GetSpeakerName());

            _conferenceSpeaker.Speak();

           
        }


        public static void LaunchReadOnly()
        {
            ReadOnlySample.Run();
        }


        public static void LaunchNullables()
        {
            //NullableRefTypesSample.Run();
            NullableRefTypesSample.Run2();
        }
    }
}
