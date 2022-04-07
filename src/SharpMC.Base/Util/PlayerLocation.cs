﻿using System;
using System.Numerics;

namespace SharpMC.Util
{
    //Credits to https://github.com/NiclasOlofsson/MiNET
    public class PlayerLocation : ICloneable
    {
        public PlayerLocation()
        {
        }

        public PlayerLocation(float x, float y, float z, float headYaw = 0f, float yaw = 0f, float pitch = 0f)
        {
            X = x;
            Y = y;
            Z = z;

            HeadYaw = headYaw;
            Yaw = yaw;
            Pitch = pitch;
        }

        public PlayerLocation(double x, double y, double z, float headYaw = 0f, float yaw = 0f, float pitch = 0f) :
            this((float) x, (float) y, (float) z, headYaw, yaw, pitch)
        {
        }

        public PlayerLocation(Vector3 vector, float headYaw = 0f, float yaw = 0f, float pitch = 0f) : this(vector.X,
            vector.Y, vector.Z, headYaw, yaw, pitch)
        {
        }

        public BlockCoordinates GetCoordinates3D()
        {
            return new BlockCoordinates((int) X, (int) Y, (int) Z);
        }

        public double DistanceTo(PlayerLocation other)
        {
            return Math.Sqrt(Square(other.X - X) +
                             Square(other.Y - Y) +
                             Square(other.Z - Z));
        }

        private double Square(double num)
        {
            return num * num;
        }

        public Vector3 GetDirection()
        {
            Vector3 vector = new Vector3();

            double pitch = Pitch.ToRadians();
            double yaw = Yaw.ToRadians();
            vector.X = (float) (-Math.Sin(yaw) * Math.Cos(pitch));
            vector.Y = (float) -Math.Sin(pitch);
            vector.Z = (float) (Math.Cos(yaw) * Math.Cos(pitch));

            return vector;
        }

        public Vector3 GetHeadDirection()
        {
            Vector3 vector = new Vector3();

            double pitch = Pitch.ToRadians();
            double yaw = HeadYaw.ToRadians();
            vector.X = (float) (-Math.Sin(yaw) * Math.Cos(pitch));
            vector.Y = (float) -Math.Sin(pitch);
            vector.Z = (float) (Math.Cos(yaw) * Math.Cos(pitch));

            return vector;
        }

        public override string ToString()
        {
            return $"X={X}, Y={Y}, Z={Z}, HeadYaw={HeadYaw}, Yaw={Yaw}, Pich={Pitch}, ";
        }

        public PlayerLocation(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float HeadYaw { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        public bool OnGround { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3 ToVector3()
        {
            return Vectors.Create(X, Y, Z);
        }

        public PlayerLocation CloneTo()
        {
            return new PlayerLocation(X, Y, Z)
            {
                Yaw = Yaw, Pitch = Pitch, OnGround = OnGround
            };
        }

        public object Clone() => CloneTo();
    }
}