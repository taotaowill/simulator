// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: pbf_gatekeeper_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.fusion
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PbfGatekeeperConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PbfGatekeeperConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool publish_if_has_lidar
        {
            get { return __pbn__publish_if_has_lidar ?? true; }
            set { __pbn__publish_if_has_lidar = value; }
        }
        public bool ShouldSerializepublish_if_has_lidar()
        {
            return __pbn__publish_if_has_lidar != null;
        }
        public void Resetpublish_if_has_lidar()
        {
            __pbn__publish_if_has_lidar = null;
        }
        private bool? __pbn__publish_if_has_lidar;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool publish_if_has_radar
        {
            get { return __pbn__publish_if_has_radar ?? true; }
            set { __pbn__publish_if_has_radar = value; }
        }
        public bool ShouldSerializepublish_if_has_radar()
        {
            return __pbn__publish_if_has_radar != null;
        }
        public void Resetpublish_if_has_radar()
        {
            __pbn__publish_if_has_radar = null;
        }
        private bool? __pbn__publish_if_has_radar;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool publish_if_has_camera
        {
            get { return __pbn__publish_if_has_camera ?? true; }
            set { __pbn__publish_if_has_camera = value; }
        }
        public bool ShouldSerializepublish_if_has_camera()
        {
            return __pbn__publish_if_has_camera != null;
        }
        public void Resetpublish_if_has_camera()
        {
            __pbn__publish_if_has_camera = null;
        }
        private bool? __pbn__publish_if_has_camera;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_camera_3d
        {
            get { return __pbn__use_camera_3d ?? true; }
            set { __pbn__use_camera_3d = value; }
        }
        public bool ShouldSerializeuse_camera_3d()
        {
            return __pbn__use_camera_3d != null;
        }
        public void Resetuse_camera_3d()
        {
            __pbn__use_camera_3d = null;
        }
        private bool? __pbn__use_camera_3d;

        [global::ProtoBuf.ProtoMember(5)]
        public double min_radar_confident_distance
        {
            get { return __pbn__min_radar_confident_distance.GetValueOrDefault(); }
            set { __pbn__min_radar_confident_distance = value; }
        }
        public bool ShouldSerializemin_radar_confident_distance()
        {
            return __pbn__min_radar_confident_distance != null;
        }
        public void Resetmin_radar_confident_distance()
        {
            __pbn__min_radar_confident_distance = null;
        }
        private double? __pbn__min_radar_confident_distance;

        [global::ProtoBuf.ProtoMember(6)]
        public double max_radar_confident_angle
        {
            get { return __pbn__max_radar_confident_angle.GetValueOrDefault(); }
            set { __pbn__max_radar_confident_angle = value; }
        }
        public bool ShouldSerializemax_radar_confident_angle()
        {
            return __pbn__max_radar_confident_angle != null;
        }
        public void Resetmax_radar_confident_angle()
        {
            __pbn__max_radar_confident_angle = null;
        }
        private double? __pbn__max_radar_confident_angle;

        [global::ProtoBuf.ProtoMember(7)]
        public double min_camera_publish_distance
        {
            get { return __pbn__min_camera_publish_distance.GetValueOrDefault(); }
            set { __pbn__min_camera_publish_distance = value; }
        }
        public bool ShouldSerializemin_camera_publish_distance()
        {
            return __pbn__min_camera_publish_distance != null;
        }
        public void Resetmin_camera_publish_distance()
        {
            __pbn__min_camera_publish_distance = null;
        }
        private double? __pbn__min_camera_publish_distance;

        [global::ProtoBuf.ProtoMember(8)]
        public double invisible_period_threshold
        {
            get { return __pbn__invisible_period_threshold.GetValueOrDefault(); }
            set { __pbn__invisible_period_threshold = value; }
        }
        public bool ShouldSerializeinvisible_period_threshold()
        {
            return __pbn__invisible_period_threshold != null;
        }
        public void Resetinvisible_period_threshold()
        {
            __pbn__invisible_period_threshold = null;
        }
        private double? __pbn__invisible_period_threshold;

        [global::ProtoBuf.ProtoMember(9)]
        public double toic_threshold
        {
            get { return __pbn__toic_threshold.GetValueOrDefault(); }
            set { __pbn__toic_threshold = value; }
        }
        public bool ShouldSerializetoic_threshold()
        {
            return __pbn__toic_threshold != null;
        }
        public void Resettoic_threshold()
        {
            __pbn__toic_threshold = null;
        }
        private double? __pbn__toic_threshold;

        [global::ProtoBuf.ProtoMember(10)]
        public bool use_track_time_pub_strategy
        {
            get { return __pbn__use_track_time_pub_strategy.GetValueOrDefault(); }
            set { __pbn__use_track_time_pub_strategy = value; }
        }
        public bool ShouldSerializeuse_track_time_pub_strategy()
        {
            return __pbn__use_track_time_pub_strategy != null;
        }
        public void Resetuse_track_time_pub_strategy()
        {
            __pbn__use_track_time_pub_strategy = null;
        }
        private bool? __pbn__use_track_time_pub_strategy;

        [global::ProtoBuf.ProtoMember(11)]
        public int pub_track_time_thresh
        {
            get { return __pbn__pub_track_time_thresh.GetValueOrDefault(); }
            set { __pbn__pub_track_time_thresh = value; }
        }
        public bool ShouldSerializepub_track_time_thresh()
        {
            return __pbn__pub_track_time_thresh != null;
        }
        public void Resetpub_track_time_thresh()
        {
            __pbn__pub_track_time_thresh = null;
        }
        private int? __pbn__pub_track_time_thresh;

        [global::ProtoBuf.ProtoMember(12)]
        public double existance_threshold
        {
            get { return __pbn__existance_threshold.GetValueOrDefault(); }
            set { __pbn__existance_threshold = value; }
        }
        public bool ShouldSerializeexistance_threshold()
        {
            return __pbn__existance_threshold != null;
        }
        public void Resetexistance_threshold()
        {
            __pbn__existance_threshold = null;
        }
        private double? __pbn__existance_threshold;

        [global::ProtoBuf.ProtoMember(13)]
        public double radar_existance_threshold
        {
            get { return __pbn__radar_existance_threshold.GetValueOrDefault(); }
            set { __pbn__radar_existance_threshold = value; }
        }
        public bool ShouldSerializeradar_existance_threshold()
        {
            return __pbn__radar_existance_threshold != null;
        }
        public void Resetradar_existance_threshold()
        {
            __pbn__radar_existance_threshold = null;
        }
        private double? __pbn__radar_existance_threshold;

    }

}

#pragma warning restore 0612, 1591, 3021
