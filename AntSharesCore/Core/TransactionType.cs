﻿namespace AntShares.Core
{
    public enum TransactionType : byte
    {
        GenerationTransaction = 0x00,
        IssueTransaction = 0x01,
        RegisterTransaction = 0x40,
        ContractTransaction = 0x80,
        AgencyTransaction = 0xb0
    }
}
