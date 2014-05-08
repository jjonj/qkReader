using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace qkReader
{
    /// <summary>
    ///  This class is responsible for controlling active text and forwarding the displaying of it.
    /// </summary>
    class Reader
    {
        #region constants

        /// <summary>
        ///  The duration for which the first displayed word will stay before starting.
        /// </summary>
        private static double START_WORD_INTERVAL = 500;

        /// <summary>
        ///  The multiple of maxWPM that is added to the currentWPM until it reaches top speed.
        ///  Note that the speedup will be exponential.
        /// </summary>
        private static double WPM_ACCELERATION_FACTOR = 0.1;

        #endregion


        #region MemberFunctions

        public Reader(TextSource textSource, TextRenderer textRenderer, double maxWPM)
        {
            this.maxWPM = maxWPM;
            this.textRenderer = textRenderer;
            this.textSource = textSource;

            this.wordTimer = new Timer(START_WORD_INTERVAL);
            wordTimer.Elapsed += new ElapsedEventHandler(wordTimerHandler);
            
        }

        public void start(bool accelerate)
        {
            if (accelerate)
            {
                currentWPM = 60000 / START_WORD_INTERVAL; // 60 seconds divided by the first word duration
            }
            else
            {
                currentWPM = maxWPM;
            }

            wordTimer.Start();
        }

        /// <summary>
        ///  Pauses the reader at the current word. The reader can be resumed with call to start.
        /// </summary>
        public void pause()
        {
            wordTimer.Stop();
        }

        /// <summary>
        ///  Completely stops the reader. The displayed text will be set to default and 
        ///  subsequent start calls will start the reader from the beginning.
        /// </summary>
        public void stop()
        {
            wordTimer.Stop();
        }

        /// <summary>
        ///  Returns the current WPM of the reader.
        /// </summary>
        public double getCurrentWPM()
        {
            return currentWPM;
        }

        /// <summary>
        ///  Eventhandler for the wordTimer. This is where the actual text logic happens.
        /// </summary>
        public void wordTimerHandler(object source, ElapsedEventArgs e)
        {
            if (currentWPM < maxWPM) 
            {
                wordTimer.Interval += maxWPM * WPM_ACCELERATION_FACTOR; 
            }
            textRenderer.displayText( textSource.getNextWord() );
        }

        #endregion



        #region MemberVariables

        /// <summary>
        ///  The top speed in Words Per Minute that this reader will run at
        /// </summary>
        private double maxWPM;

        /// <summary>
        ///  The current WPM speed
        /// </summary>
        private double currentWPM;

        /// <summary>
        ///  The source of the text being read
        /// </summary>
        private TextSource textSource;

        /// <summary>
        ///  Object responsible for accepting text-rendering operations chosen by this reader
        /// </summary>
        private TextRenderer textRenderer;

        /// <summary>
        ///  Timer used for switching between words.
        /// </summary>
        private Timer wordTimer;

        #endregion

    }
}
