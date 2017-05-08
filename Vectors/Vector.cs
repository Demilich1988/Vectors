namespace Vectors
{
     class Vector
    {
       

        //Get and Set for the vector variables
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        

        /// <summary>
        /// Overloaded operator for addition
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(
               v1.X + v2.X,
               v1.Y + v2.Y,
               v1.Z + v2.Z);
        }

        /// <summary>
        /// Overload Operator subtraction
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(
                v1.X - v2.X,
                v1.Y - v2.Y,
                v1.Z - v2.Z
                );
        }

        /// <summary>
        /// Overloaded operator to change direction of vector
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y, -v.Z);
        }

        /// <summary>
        /// Overloaded Method for operator with scalar
        /// </summary>
        /// <param name="v"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static Vector operator +(Vector v , double scalar)
        {
            return new Vector(v.X+scalar, v.Y+scalar, v.Z+scalar);
        }

        /// <summary>
        /// Overload Method for * operator
        /// </summary>
        /// <param name="v"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(
                v.X * scalar,
                v.Y * scalar,
                v.Z * scalar
                );
        }

        /// <summary>
        /// Overload Method for / operator
        /// </summary>
        /// <param name="v"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static Vector operator /(Vector v, double scalar)
        {
            return new Vector(
                v.X / scalar,
                v.Y / scalar,
                v.Z / scalar
                );
        }

        /// <summary>
        /// Overridden to make it easy to print out vectors.
        /// This return the vector in the format <x, y, z>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "<" + X + ", " + Y + ", " + Z + ">";
        }
    }
}