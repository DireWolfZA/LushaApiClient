using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "AuditLogsResponse")]
public class AuditLogsResponse {
    [JsonPropertyName("data")]
    public required List<AuditLogEntry> Data { get; set; }
    [JsonPropertyName("pagination")]
    public required PaginationResponseV2 Pagination { get; set; }
}
