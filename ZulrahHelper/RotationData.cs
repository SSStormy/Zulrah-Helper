using System.Collections.Generic;
using System.Drawing;
using ZulrahHelper.Properties;

namespace ZulrahHelper
{
    public class RotationData
    {
        /// <summary>
        ///     One based index of the last rotation
        /// </summary>
        public int FinalRotation { get; }

        public List<Image> RotationImages { get; }

        private RotationData(int finalRotation, List<Image> rotationImages)
        {
            FinalRotation = finalRotation;
            RotationImages = rotationImages;
        }

        public static RotationData Rotation1
        {
            get
            {
                var images = new List<Image>
                {
                    Resources.pat1_rot0,
                    Resources.pat1_rot1,
                    Resources.pat1_rot2,
                    Resources.pat1_rot3,
                    Resources.pat1_rot4,
                    Resources.pat1_rot5,
                    Resources.pat1_rot6,
                    Resources.pat1_rot7,
                    Resources.pat1_rot8,
                    Resources.pat1_rot9
                };
                return new RotationData(images.Count, images);
            }
        }

        public static RotationData Rotation2
        {
            get
            {
                var images = new List<Image>
                {
                    Resources.pat2_rot0,
                    Resources.pat2_rot1,
                    Resources.pat2_rot2,
                    Resources.pat2_rot3,
                    Resources.pat2_rot4,
                    Resources.pat2_rot5,
                    Resources.pat2_rot6,
                    Resources.pat2_rot7,
                    Resources.pat2_rot8,
                    Resources.pat2_rot9
                };
                return new RotationData(images.Count, images);
            }
        }

        public static RotationData Rotation3
        {
            get
            {
                var images = new List<Image>
                {
                    Resources.pat3_rot0,
                    Resources.pat3_rot1,
                    Resources.pat3_rot2,
                    Resources.pat3_rot3,
                    Resources.pat3_rot4,
                    Resources.pat3_rot5,
                    Resources.pat3_rot6,
                    Resources.pat3_rot7,
                    Resources.pat3_rot8,
                    Resources.pat3_rot9,
                    Resources.pat3_rot10
                };
                return new RotationData(images.Count, images);
            }
        }

        public static RotationData Rotation4
        {
            get
            {
                var images = new List<Image>
                {
                    Resources.pat4_rot0,
                    Resources.pat4_rot1,
                    Resources.pat4_rot2,
                    Resources.pat4_rot3,
                    Resources.pat4_rot4,
                    Resources.pat4_rot5,
                    Resources.pat4_rot6,
                    Resources.pat4_rot7,
                    Resources.pat4_rot8,
                    Resources.pat4_rot9,
                    Resources.pat4_rot10,
                    Resources.pat4_rot11
                };
                return new RotationData(images.Count, images);
            }
        }
    }
}