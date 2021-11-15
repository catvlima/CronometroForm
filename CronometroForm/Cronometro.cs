using System;
using System.Collections.Generic;
using System.Text;

namespace CronometroForm
{
    public class Cronometro
    {

        #region Atributos

        private DateTime _start; //Inicio do cronómetro

        private DateTime _stop; //Fim do cronómetro

        private bool _isrunning; //Está ligado ou desligado


        #endregion


        public void StartClock()
        {
            if (_isrunning)

                throw new InvalidOperationException("O cronómetro já está ligado!");

            _start = DateTime.Now;
            _isrunning = true;
        }

        public void StopClock()
        {
            if (!_isrunning)

                throw new InvalidOperationException("O cronómetro já está desligado!");

            _stop = DateTime.Now;
            _isrunning = false;
        }

        public TimeSpan GetTimeSpan()
        {
            return _stop - _start;
        }

        public bool ClockState()
        {
            return _isrunning;
        }

        public DateTime StartTime()
        {
            return _start;
        }

    }
}
