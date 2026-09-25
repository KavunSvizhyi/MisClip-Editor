using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;
using FFMpegCore;

namespace MisClip_Editor.Core
{
    public static class Editor
    {
        public static bool JoinVideo(string outputPath, params string[] inputPaths)
        {
            return FFMpeg.Join(outputPath, inputPaths);
        }

        public static bool JoinImage(string outputPath, int framerate, params string[] imagePaths)
        {
            return FFMpeg.JoinImageSequence(outputPath, framerate, imagePaths);
        }

        public static bool Cut(string inputPath, string outputPath, int start, int end)
        {
            return FFMpeg.SubVideo(inputPath, outputPath, TimeSpan.FromSeconds(start), TimeSpan.FromSeconds(end));
        }

        public static bool Mute(string inputPath, string outputPath)
        {
            return FFMpeg.Mute(inputPath, outputPath);
        }

        public static bool ExtractAudio(string inputPath, string outputPath)
        {
            return FFMpeg.ExtractAudio(inputPath, outputPath);
        }

        public static bool AddOrReplaceAudio(string inputPath, string inputAudioPath, string outputPath)
        {
            return FFMpeg.ReplaceAudio(inputPath, inputAudioPath, outputPath);
        }
    }
}
