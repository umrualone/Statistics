﻿namespace Statistics.Application.Dtos.Responces
{
    public class ErrorResponse
    {
        public string Message { get; set; }

        public int StatusCode { get; set; }
    
        public ErrorResponse(string message, int statusCode)
        {
            Message = message;
            StatusCode = statusCode;
        }    
    }
}
