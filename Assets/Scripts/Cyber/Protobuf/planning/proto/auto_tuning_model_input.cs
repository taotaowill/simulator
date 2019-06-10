// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: auto_tuning_model_input.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning.autotuning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PathPointwiseFeature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PathPointwiseFeature()
        {
            obstacle_info = new global::System.Collections.Generic.List<ObstacleFeature>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double l
        {
            get { return __pbn__l.GetValueOrDefault(); }
            set { __pbn__l = value; }
        }
        public bool ShouldSerializel()
        {
            return __pbn__l != null;
        }
        public void Resetl()
        {
            __pbn__l = null;
        }
        private double? __pbn__l;

        [global::ProtoBuf.ProtoMember(2)]
        public double dl
        {
            get { return __pbn__dl.GetValueOrDefault(); }
            set { __pbn__dl = value; }
        }
        public bool ShouldSerializedl()
        {
            return __pbn__dl != null;
        }
        public void Resetdl()
        {
            __pbn__dl = null;
        }
        private double? __pbn__dl;

        [global::ProtoBuf.ProtoMember(3)]
        public double ddl
        {
            get { return __pbn__ddl.GetValueOrDefault(); }
            set { __pbn__ddl = value; }
        }
        public bool ShouldSerializeddl()
        {
            return __pbn__ddl != null;
        }
        public void Resetddl()
        {
            __pbn__ddl = null;
        }
        private double? __pbn__ddl;

        [global::ProtoBuf.ProtoMember(4)]
        public double kappa
        {
            get { return __pbn__kappa.GetValueOrDefault(); }
            set { __pbn__kappa = value; }
        }
        public bool ShouldSerializekappa()
        {
            return __pbn__kappa != null;
        }
        public void Resetkappa()
        {
            __pbn__kappa = null;
        }
        private double? __pbn__kappa;

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<ObstacleFeature> obstacle_info { get; private set; }

        [global::ProtoBuf.ProtoMember(6)]
        public BoundRelatedFeature left_bound_feature { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public BoundRelatedFeature right_bound_feature { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class ObstacleFeature : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public ObstacleFeature()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public double lateral_distance
            {
                get { return __pbn__lateral_distance.GetValueOrDefault(); }
                set { __pbn__lateral_distance = value; }
            }
            public bool ShouldSerializelateral_distance()
            {
                return __pbn__lateral_distance != null;
            }
            public void Resetlateral_distance()
            {
                __pbn__lateral_distance = null;
            }
            private double? __pbn__lateral_distance;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class BoundRelatedFeature : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public BoundRelatedFeature()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public double bound_distance
            {
                get { return __pbn__bound_distance.GetValueOrDefault(); }
                set { __pbn__bound_distance = value; }
            }
            public bool ShouldSerializebound_distance()
            {
                return __pbn__bound_distance != null;
            }
            public void Resetbound_distance()
            {
                __pbn__bound_distance = null;
            }
            private double? __pbn__bound_distance;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue(CrossableLevel.CROSS_FREE)]
            public CrossableLevel crossable_level
            {
                get { return __pbn__crossable_level ?? CrossableLevel.CROSS_FREE; }
                set { __pbn__crossable_level = value; }
            }
            public bool ShouldSerializecrossable_level()
            {
                return __pbn__crossable_level != null;
            }
            public void Resetcrossable_level()
            {
                __pbn__crossable_level = null;
            }
            private CrossableLevel? __pbn__crossable_level;

            [global::ProtoBuf.ProtoContract()]
            public enum CrossableLevel
            {
                CROSS_FREE = 0,
                CROSS_ABLE = 1,
                CROSS_FORBIDDEN = 2,
            }

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SpeedPointwiseFeature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SpeedPointwiseFeature()
        {
            follow_obs_feature = new global::System.Collections.Generic.List<ObstacleFeature>();
            overtake_obs_feature = new global::System.Collections.Generic.List<ObstacleFeature>();
            nudge_obs_feature = new global::System.Collections.Generic.List<ObstacleFeature>();
            stop_obs_feature = new global::System.Collections.Generic.List<ObstacleFeature>();
            virtual_obs_feature = new global::System.Collections.Generic.List<ObstacleFeature>();
            sidepass_front_obs_feature = new global::System.Collections.Generic.List<ObstacleFeature>();
            sidepass_rear_obs_feature = new global::System.Collections.Generic.List<ObstacleFeature>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double s
        {
            get { return __pbn__s ?? 0; }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double t
        {
            get { return __pbn__t ?? 0; }
            set { __pbn__t = value; }
        }
        public bool ShouldSerializet()
        {
            return __pbn__t != null;
        }
        public void Resett()
        {
            __pbn__t = null;
        }
        private double? __pbn__t;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double v
        {
            get { return __pbn__v ?? 0; }
            set { __pbn__v = value; }
        }
        public bool ShouldSerializev()
        {
            return __pbn__v != null;
        }
        public void Resetv()
        {
            __pbn__v = null;
        }
        private double? __pbn__v;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double speed_limit
        {
            get { return __pbn__speed_limit ?? 0; }
            set { __pbn__speed_limit = value; }
        }
        public bool ShouldSerializespeed_limit()
        {
            return __pbn__speed_limit != null;
        }
        public void Resetspeed_limit()
        {
            __pbn__speed_limit = null;
        }
        private double? __pbn__speed_limit;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double acc
        {
            get { return __pbn__acc ?? 0; }
            set { __pbn__acc = value; }
        }
        public bool ShouldSerializeacc()
        {
            return __pbn__acc != null;
        }
        public void Resetacc()
        {
            __pbn__acc = null;
        }
        private double? __pbn__acc;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double jerk
        {
            get { return __pbn__jerk ?? 0; }
            set { __pbn__jerk = value; }
        }
        public bool ShouldSerializejerk()
        {
            return __pbn__jerk != null;
        }
        public void Resetjerk()
        {
            __pbn__jerk = null;
        }
        private double? __pbn__jerk;

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<ObstacleFeature> follow_obs_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<ObstacleFeature> overtake_obs_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(9)]
        public global::System.Collections.Generic.List<ObstacleFeature> nudge_obs_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(10)]
        public global::System.Collections.Generic.List<ObstacleFeature> stop_obs_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int collision_times
        {
            get { return __pbn__collision_times ?? 0; }
            set { __pbn__collision_times = value; }
        }
        public bool ShouldSerializecollision_times()
        {
            return __pbn__collision_times != null;
        }
        public void Resetcollision_times()
        {
            __pbn__collision_times = null;
        }
        private int? __pbn__collision_times;

        [global::ProtoBuf.ProtoMember(12)]
        public global::System.Collections.Generic.List<ObstacleFeature> virtual_obs_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double lateral_acc
        {
            get { return __pbn__lateral_acc ?? 0; }
            set { __pbn__lateral_acc = value; }
        }
        public bool ShouldSerializelateral_acc()
        {
            return __pbn__lateral_acc != null;
        }
        public void Resetlateral_acc()
        {
            __pbn__lateral_acc = null;
        }
        private double? __pbn__lateral_acc;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double path_curvature_abs
        {
            get { return __pbn__path_curvature_abs ?? 0; }
            set { __pbn__path_curvature_abs = value; }
        }
        public bool ShouldSerializepath_curvature_abs()
        {
            return __pbn__path_curvature_abs != null;
        }
        public void Resetpath_curvature_abs()
        {
            __pbn__path_curvature_abs = null;
        }
        private double? __pbn__path_curvature_abs;

        [global::ProtoBuf.ProtoMember(15)]
        public global::System.Collections.Generic.List<ObstacleFeature> sidepass_front_obs_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(16)]
        public global::System.Collections.Generic.List<ObstacleFeature> sidepass_rear_obs_feature { get; private set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class ObstacleFeature : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public ObstacleFeature()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public double longitudinal_distance
            {
                get { return __pbn__longitudinal_distance.GetValueOrDefault(); }
                set { __pbn__longitudinal_distance = value; }
            }
            public bool ShouldSerializelongitudinal_distance()
            {
                return __pbn__longitudinal_distance != null;
            }
            public void Resetlongitudinal_distance()
            {
                __pbn__longitudinal_distance = null;
            }
            private double? __pbn__longitudinal_distance;

            [global::ProtoBuf.ProtoMember(2)]
            public double obstacle_speed
            {
                get { return __pbn__obstacle_speed.GetValueOrDefault(); }
                set { __pbn__obstacle_speed = value; }
            }
            public bool ShouldSerializeobstacle_speed()
            {
                return __pbn__obstacle_speed != null;
            }
            public void Resetobstacle_speed()
            {
                __pbn__obstacle_speed = null;
            }
            private double? __pbn__obstacle_speed;

            [global::ProtoBuf.ProtoMember(3)]
            [global::System.ComponentModel.DefaultValue(10)]
            public double lateral_distance
            {
                get { return __pbn__lateral_distance ?? 10; }
                set { __pbn__lateral_distance = value; }
            }
            public bool ShouldSerializelateral_distance()
            {
                return __pbn__lateral_distance != null;
            }
            public void Resetlateral_distance()
            {
                __pbn__lateral_distance = null;
            }
            private double? __pbn__lateral_distance;

            [global::ProtoBuf.ProtoMember(4)]
            public double probability
            {
                get { return __pbn__probability.GetValueOrDefault(); }
                set { __pbn__probability = value; }
            }
            public bool ShouldSerializeprobability()
            {
                return __pbn__probability != null;
            }
            public void Resetprobability()
            {
                __pbn__probability = null;
            }
            private double? __pbn__probability;

            [global::ProtoBuf.ProtoMember(5)]
            public double relative_v
            {
                get { return __pbn__relative_v.GetValueOrDefault(); }
                set { __pbn__relative_v = value; }
            }
            public bool ShouldSerializerelative_v()
            {
                return __pbn__relative_v != null;
            }
            public void Resetrelative_v()
            {
                __pbn__relative_v = null;
            }
            private double? __pbn__relative_v;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TrajectoryPointwiseFeature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TrajectoryPointwiseFeature()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PathPointwiseFeature path_input_feature { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public SpeedPointwiseFeature speed_input_feature { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TrajectoryFeature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TrajectoryFeature()
        {
            point_feature = new global::System.Collections.Generic.List<TrajectoryPointwiseFeature>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<TrajectoryPointwiseFeature> point_feature { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021
