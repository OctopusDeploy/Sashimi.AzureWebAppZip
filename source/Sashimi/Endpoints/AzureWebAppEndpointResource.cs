﻿using Octopus.Server.MessageContracts.Attributes;
using Sashimi.Server.Contracts.Endpoints;

namespace Sashimi.AzureAppService.Endpoints
{
    public class AzureWebAppEndpointResource : EndpointResource
    {
        public override CommunicationStyle CommunicationStyle => CommunicationStyle.AzureWebApp;

        [Trim]
        [Writeable]
        public string AccountId { get; set; } = string.Empty;

        [Trim]
        [Writeable]
        public string ResourceGroupName { get; set; } = string.Empty;

        [Trim]
        [Writeable]
        public string WebAppName { get; set; } = string.Empty;

        [Trim]
        [Writeable]
        public string? WebAppSlotName { get; set; }

        [Trim]
        [Writeable]
        public string? DefaultWorkerPoolId { get; set; }
    }
}