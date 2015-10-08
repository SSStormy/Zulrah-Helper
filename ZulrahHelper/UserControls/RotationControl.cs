using System.Windows.Forms;
using ZulrahHelper.Forms;

namespace ZulrahHelper.UserControls
{
    public partial class RotationControl : UserControl
    {
        private readonly MainForm _owner;
        private readonly RotationData _rotationData;
        private int _currentRotation;

        public RotationControl()
        {
            InitializeComponent();
        }

        public RotationControl(MainForm owner, RotationData rotationData, int localRotIndex)
        {
            InitializeComponent();

            _owner = owner;
            _rotationData = rotationData;
            _currentRotation = _currentRotation + localRotIndex;

            UpdateValues();
        }

        public void Next()
        {
            _currentRotation++;

            //If we have passed the final rotation we reset
            if (_currentRotation >= _rotationData.FinalRotation)
                _owner.Reset();

            else
                UpdateValues();
        }

        private void UpdateValues()
        {
            //Check if user has went overboard on incrementing the cur. rot. in selection.
            if (_currentRotation + 1 > _rotationData.FinalRotation)
            {
                //Reset if so
                _owner.Reset();
            }
            else
            {
                //Set the current rotation image to match the one in the rotation data image list current rotation index.
                CurrentPicture.Image = _rotationData.RotationImages[_currentRotation];

                //Make sure we dont get an out of range exception if we are one behind the final rotation value.
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression ; it'll be too messy if we do convert it.
                if (_currentRotation + 1 <= _rotationData.FinalRotation - 1)
                    //_current rotation is zero based so we remove one from final rotation as it is one based.
                    NextPicture.Image = _rotationData.RotationImages[_currentRotation + 1];
                else
                    NextPicture.Image = null;

                _owner.UpdateVisualValues(_currentRotation);
            }
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            _owner.Reset();
        }
    }
}