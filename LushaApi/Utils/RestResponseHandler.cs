using System;
using RestSharp;

namespace LushaApi.Utils;

internal static class RestResponseHandler {
    public static T Handle<T>(RestResponse<T> response) {
        if (response.ResponseStatus == ResponseStatus.Error && response.ErrorException != null && response.ErrorException is System.Text.Json.JsonException)
            throw new ApplicationException(response.Content, response.ErrorException).WithContent(response.Content);
        if (response.ErrorException != null)
            throw response.ErrorException.WithContent(response.Content);
        if (response.Data == null)
            throw new ApplicationException("Empty Data!").WithContent(response.Content);
        return response.Data;
    }
}
