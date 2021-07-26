namespace MediaTypesLite.MediaType
{
    public static class Message
    {
        //<summary>
        // MediaType: CPIM
        // Reference: [RFC3862]
        //</summary>
        public const string Cpim = "message/CPIM";

        //<summary>
        // MediaType: delivery-status
        // Reference: [RFC1894]
        //</summary>
        public const string DeliveryStatus = "message/delivery-status";

        //<summary>
        // MediaType: disposition-notification
        // Reference: [RFC8098]
        //</summary>
        public const string DispositionNotification = "message/disposition-notification";

        //<summary>
        // MediaType: example
        // Reference: [RFC4735]
        //</summary>
        public const string Example = "message/example";

        //<summary>
        // MediaType: external-body
        // Reference: [RFC2045][RFC2046]
        //</summary>
        public const string ExternalBody = "";

        //<summary>
        // MediaType: feedback-report
        // Reference: [RFC5965]
        //</summary>
        public const string FeedbackReport = "message/feedback-report";

        //<summary>
        // MediaType: global
        // Reference: [RFC6532]
        //</summary>
        public const string Global = "message/global";

        //<summary>
        // MediaType: global-delivery-status
        // Reference: [RFC6533]
        //</summary>
        public const string GlobalDeliveryStatus = "message/global-delivery-status";

        //<summary>
        // MediaType: global-disposition-notification
        // Reference: [RFC6533]
        //</summary>
        public const string GlobalDispositionNotification = "message/global-disposition-notification";

        //<summary>
        // MediaType: global-headers
        // Reference: [RFC6533]
        //</summary>
        public const string GlobalHeaders = "message/global-headers";

        //<summary>
        // MediaType: http
        // Reference: [RFC7230]
        //</summary>
        public const string Http = "message/http";

        //<summary>
        // MediaType: imdn+xml
        // Reference: [RFC5438]
        //</summary>
        public const string ImdnXml = "message/imdn+xml";

        //<summary>
        // MediaType: news - OBSOLETED by RFC5537
        // Reference: [RFC5537][Henry_Spencer]
        //</summary>
        [System.Obsolete]
        public const string News = "message/news";

        //<summary>
        // MediaType: partial
        // Reference: [RFC2045][RFC2046]
        //</summary>
        public const string Partial = "";

        //<summary>
        // MediaType: rfc822
        // Reference: [RFC2045][RFC2046]
        //</summary>
        public const string Rfc822 = "";

        //<summary>
        // MediaType: s-http
        // Reference: [RFC2660]
        //</summary>
        public const string SHttp = "message/s-http";

        //<summary>
        // MediaType: sip
        // Reference: [RFC3261]
        //</summary>
        public const string Sip = "message/sip";

        //<summary>
        // MediaType: sipfrag
        // Reference: [RFC3420]
        //</summary>
        public const string Sipfrag = "message/sipfrag";

        //<summary>
        // MediaType: tracking-status
        // Reference: [RFC3886]
        //</summary>
        public const string TrackingStatus = "message/tracking-status";

        //<summary>
        // MediaType: vnd.si.simp - OBSOLETED by request
        // Reference: [Nicholas_Parks_Young]
        //</summary>
        [System.Obsolete]
        public const string VndSiSimp = "message/vnd.si.simp";

        //<summary>
        // MediaType: vnd.wfa.wsc
        // Reference: [Mick_Conley]
        //</summary>
        public const string VndWfaWsc = "message/vnd.wfa.wsc";

    }
}