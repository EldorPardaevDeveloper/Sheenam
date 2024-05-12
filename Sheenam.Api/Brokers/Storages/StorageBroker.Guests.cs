//===================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use Comfort an Peace 
//===================================

using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; }
    }
}
