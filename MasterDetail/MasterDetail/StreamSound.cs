using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MasterDetail
{
    public class StreamSound
    {
        public StreamSound(string filename)
        {
            var stream = GetStreamFromFile(filename);
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(stream);
            player.Play();
        }
        public Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("MasterDetail.sounds." + filename);

            return stream;
        }
    }
}
