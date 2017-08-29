/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace agile
{
    public sealed class vioParams_t : LCM.LCM.LCMEncodable
    {
        public long utime;
        public double rankTolerance;
        public double retriangulation;
        public double relinearizeThreshold;
        public double smootherTime;
        public double outlierRejection;
        public long optTime;
        public long numOptimize;
        public long numFeat;
        public double disparityThreshold;
        public double maxAge;
        public double smartNoiseSigma;
        public double gyroNoiseDensity;
        public double accNoiseDensity;
        public double imuIntegrationSigma;
        public double gyroBiasSigma;
        public double accBiasSigma;
        public double gyroBiasInitialSigma;
        public double accBiasInitialSigma;
        public double noTransSigma;
        public double degeneracyThreshold;
        public double landmarkDistanceThreshold;
 
        public vioParams_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x1d0ef68a54611c08L;
 
        static vioParams_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("agile.vioParams_t"))
                return 0L;
 
            classes.Add("agile.vioParams_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            outs.Write(this.utime); 
 
            outs.Write(this.rankTolerance); 
 
            outs.Write(this.retriangulation); 
 
            outs.Write(this.relinearizeThreshold); 
 
            outs.Write(this.smootherTime); 
 
            outs.Write(this.outlierRejection); 
 
            outs.Write(this.optTime); 
 
            outs.Write(this.numOptimize); 
 
            outs.Write(this.numFeat); 
 
            outs.Write(this.disparityThreshold); 
 
            outs.Write(this.maxAge); 
 
            outs.Write(this.smartNoiseSigma); 
 
            outs.Write(this.gyroNoiseDensity); 
 
            outs.Write(this.accNoiseDensity); 
 
            outs.Write(this.imuIntegrationSigma); 
 
            outs.Write(this.gyroBiasSigma); 
 
            outs.Write(this.accBiasSigma); 
 
            outs.Write(this.gyroBiasInitialSigma); 
 
            outs.Write(this.accBiasInitialSigma); 
 
            outs.Write(this.noTransSigma); 
 
            outs.Write(this.degeneracyThreshold); 
 
            outs.Write(this.landmarkDistanceThreshold); 
 
        }
 
        public vioParams_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public vioParams_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static agile.vioParams_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            agile.vioParams_t o = new agile.vioParams_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.utime = ins.ReadInt64();
 
            this.rankTolerance = ins.ReadDouble();
 
            this.retriangulation = ins.ReadDouble();
 
            this.relinearizeThreshold = ins.ReadDouble();
 
            this.smootherTime = ins.ReadDouble();
 
            this.outlierRejection = ins.ReadDouble();
 
            this.optTime = ins.ReadInt64();
 
            this.numOptimize = ins.ReadInt64();
 
            this.numFeat = ins.ReadInt64();
 
            this.disparityThreshold = ins.ReadDouble();
 
            this.maxAge = ins.ReadDouble();
 
            this.smartNoiseSigma = ins.ReadDouble();
 
            this.gyroNoiseDensity = ins.ReadDouble();
 
            this.accNoiseDensity = ins.ReadDouble();
 
            this.imuIntegrationSigma = ins.ReadDouble();
 
            this.gyroBiasSigma = ins.ReadDouble();
 
            this.accBiasSigma = ins.ReadDouble();
 
            this.gyroBiasInitialSigma = ins.ReadDouble();
 
            this.accBiasInitialSigma = ins.ReadDouble();
 
            this.noTransSigma = ins.ReadDouble();
 
            this.degeneracyThreshold = ins.ReadDouble();
 
            this.landmarkDistanceThreshold = ins.ReadDouble();
 
        }
 
        public agile.vioParams_t Copy()
        {
            agile.vioParams_t outobj = new agile.vioParams_t();
            outobj.utime = this.utime;
 
            outobj.rankTolerance = this.rankTolerance;
 
            outobj.retriangulation = this.retriangulation;
 
            outobj.relinearizeThreshold = this.relinearizeThreshold;
 
            outobj.smootherTime = this.smootherTime;
 
            outobj.outlierRejection = this.outlierRejection;
 
            outobj.optTime = this.optTime;
 
            outobj.numOptimize = this.numOptimize;
 
            outobj.numFeat = this.numFeat;
 
            outobj.disparityThreshold = this.disparityThreshold;
 
            outobj.maxAge = this.maxAge;
 
            outobj.smartNoiseSigma = this.smartNoiseSigma;
 
            outobj.gyroNoiseDensity = this.gyroNoiseDensity;
 
            outobj.accNoiseDensity = this.accNoiseDensity;
 
            outobj.imuIntegrationSigma = this.imuIntegrationSigma;
 
            outobj.gyroBiasSigma = this.gyroBiasSigma;
 
            outobj.accBiasSigma = this.accBiasSigma;
 
            outobj.gyroBiasInitialSigma = this.gyroBiasInitialSigma;
 
            outobj.accBiasInitialSigma = this.accBiasInitialSigma;
 
            outobj.noTransSigma = this.noTransSigma;
 
            outobj.degeneracyThreshold = this.degeneracyThreshold;
 
            outobj.landmarkDistanceThreshold = this.landmarkDistanceThreshold;
 
            return outobj;
        }
    }
}
