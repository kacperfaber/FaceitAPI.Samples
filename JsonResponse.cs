using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Types;

namespace FaceitAPI.Samples.Samples
{
    public class JsonResponse
    {
        //
        // this way, we create IResponse interface implementation.
        // put this to GetObject<>(IResponse) method, or after you GetObject<>() set value Response.
        //
        public void FirstMethod()
        {
            Faceit faceit = new Faceit(new Authorization("YOUR API KEY"));
            faceit.GetObject<Search>(new ResponseImplementation());
        }

        //
        // here we use FaceitAPI.Types.Response type.
        // he implementing IResponse, and in constructor put parameter Action<string, HttpResponseMessage>
        // Action is invoked like IResponse.ReadResponse method. 
        //
        public void SecondMethod()
        {
            Faceit faceit = new Faceit(new Authorization("YOUR API KEY"));
            faceit.GetObject<Search>(new Response((json, responsemsg) => Console.WriteLine("json response is " + json)));
        }
    }

    class ResponseImplementation : IResponse
    {
        void IResponse.ReadResponse(string response, HttpResponseMessage message)
        {
            Console.WriteLine("json response is:: " + response);
            Console.WriteLine("Status code is:: " + message.StatusCode);
            Console.WriteLine("ContentType is:: " + message.Headers.GetValues("ContentType"));
        }
    }
}
