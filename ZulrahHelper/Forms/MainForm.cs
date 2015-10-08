using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZulrahHelper.GlobalHotkeys;
using ZulrahHelper.UserControls;

namespace ZulrahHelper.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<GlobalHotkey> _globalKeys;
        private readonly SelectionControl _selectionControl;
        private int _localRotIndex;
        private RotationControl _rotControl;

        private Point _selectionSize = new Point(550, 520);
        private Point _rotationSize = new Point(149, 438);

        public MainForm()
        {
            InitializeComponent();

            _globalKeys = new List<GlobalHotkey>
            {
                new GlobalHotkey(Constants.Nomod, Keys.D1, this),
                new GlobalHotkey(Constants.Nomod, Keys.D2, this),
                new GlobalHotkey(Constants.Nomod, Keys.D3, this),
                new GlobalHotkey(Constants.Nomod, Keys.D4, this),
                new GlobalHotkey(Constants.Nomod, Keys.R, this),
                new GlobalHotkey(Constants.Nomod, Keys.E, this)
            };

            FormUtils.DisableResizing(this);

            _selectionControl = new SelectionControl();

            //Set the icon to be the one in resources.
            Icon = Properties.Resources.icon;
        }

        /// <summary>
        ///     Decodes the LParam of a form message.
        /// </summary>
        /// <param name="identifier">The IntPtr type LParam.</param>
        private void DecodeLParam(IntPtr identifier)
        {
            if (identifier == (IntPtr) 3211264) // 1
            {
                HandleNumberKey(1);
            }
            else if (identifier == (IntPtr) 3276800) // 2
            {
                HandleNumberKey(2);
            }
            else if (identifier == (IntPtr) 3342336) // 3
            {
                HandleNumberKey(3);
            }
            else if (identifier == (IntPtr) 3407872) // 4
            {
                HandleNumberKey(4);
            }
            else if (identifier == (IntPtr) 5373952) // r
            {
                Reset();
            }
            else if (identifier == (IntPtr) 4521984) // e
            {
                if (_rotControl == null)
                {
                    _localRotIndex++;
                    UpdateVisualValues(_localRotIndex);
                }
                else
                    _rotControl?.Next();
            }
            else
            {
                MessageBox.Show("Unknown indentifier " + identifier);
            }
        }

        /// <summary>
        ///     Resets the rotations and shows selection.
        /// </summary>
        public void Reset()
        {
            activePanel.Controls.Clear();
            activePanel.Controls.Add(_selectionControl);
            _rotControl = null;

            _localRotIndex = 0;

            UpdateVisualValues(_localRotIndex);

            Size = new Size(_selectionSize);

        }

        /// <summary>
        ///     Updates information values on the  form.
        /// </summary>
        /// <param name="rot">Zero based current rotation number.</param>
        public void UpdateVisualValues(int rot)
        {
            curRotationLabel.Text = "Current stage: " + (rot + 1);
        }

        /// <summary>
        ///     Handles numeric key presses.
        /// </summary>
        /// <param name="key">1-4</param>
        private void HandleNumberKey(int key)
        {
            if (_rotControl == null)
            {
                activePanel.Controls.Clear();
                Size = new Size(_rotationSize);

                switch (key)
                {
                    case 1:
                        _rotControl = new RotationControl(this, RotationData.Rotation1, _localRotIndex);
                        break;
                    case 2:
                        _rotControl = new RotationControl(this, RotationData.Rotation2, _localRotIndex);
                        break;
                    case 3:
                        _rotControl = new RotationControl(this, RotationData.Rotation3, _localRotIndex);
                        break;
                    case 4:
                        _rotControl = new RotationControl(this, RotationData.Rotation4, _localRotIndex);
                        break;
                    default:
                        MessageBox.Show("Out of range handlenumberkey " + key);
                        throw new ArgumentOutOfRangeException(key.ToString());
                }
                activePanel.Controls.Add(_rotControl);
            }
        }

        protected override void WndProc(ref Message m)
        {
            //See if the msg param equates to a HOTKEY type.
            if (m.Msg == Constants.WmHotkeyMsgId)
                DecodeLParam(m.LParam); //if so, decode it.

            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Register all keys in keyslist.
            foreach (var key in _globalKeys)
            {
                if (!key.Register())
                {
                    MessageBox.Show("Hotkey " + (Keys) key.Key + " failed to register. Closing.");
                    Application.Exit();
                }
            }

            //Show the selection control on the panel
            activePanel.Controls.Clear();
            activePanel.Controls.Add(_selectionControl);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Unregister all keys in keyslist.
            foreach (var key in _globalKeys)
            {
                if (!key.Unregiser())
                {
                    MessageBox.Show("Hotkey " + (Keys) key.Key + " failed to unregister!");
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            using (AboutForm about = new AboutForm())
                about.ShowDialog();
        }
    }
}