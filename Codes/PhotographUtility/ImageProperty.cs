using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotographUtility
{
    public class ImageProperty
    {
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public Type PropertyType { get; set; }
        public object Value { get; set; }
        public ImageProperty() { }
        public ImageProperty(PropertyItem propertyitem)
        {
            Id = propertyitem.Id;
            switch (propertyitem.Id)
            {
                case 0x0000:
                    PropertyName = "GpsVer";
                    break;
                case 0x0001:
                    PropertyName = "GpsLatitudeRef";
                    break;
                case 0x0002:
                    PropertyName = "GpsLatitude";
                    break;
                case 0x0003:
                    PropertyName = "GpsLongitudeRef";
                    break;
                case 0x0004:
                    PropertyName = "GpsLongitude";
                    break;
                case 0x0005:
                    PropertyName = "GpsAltitudeRef";
                    break;
                case 0x0006:
                    PropertyName = "GpsAltitude";
                    break;
                case 0x0007:
                    PropertyName = "GpsGpsTime";
                    break;
                case 0x0008:
                    PropertyName = "GpsGpsSatellites";
                    break;
                case 0x0009:
                    PropertyName = "GpsGpsStatus";
                    break;
                case 0x000A:
                    PropertyName = "GpsGpsMeasureMode";
                    break;
                case 0x000B:
                    PropertyName = "GpsGpsDop";
                    break;
                case 0x000C:
                    PropertyName = "GpsSpeedRef";
                    break;
                case 0x000D:
                    PropertyName = "GpsSpeed";
                    break;
                case 0x000E:
                    PropertyName = "GpsTrackRef";
                    break;
                case 0x000F:
                    PropertyName = "GpsTrack";
                    break;
                case 0x0010:
                    PropertyName = "GpsImgDirRef";
                    break;
                case 0x0011:
                    PropertyName = "GpsImgDir";
                    break;
                case 0x0012:
                    PropertyName = "GpsMapDatum";
                    break;
                case 0x0013:
                    PropertyName = "GpsDestLatRef";
                    break;
                case 0x0014:
                    PropertyName = "GpsDestLat";
                    break;
                case 0x0015:
                    PropertyName = "GpsDestLongRef";
                    break;
                case 0x0016:
                    PropertyName = "GpsDestLong";
                    break;
                case 0x0017:
                    PropertyName = "GpsDestBearRef";
                    break;
                case 0x0018:
                    PropertyName = "GpsDestBear";
                    break;
                case 0x0019:
                    PropertyName = "GpsDestDistRef";
                    break;
                case 0x001A:
                    PropertyName = "GpsDestDist";
                    break;
                case 0x00FE:
                    PropertyName = "NewSubfileType";
                    break;
                case 0x00FF:
                    PropertyName = "SubfileType";
                    break;
                case 0x0100:
                    PropertyName = "ImageWidth";
                    break;
                case 0x0101:
                    PropertyName = "ImageHeight";
                    break;
                case 0x0102:
                    PropertyName = "BitsPerSample";
                    break;
                case 0x0103:
                    PropertyName = "Compression";
                    break;
                case 0x0106:
                    PropertyName = "PhotometricInterp";
                    break;
                case 0x0107:
                    PropertyName = "ThreshHolding";
                    break;
                case 0x0108:
                    PropertyName = "CellWidth";
                    break;
                case 0x0109:
                    PropertyName = "CellHeight";
                    break;
                case 0x010A:
                    PropertyName = "FillOrder";
                    break;
                case 0x010D:
                    PropertyName = "DocumentName";
                    break;
                case 0x010E:
                    PropertyName = "ImageDescription";
                    break;
                case 0x010F:
                    PropertyName = "EquipMake";
                    break;
                case 0x0110:
                    PropertyName = "EquipModel";
                    break;
                case 0x0111:
                    PropertyName = "StripOffsets";
                    break;
                case 0x0112:
                    PropertyName = "Orientation";
                    break;
                case 0x0115:
                    PropertyName = "SamplesPerPixel";
                    break;
                case 0x0116:
                    PropertyName = "RowsPerStrip";
                    break;
                case 0x0117:
                    PropertyName = "StripBytesCount";
                    break;
                case 0x0118:
                    PropertyName = "MinSampleValue";
                    break;
                case 0x0119:
                    PropertyName = "MaxSampleValue";
                    break;
                case 0x011A:
                    PropertyName = "XResolution";
                    break;
                case 0x011B:
                    PropertyName = "YResolution";
                    break;
                case 0x011C:
                    PropertyName = "PlanarConfig";
                    break;
                case 0x011D:
                    PropertyName = "PageName";
                    break;
                case 0x011E:
                    PropertyName = "XPosition";
                    break;
                case 0x011F:
                    PropertyName = "YPosition";
                    break;
                case 0x0120:
                    PropertyName = "FreeOffset";
                    break;
                case 0x0121:
                    PropertyName = "FreeByteCounts";
                    break;
                case 0x0122:
                    PropertyName = "GrayResponseUnit";
                    break;
                case 0x0123:
                    PropertyName = "GrayResponseCurve";
                    break;
                case 0x0124:
                    PropertyName = "T4Option";
                    break;
                case 0x0125:
                    PropertyName = "T6Option";
                    break;
                case 0x0128:
                    PropertyName = "ResolutionUnit";
                    break;
                case 0x0129:
                    PropertyName = "PageNumber";
                    break;
                case 0x012D:
                    PropertyName = "TransferFunction";
                    break;
                case 0x0131:
                    PropertyName = "SoftwareUsed";
                    break;
                case 0x0132:
                    PropertyName = "DateTime";
                    break;
                case 0x013B:
                    PropertyName = "Artist";
                    break;
                case 0x013C:
                    PropertyName = "HostComputer";
                    break;
                case 0x013D:
                    PropertyName = "Predictor";
                    break;
                case 0x013E:
                    PropertyName = "WhitePoint";
                    break;
                case 0x013F:
                    PropertyName = "PrimaryChromaticities";
                    break;
                case 0x0140:
                    PropertyName = "ColorMap";
                    break;
                case 0x0141:
                    PropertyName = "HalftoneHints";
                    break;
                case 0x0142:
                    PropertyName = "TileWidth";
                    break;
                case 0x0143:
                    PropertyName = "TileLength";
                    break;
                case 0x0144:
                    PropertyName = "TileOffset";
                    break;
                case 0x0145:
                    PropertyName = "TileByteCounts";
                    break;
                case 0x014C:
                    PropertyName = "InkSet";
                    break;
                case 0x014D:
                    PropertyName = "InkNames";
                    break;
                case 0x014E:
                    PropertyName = "NumberOfInks";
                    break;
                case 0x0150:
                    PropertyName = "DotRange";
                    break;
                case 0x0151:
                    PropertyName = "TargetPrinter";
                    break;
                case 0x0152:
                    PropertyName = "ExtraSamples";
                    break;
                case 0x0153:
                    PropertyName = "SampleFormat";
                    break;
                case 0x0154:
                    PropertyName = "SMinSampleValue";
                    break;
                case 0x0155:
                    PropertyName = "SMaxSampleValue";
                    break;
                case 0x0156:
                    PropertyName = "TransferRange";
                    break;
                case 0x0200:
                    PropertyName = "JPEGProc";
                    break;
                case 0x0201:
                    PropertyName = "JPEGInterFormat";
                    break;
                case 0x0202:
                    PropertyName = "JPEGInterLength";
                    break;
                case 0x0203:
                    PropertyName = "JPEGRestartInterval";
                    break;
                case 0x0205:
                    PropertyName = "JPEGLosslessPredictors";
                    break;
                case 0x0206:
                    PropertyName = "JPEGPointTransforms";
                    break;
                case 0x0207:
                    PropertyName = "JPEGQTables";
                    break;
                case 0x0208:
                    PropertyName = "JPEGDCTables";
                    break;
                case 0x0209:
                    PropertyName = "JPEGACTables";
                    break;
                case 0x0211:
                    PropertyName = "YCbCrCoefficients";
                    break;
                case 0x0212:
                    PropertyName = "YCbCrSubsampling";
                    break;
                case 0x0213:
                    PropertyName = "YCbCrPositioning";
                    break;
                case 0x0214:
                    PropertyName = "REFBlackWhite";
                    break;
                case 0x0301:
                    PropertyName = "Gamma";
                    break;
                case 0x0302:
                    PropertyName = "ICCProfileDescriptor";
                    break;
                case 0x0303:
                    PropertyName = "SRGBRenderingIntent";
                    break;
                case 0x0320:
                    PropertyName = "ImageTitle";
                    break;
                case 0x5001:
                    PropertyName = "ResolutionXUnit";
                    break;
                case 0x5002:
                    PropertyName = "ResolutionYUnit";
                    break;
                case 0x5003:
                    PropertyName = "ResolutionXLengthUnit";
                    break;
                case 0x5004:
                    PropertyName = "ResolutionYLengthUnit";
                    break;
                case 0x5005:
                    PropertyName = "PrintFlags";
                    break;
                case 0x5006:
                    PropertyName = "PrintFlagsVersion";
                    break;
                case 0x5007:
                    PropertyName = "PrintFlagsCrop";
                    break;
                case 0x5008:
                    PropertyName = "PrintFlagsBleedWidth";
                    break;
                case 0x5009:
                    PropertyName = "PrintFlagsBleedWidthScale";
                    break;
                case 0x500A:
                    PropertyName = "HalftoneLPI";
                    break;
                case 0x500B:
                    PropertyName = "HalftoneLPIUnit";
                    break;
                case 0x500C:
                    PropertyName = "HalftoneDegree";
                    break;
                case 0x500D:
                    PropertyName = "HalftoneShape";
                    break;
                case 0x500E:
                    PropertyName = "HalftoneMisc";
                    break;
                case 0x500F:
                    PropertyName = "HalftoneScreen";
                    break;
                case 0x5010:
                    PropertyName = "JPEGQuality";
                    break;
                case 0x5011:
                    PropertyName = "GridSize";
                    break;
                case 0x5012:
                    PropertyName = "ThumbnailFormat";
                    break;
                case 0x5013:
                    PropertyName = "ThumbnailWidth";
                    break;
                case 0x5014:
                    PropertyName = "ThumbnailHeight";
                    break;
                case 0x5015:
                    PropertyName = "ThumbnailColorDepth";
                    break;
                case 0x5016:
                    PropertyName = "ThumbnailPlanes";
                    break;
                case 0x5017:
                    PropertyName = "ThumbnailRawBytes";
                    break;
                case 0x5018:
                    PropertyName = "ThumbnailSize";
                    break;
                case 0x5019:
                    PropertyName = "ThumbnailCompressedSize";
                    break;
                case 0x501A:
                    PropertyName = "ColorTransferFunction";
                    break;
                case 0x501B:
                    PropertyName = "ThumbnailData";
                    break;
                case 0x5020:
                    PropertyName = "ThumbnailImageWidth";
                    break;
                case 0x5021:
                    PropertyName = "ThumbnailImageHeight";
                    break;
                case 0x5022:
                    PropertyName = "ThumbnailBitsPerSample";
                    break;
                case 0x5023:
                    PropertyName = "ThumbnailCompression";
                    break;
                case 0x5024:
                    PropertyName = "ThumbnailPhotometricInterp";
                    break;
                case 0x5025:
                    PropertyName = "ThumbnailImageDescription";
                    break;
                case 0x5026:
                    PropertyName = "ThumbnailEquipMake";
                    break;
                case 0x5027:
                    PropertyName = "ThumbnailEquipModel";
                    break;
                case 0x5028:
                    PropertyName = "ThumbnailStripOffsets";
                    break;
                case 0x5029:
                    PropertyName = "ThumbnailOrientation";
                    break;
                case 0x502A:
                    PropertyName = "ThumbnailSamplesPerPixel";
                    break;
                case 0x502B:
                    PropertyName = "ThumbnailRowsPerStrip";
                    break;
                case 0x502C:
                    PropertyName = "ThumbnailStripBytesCount";
                    break;
                case 0x502D:
                    PropertyName = "ThumbnailResolutionX";
                    break;
                case 0x502E:
                    PropertyName = "ThumbnailResolutionY";
                    break;
                case 0x502F:
                    PropertyName = "ThumbnailPlanarConfig";
                    break;
                case 0x5030:
                    PropertyName = "ThumbnailResolutionUnit";
                    break;
                case 0x5031:
                    PropertyName = "ThumbnailTransferFunction";
                    break;
                case 0x5032:
                    PropertyName = "ThumbnailSoftwareUsed";
                    break;
                case 0x5033:
                    PropertyName = "ThumbnailDateTime";
                    break;
                case 0x5034:
                    PropertyName = "ThumbnailArtist";
                    break;
                case 0x5035:
                    PropertyName = "ThumbnailWhitePoint";
                    break;
                case 0x5036:
                    PropertyName = "ThumbnailPrimaryChromaticities";
                    break;
                case 0x5037:
                    PropertyName = "ThumbnailYCbCrCoefficients";
                    break;
                case 0x5038:
                    PropertyName = "ThumbnailYCbCrSubsampling";
                    break;
                case 0x5039:
                    PropertyName = "ThumbnailYCbCrPositioning";
                    break;
                case 0x503A:
                    PropertyName = "ThumbnailRefBlackWhite";
                    break;
                case 0x503B:
                    PropertyName = "ThumbnailCopyRight";
                    break;
                case 0x5090:
                    PropertyName = "LuminanceTable";
                    break;
                case 0x5091:
                    PropertyName = "ChrominanceTable";
                    break;
                case 0x5100:
                    PropertyName = "FrameDelay";
                    break;
                case 0x5101:
                    PropertyName = "LoopCount";
                    break;
                case 0x5102:
                    PropertyName = "GlobalPalette";
                    break;
                case 0x5103:
                    PropertyName = "IndexBackground";
                    break;
                case 0x5104:
                    PropertyName = "IndexTransparent";
                    break;
                case 0x5110:
                    PropertyName = "PixelUnit";
                    break;
                case 0x5111:
                    PropertyName = "PixelPerUnitX";
                    break;
                case 0x5112:
                    PropertyName = "PixelPerUnitY";
                    break;
                case 0x5113:
                    PropertyName = "PaletteHistogram";
                    break;
                case 0x8298:
                    PropertyName = "Copyright";
                    break;
                case 0x829A:
                    PropertyName = "ExifExposureTime";
                    break;
                case 0x829D:
                    PropertyName = "ExifFNumber";
                    break;
                case 0x8769:
                    PropertyName = "ExifIFD";
                    break;
                case 0x8773:
                    PropertyName = "ICCProfile";
                    break;
                case 0x8822:
                    PropertyName = "ExifExposureProg";
                    break;
                case 0x8824:
                    PropertyName = "ExifSpectralSense";
                    break;
                case 0x8825:
                    PropertyName = "GpsIFD";
                    break;
                case 0x8827:
                    PropertyName = "ExifISOSpeed";
                    break;
                case 0x8828:
                    PropertyName = "ExifOECF";
                    break;
                case 0x9000:
                    PropertyName = "ExifVer";
                    break;
                case 0x9003:
                    PropertyName = "ExifDTOrig";
                    break;
                case 0x9004:
                    PropertyName = "ExifDTDigitized";
                    break;
                case 0x9101:
                    PropertyName = "ExifCompConfig";
                    break;
                case 0x9102:
                    PropertyName = "ExifCompBPP";
                    break;
                case 0x9201:
                    PropertyName = "ExifShutterSpeed";
                    break;
                case 0x9202:
                    PropertyName = "ExifAperture";
                    break;
                case 0x9203:
                    PropertyName = "ExifBrightness";
                    break;
                case 0x9204:
                    PropertyName = "ExifExposureBias";
                    break;
                case 0x9205:
                    PropertyName = "ExifMaxAperture";
                    break;
                case 0x9206:
                    PropertyName = "ExifSubjectDist";
                    break;
                case 0x9207:
                    PropertyName = "ExifMeteringMode";
                    break;
                case 0x9208:
                    PropertyName = "ExifLightSource";
                    break;
                case 0x9209:
                    PropertyName = "ExifFlash";
                    break;
                case 0x920A:
                    PropertyName = "ExifFocalLength";
                    break;
                case 0x927C:
                    PropertyName = "ExifMakerNote";
                    break;
                case 0x9286:
                    PropertyName = "ExifUserComment";
                    break;
                case 0x9290:
                    PropertyName = "ExifDTSubsec";
                    break;
                case 0x9291:
                    PropertyName = "ExifDTOrigSS";
                    break;
                case 0x9292:
                    PropertyName = "ExifDTDigSS";
                    break;
                case 0xA000:
                    PropertyName = "ExifFPXVer";
                    break;
                case 0xA001:
                    PropertyName = "ExifColorSpace";
                    break;
                case 0xA002:
                    PropertyName = "ExifPixXDim";
                    break;
                case 0xA003:
                    PropertyName = "ExifPixYDim";
                    break;
                case 0xA004:
                    PropertyName = "ExifRelatedWav";
                    break;
                case 0xA005:
                    PropertyName = "ExifInterop";
                    break;
                case 0xA20B:
                    PropertyName = "ExifFlashEnergy";
                    break;
                case 0xA20C:
                    PropertyName = "ExifSpatialFR";
                    break;
                case 0xA20E:
                    PropertyName = "ExifFocalXRes";
                    break;
                case 0xA20F:
                    PropertyName = "ExifFocalYRes";
                    break;
                case 0xA210:
                    PropertyName = "ExifFocalResUnit";
                    break;
                case 0xA214:
                    PropertyName = "ExifSubjectLoc";
                    break;
                case 0xA215:
                    PropertyName = "ExifExposureIndex";
                    break;
                case 0xA217:
                    PropertyName = "ExifSensingMethod";
                    break;
                case 0xA300:
                    PropertyName = "ExifFileSource";
                    break;
                case 0xA301:
                    PropertyName = "ExifSceneType";
                    break;
                case 0xA302:
                    PropertyName = "ExifCfaPattern";
                    break;
            }
            switch (propertyitem.Type)
            {
                case 1:
                case 6:
                    PropertyType = typeof(byte[]);
                    Value = propertyitem.Value;
                    break;
                case 2:
                    PropertyType = typeof(string);
                    Value = Encoding.ASCII.GetString(propertyitem.Value);
                    break;
                case 3:
                    PropertyType = typeof(UInt16[]);
                    var v3 = propertyitem.Value;
                    if (v3.Length != 2) Value = null;
                    Value = Convert.ToUInt16(v3[1] << 8 | v3[0]);
                    break;
                case 4:
                    PropertyType = typeof(UInt32[]);
                    var v4 = propertyitem.Value;
                    if (v4.Length != 2) Value = null;
                    Value = Convert.ToUInt32(v4[3] << 24 | v4[2] << 16 | v4[1] << 8 | v4[0]);
                    break;
                case 5:
                    PropertyType = typeof(UInt32[]);
                    var v5 = propertyitem.Value;
                    if (v5.Length != 8) Value = null;                    
                    UInt32 fz5 = Convert.ToUInt32(v5[7] << 24 | v5[6] << 16 | v5[5] << 8 | v5[4]);
                    UInt32 fm5 = Convert.ToUInt32(v5[3] << 24 | v5[2] << 16 | v5[1] << 8 | v5[0]);
                    Value = new UInt32[] { fz5, fm5 };
                    break;
                case 7:
                    PropertyType = typeof(Int32[]);
                    var v7 = propertyitem.Value;
                    Int32[] Val7 = new Int32[propertyitem.Value.Length/4];
                    for (int i = 0; i < Val7.Length; i++)
                    {
                        Val7[i] = Convert.ToInt32(v7[i+3] << 24 | v7[i+2] << 16 | v7[i+1] << 8 | v7[i]);
                    }
                    Value = Val7;
                    break;
                case 10:
                    PropertyType = typeof(Int32[]);
                    var v10 = propertyitem.Value;
                    if (v10.Length != 8) Value = null;
                    Int32 fz10 = Convert.ToInt32(v10[7] << 24 | v10[6] << 16 | v10[5] << 8 | v10[4]);
                    Int32 fm10 = Convert.ToInt32(v10[3] << 24 | v10[2] << 16 | v10[1] << 8 | v10[0]);
                    Value = new Int32[] { fz10, fm10 };
                    break;
                default:
                    break;
            }
        }
    }
}
