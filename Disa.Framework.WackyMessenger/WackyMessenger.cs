using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Disa.Framework.Bubbles;

namespace Disa.Framework.WackyMessenger
{
    [ServiceInfo("WackyMessenger", true, false, false, false, false, typeof(WackyMessengerSettings),
        ServiceInfo.ProcedureType.ConnectAuthenticate, typeof(TextBubble))]
    public class WackyMessenger : Service
    {
        public override bool Initialize(DisaSettings settings)
        {
            throw new NotImplementedException();
        }

        public override bool InitializeDefault()
        {
            throw new NotImplementedException();
        }

        public override bool Authenticate(WakeLock wakeLock)
        {
            throw new NotImplementedException();
        }

        public override void Deauthenticate()
        {
            throw new NotImplementedException();
        }

        public override void Connect(WakeLock wakeLock)
        {
            throw new NotImplementedException();
        }

        public override void Disconnect()
        {
            throw new NotImplementedException();
        }

        public override string GetIcon(bool large)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Bubble> ProcessBubbles()
        {
            throw new NotImplementedException();
        }

        public override void SendBubble(Bubble b)
        {
            throw new NotImplementedException();
        }

        public override bool BubbleGroupComparer(string first, string second)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupLegibleId(BubbleGroup group, Action<string> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupName(BubbleGroup group, Action<string> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupPhoto(BubbleGroup group, Action<DisaThumbnail> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupPartyParticipants(BubbleGroup group, Action<DisaParticipant[]> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupUnknownPartyParticipant(BubbleGroup group, string unknownPartyParticipant, Action<DisaParticipant> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupPartyParticipantPhoto(DisaParticipant participant, Action<DisaThumbnail> result)
        {
            throw new NotImplementedException();
        }

        public override Task GetBubbleGroupLastOnline(BubbleGroup group, Action<long> result)
        {
            throw new NotImplementedException();
        }
    }

    public class WackyMessengerSettings : DisaSettings
    {
        // store settings in here:
        // e.g: public string Username { get; set; }
    }
}