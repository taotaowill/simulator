// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: navigation.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.relative_map
{

    [global::ProtoBuf.ProtoContract()]
    public partial class NavigationPath : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NavigationPath()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Path path { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public uint path_priority
        {
            get { return __pbn__path_priority.GetValueOrDefault(); }
            set { __pbn__path_priority = value; }
        }
        public bool ShouldSerializepath_priority()
        {
            return __pbn__path_priority != null;
        }
        public void Resetpath_priority()
        {
            __pbn__path_priority = null;
        }
        private uint? __pbn__path_priority;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NavigationInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NavigationInfo()
        {
            navigation_path = new global::System.Collections.Generic.List<NavigationPath>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<NavigationPath> navigation_path { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MapMsg : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MapMsg()
        {
            navigation_path = new global::System.Collections.Generic.Dictionary<string, NavigationPath>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::apollo.hdmap.Map hdmap { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, NavigationPath> navigation_path { get; private set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::apollo.perception.LaneMarkers lane_marker { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::apollo.localization.LocalizationEstimate localization { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
