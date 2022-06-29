﻿namespace OsuPlayer.Data.API.RequestModels.Party;

public class UpdatePartyModel
{
    public Guid? UserId { get; set; }
    public Guid? PartyId { get; set; }
    
    public double PlaybackSpeed { get; set; }
    public bool IsPaused { get; set; }
    public bool IsPrivate { get; set; }
}