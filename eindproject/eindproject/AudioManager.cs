
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using SoundTouch.Net.NAudioSupport;

namespace eindproject
{
    internal class AudioManager : IDisposable
    {
        private WaveOutEvent musicOutput;
        private AudioFileReader musicReader;
        private SoundTouchWaveStream musicSpeedProvider;

        private readonly List<WaveOutEvent> effectOutputs =
            new List<WaveOutEvent>();

        private readonly List<AudioFileReader> effectReaders =
            new List<AudioFileReader>();

        private readonly object effectLock = new object();

        private bool disposed = false;

        private string AudioPath(string fileName)
        {
            return Path.Combine(
                Application.StartupPath,
                "Audio",
                fileName
            );
        }

        public void PlayMusic(string fileName)
        {
            if (disposed)
                return;

            StopMusic();

            string path = AudioPath(fileName);

            if (!File.Exists(path))
            {
                MessageBox.Show("Music file not found:\n" + path);
                return;
            }

            try
            {
                musicReader = new AudioFileReader(path);

                musicSpeedProvider = new SoundTouchWaveStream(musicReader);

                musicOutput = new WaveOutEvent();

                musicOutput.PlaybackStopped += MusicPlaybackStopped;
                musicOutput.Init(musicSpeedProvider);
                musicOutput.Play();
            }
            catch (Exception ex)
            {
                StopMusic();

                MessageBox.Show("Could not play music:\n" + ex.Message);
            }
        }

        public void SetMusicSpeed(double speed)
        {
            if (musicSpeedProvider == null)
                return;

            if (speed < 0.5 || speed > 2.0)
                return;

            musicSpeedProvider.Tempo = speed;
        }

        public void StopMusic()
        {
            if (musicOutput != null)
            {
                musicOutput.Stop();
            }
        }

        private void MusicPlaybackStopped(object sender, StoppedEventArgs e)
        {
            WaveOutEvent output = sender as WaveOutEvent;

            if (output == null)
                return;

            output.PlaybackStopped -= MusicPlaybackStopped;

            if (musicOutput == output)
            {
                musicOutput = null;
                musicSpeedProvider = null;
                musicReader = null;
            }

            output.Dispose();

            if (e.Exception != null && !disposed)
            {
                MessageBox.Show("Music playback error:\n" + e.Exception.Message);
            }
        }

        public void PlaySound(string fileName)
        {
            if (disposed)
                return;

            string path = AudioPath(fileName);

            if (!File.Exists(path))
            {
                MessageBox.Show("Sound effect not found:\n" + path);
                return;
            }

            AudioFileReader reader = null;
            WaveOutEvent output = null;

            try
            {
                reader = new AudioFileReader(path);
                output = new WaveOutEvent();

                lock (effectLock)
                {
                    if (disposed)
                    {
                        output.Dispose();
                        reader.Dispose();
                        return;
                    }

                    effectOutputs.Add(output);
                    effectReaders.Add(reader);
                }

                output.PlaybackStopped += (sender, args) =>
                {
                    lock (effectLock)
                    {
                        effectOutputs.Remove(output);
                        effectReaders.Remove(reader);
                    }

                    output.Dispose();
                    reader.Dispose();
                };

                output.Init(reader);
                output.Play();
            }
            catch (Exception ex)
            {
                if (output != null)
                {
                    lock (effectLock)
                    {
                        effectOutputs.Remove(output);
                        effectReaders.Remove(reader);
                    }

                    output.Dispose();
                }

                if (reader != null)
                    reader.Dispose();

                MessageBox.Show("Could not play sound effect:\n" + ex.Message);
            }
        }

        public void Dispose()
        {
            if (disposed)
                return;

            disposed = true;

            StopMusic();

            lock (effectLock)
            {
                foreach (WaveOutEvent output in effectOutputs)
                {
                    output.Stop();
                }
            }
        }
    }
}
