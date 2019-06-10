// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: conti_radar_conf.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.drivers.conti_radar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CanConf : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CanConf()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.drivers.canbus.CANCardParameter can_card_parameter { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_debug_mode
        {
            get { return __pbn__enable_debug_mode ?? false; }
            set { __pbn__enable_debug_mode = value; }
        }
        public bool ShouldSerializeenable_debug_mode()
        {
            return __pbn__enable_debug_mode != null;
        }
        public void Resetenable_debug_mode()
        {
            __pbn__enable_debug_mode = null;
        }
        private bool? __pbn__enable_debug_mode;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_receiver_log
        {
            get { return __pbn__enable_receiver_log ?? false; }
            set { __pbn__enable_receiver_log = value; }
        }
        public bool ShouldSerializeenable_receiver_log()
        {
            return __pbn__enable_receiver_log != null;
        }
        public void Resetenable_receiver_log()
        {
            __pbn__enable_receiver_log = null;
        }
        private bool? __pbn__enable_receiver_log;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_sender_log
        {
            get { return __pbn__enable_sender_log ?? false; }
            set { __pbn__enable_sender_log = value; }
        }
        public bool ShouldSerializeenable_sender_log()
        {
            return __pbn__enable_sender_log != null;
        }
        public void Resetenable_sender_log()
        {
            __pbn__enable_sender_log = null;
        }
        private bool? __pbn__enable_sender_log;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RadarConf : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RadarConf()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool max_distance_valid
        {
            get { return __pbn__max_distance_valid ?? false; }
            set { __pbn__max_distance_valid = value; }
        }
        public bool ShouldSerializemax_distance_valid()
        {
            return __pbn__max_distance_valid != null;
        }
        public void Resetmax_distance_valid()
        {
            __pbn__max_distance_valid = null;
        }
        private bool? __pbn__max_distance_valid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool sensor_id_valid
        {
            get { return __pbn__sensor_id_valid ?? false; }
            set { __pbn__sensor_id_valid = value; }
        }
        public bool ShouldSerializesensor_id_valid()
        {
            return __pbn__sensor_id_valid != null;
        }
        public void Resetsensor_id_valid()
        {
            __pbn__sensor_id_valid = null;
        }
        private bool? __pbn__sensor_id_valid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool radar_power_valid
        {
            get { return __pbn__radar_power_valid ?? false; }
            set { __pbn__radar_power_valid = value; }
        }
        public bool ShouldSerializeradar_power_valid()
        {
            return __pbn__radar_power_valid != null;
        }
        public void Resetradar_power_valid()
        {
            __pbn__radar_power_valid = null;
        }
        private bool? __pbn__radar_power_valid;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool output_type_valid
        {
            get { return __pbn__output_type_valid ?? true; }
            set { __pbn__output_type_valid = value; }
        }
        public bool ShouldSerializeoutput_type_valid()
        {
            return __pbn__output_type_valid != null;
        }
        public void Resetoutput_type_valid()
        {
            __pbn__output_type_valid = null;
        }
        private bool? __pbn__output_type_valid;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool send_quality_valid
        {
            get { return __pbn__send_quality_valid ?? true; }
            set { __pbn__send_quality_valid = value; }
        }
        public bool ShouldSerializesend_quality_valid()
        {
            return __pbn__send_quality_valid != null;
        }
        public void Resetsend_quality_valid()
        {
            __pbn__send_quality_valid = null;
        }
        private bool? __pbn__send_quality_valid;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool send_ext_info_valid
        {
            get { return __pbn__send_ext_info_valid ?? true; }
            set { __pbn__send_ext_info_valid = value; }
        }
        public bool ShouldSerializesend_ext_info_valid()
        {
            return __pbn__send_ext_info_valid != null;
        }
        public void Resetsend_ext_info_valid()
        {
            __pbn__send_ext_info_valid = null;
        }
        private bool? __pbn__send_ext_info_valid;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool sort_index_valid
        {
            get { return __pbn__sort_index_valid ?? false; }
            set { __pbn__sort_index_valid = value; }
        }
        public bool ShouldSerializesort_index_valid()
        {
            return __pbn__sort_index_valid != null;
        }
        public void Resetsort_index_valid()
        {
            __pbn__sort_index_valid = null;
        }
        private bool? __pbn__sort_index_valid;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool store_in_nvm_valid
        {
            get { return __pbn__store_in_nvm_valid ?? true; }
            set { __pbn__store_in_nvm_valid = value; }
        }
        public bool ShouldSerializestore_in_nvm_valid()
        {
            return __pbn__store_in_nvm_valid != null;
        }
        public void Resetstore_in_nvm_valid()
        {
            __pbn__store_in_nvm_valid = null;
        }
        private bool? __pbn__store_in_nvm_valid;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool ctrl_relay_valid
        {
            get { return __pbn__ctrl_relay_valid ?? false; }
            set { __pbn__ctrl_relay_valid = value; }
        }
        public bool ShouldSerializectrl_relay_valid()
        {
            return __pbn__ctrl_relay_valid != null;
        }
        public void Resetctrl_relay_valid()
        {
            __pbn__ctrl_relay_valid = null;
        }
        private bool? __pbn__ctrl_relay_valid;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool rcs_threshold_valid
        {
            get { return __pbn__rcs_threshold_valid ?? true; }
            set { __pbn__rcs_threshold_valid = value; }
        }
        public bool ShouldSerializercs_threshold_valid()
        {
            return __pbn__rcs_threshold_valid != null;
        }
        public void Resetrcs_threshold_valid()
        {
            __pbn__rcs_threshold_valid = null;
        }
        private bool? __pbn__rcs_threshold_valid;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(248)]
        public uint max_distance
        {
            get { return __pbn__max_distance ?? 248; }
            set { __pbn__max_distance = value; }
        }
        public bool ShouldSerializemax_distance()
        {
            return __pbn__max_distance != null;
        }
        public void Resetmax_distance()
        {
            __pbn__max_distance = null;
        }
        private uint? __pbn__max_distance;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint sensor_id
        {
            get { return __pbn__sensor_id ?? 0; }
            set { __pbn__sensor_id = value; }
        }
        public bool ShouldSerializesensor_id()
        {
            return __pbn__sensor_id != null;
        }
        public void Resetsensor_id()
        {
            __pbn__sensor_id = null;
        }
        private uint? __pbn__sensor_id;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(OutputType.OUTPUT_TYPE_OBJECTS)]
        public OutputType output_type
        {
            get { return __pbn__output_type ?? OutputType.OUTPUT_TYPE_OBJECTS; }
            set { __pbn__output_type = value; }
        }
        public bool ShouldSerializeoutput_type()
        {
            return __pbn__output_type != null;
        }
        public void Resetoutput_type()
        {
            __pbn__output_type = null;
        }
        private OutputType? __pbn__output_type;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint radar_power
        {
            get { return __pbn__radar_power ?? 0; }
            set { __pbn__radar_power = value; }
        }
        public bool ShouldSerializeradar_power()
        {
            return __pbn__radar_power != null;
        }
        public void Resetradar_power()
        {
            __pbn__radar_power = null;
        }
        private uint? __pbn__radar_power;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint ctrl_relay
        {
            get { return __pbn__ctrl_relay ?? 0; }
            set { __pbn__ctrl_relay = value; }
        }
        public bool ShouldSerializectrl_relay()
        {
            return __pbn__ctrl_relay != null;
        }
        public void Resetctrl_relay()
        {
            __pbn__ctrl_relay = null;
        }
        private uint? __pbn__ctrl_relay;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool send_ext_info
        {
            get { return __pbn__send_ext_info ?? true; }
            set { __pbn__send_ext_info = value; }
        }
        public bool ShouldSerializesend_ext_info()
        {
            return __pbn__send_ext_info != null;
        }
        public void Resetsend_ext_info()
        {
            __pbn__send_ext_info = null;
        }
        private bool? __pbn__send_ext_info;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool send_quality
        {
            get { return __pbn__send_quality ?? true; }
            set { __pbn__send_quality = value; }
        }
        public bool ShouldSerializesend_quality()
        {
            return __pbn__send_quality != null;
        }
        public void Resetsend_quality()
        {
            __pbn__send_quality = null;
        }
        private bool? __pbn__send_quality;

        [global::ProtoBuf.ProtoMember(18)]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint sort_index
        {
            get { return __pbn__sort_index ?? 0; }
            set { __pbn__sort_index = value; }
        }
        public bool ShouldSerializesort_index()
        {
            return __pbn__sort_index != null;
        }
        public void Resetsort_index()
        {
            __pbn__sort_index = null;
        }
        private uint? __pbn__sort_index;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue(1)]
        public uint store_in_nvm
        {
            get { return __pbn__store_in_nvm ?? 1; }
            set { __pbn__store_in_nvm = value; }
        }
        public bool ShouldSerializestore_in_nvm()
        {
            return __pbn__store_in_nvm != null;
        }
        public void Resetstore_in_nvm()
        {
            __pbn__store_in_nvm = null;
        }
        private uint? __pbn__store_in_nvm;

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue(RcsThreshold.RCS_THRESHOLD_STANDARD)]
        public RcsThreshold rcs_threshold
        {
            get { return __pbn__rcs_threshold ?? RcsThreshold.RCS_THRESHOLD_STANDARD; }
            set { __pbn__rcs_threshold = value; }
        }
        public bool ShouldSerializercs_threshold()
        {
            return __pbn__rcs_threshold != null;
        }
        public void Resetrcs_threshold()
        {
            __pbn__rcs_threshold = null;
        }
        private RcsThreshold? __pbn__rcs_threshold;

        [global::ProtoBuf.ProtoMember(21)]
        public ulong input_send_interval
        {
            get { return __pbn__input_send_interval.GetValueOrDefault(); }
            set { __pbn__input_send_interval = value; }
        }
        public bool ShouldSerializeinput_send_interval()
        {
            return __pbn__input_send_interval != null;
        }
        public void Resetinput_send_interval()
        {
            __pbn__input_send_interval = null;
        }
        private ulong? __pbn__input_send_interval;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ContiRadarConf : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ContiRadarConf()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public CanConf can_conf { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public RadarConf radar_conf { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string radar_channel
        {
            get { return __pbn__radar_channel ?? ""; }
            set { __pbn__radar_channel = value; }
        }
        public bool ShouldSerializeradar_channel()
        {
            return __pbn__radar_channel != null;
        }
        public void Resetradar_channel()
        {
            __pbn__radar_channel = null;
        }
        private string __pbn__radar_channel;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum OutputType
    {
        OUTPUT_TYPE_NONE = 0,
        OUTPUT_TYPE_OBJECTS = 1,
        OUTPUT_TYPE_CLUSTERS = 2,
        OUTPUT_TYPE_ERROR = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum RcsThreshold
    {
        RCS_THRESHOLD_STANDARD = 0,
        RCS_THRESHOLD_HIGH_SENSITIVITY = 1,
        RCS_THRESHOLD_ERROR = 2,
    }

}

#pragma warning restore 0612, 1591, 3021
