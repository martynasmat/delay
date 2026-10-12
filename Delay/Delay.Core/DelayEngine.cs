namespace Delay.Core
{
    public class DelayEngine
    {
        private float[] _leftBuffer;
        private float[] _rightBuffer;
        private int _pos;

        public DelayEngine(int bufferLength)
        {
            if (bufferLength < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(bufferLength));
            }

            _leftBuffer = new float[bufferLength];
            _rightBuffer = new float[bufferLength];
            _pos = 0;
        }

        public (float Left, float Right) ProcessSample(float inputLeft, float inputRight)
        { 
            float outputLeft = _leftBuffer[_pos];
            float outputRight = _rightBuffer[_pos];

            _leftBuffer[_pos] = inputLeft;
            _rightBuffer[_pos] = inputRight;

            _pos++;

            if (_pos >= _leftBuffer.Length)
            {
                _pos = 0;
            }

            return (outputLeft, outputRight);
        }
    }
}
