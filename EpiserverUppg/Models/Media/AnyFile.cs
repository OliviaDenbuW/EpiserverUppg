using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverUppg.Models.Media
{
    [ContentType(DisplayName = "Any file",
                 GUID = "64e151b1-451c-42d4-8198-e499f733be2b",
                 Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
        
    }
}