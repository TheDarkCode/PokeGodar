﻿#pragma warning disable 1591, 0612, 3021

#region Designer generated code

#region

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;

#endregion

namespace PokeGodar.WebAPI.GeneratedCode
{
    /// <summary>Holder for reflection information generated from Payloads.proto</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class PayloadsReflection
    {
        #region Descriptor

        /// <summary>File descriptor for Payloads.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static pbr::FileDescriptor descriptor;

        static PayloadsReflection()
        {
            var descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                    "Cg5QYXlsb2Fkcy5wcm90bxIhUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0",
                    "ZWRDb2RlGg1BbGxFbnVtLnByb3RvImIKEUdldFBsYXllclJlc3BvbnNlEhAK",
                    "CHVua25vd24xGAEgASgFEjsKB3Byb2ZpbGUYAiABKAsyKi5Qb2tlbW9uR28u",
                    "Um9ja2V0QVBJLkdlbmVyYXRlZENvZGUuUHJvZmlsZSL9AgoHUHJvZmlsZRIV",
                    "Cg1jcmVhdGlvbl90aW1lGAEgASgDEhAKCHVzZXJuYW1lGAIgASgJEiAKBHRl",
                    "YW0YBSABKA4yEi5BbGxFbnVtLlRlYW1Db2xvchIQCgh0dXRvcmlhbBgHIAEo",
                    "DBJACgZhdmF0YXIYCCABKAsyMC5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVy",
                    "YXRlZENvZGUuQXZhdGFyRGV0YWlscxIUCgxwb2tlX3N0b3JhZ2UYCSABKAUS",
                    "FAoMaXRlbV9zdG9yYWdlGAogASgFEkIKC2RhaWx5X2JvbnVzGAsgASgLMi0u",
                    "UG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkRhaWx5Qm9udXMS",
                    "EQoJdW5rbm93bjEyGAwgASgMEhEKCXVua25vd24xMxgNIAEoDBI9CghjdXJy",
                    "ZW5jeRgOIAMoCzIrLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29k",
                    "ZS5DdXJyZW5jeSJZCgpEYWlseUJvbnVzEh4KFk5leHRDb2xsZWN0VGltZXN0",
                    "YW1wTXMYASABKAMSKwojTmV4dERlZmVuZGVyQm9udXNDb2xsZWN0VGltZXN0",
                    "YW1wTXMYAiABKAMiKAoIQ3VycmVuY3kSDAoEdHlwZRgBIAEoCRIOCgZhbW91",
                    "bnQYAiABKAUiWAoNQXZhdGFyRGV0YWlscxIQCgh1bmtub3duMhgCIAEoBRIQ",
                    "Cgh1bmtub3duMxgDIAEoBRIQCgh1bmtub3duORgJIAEoBRIRCgl1bmtub3du",
                    "MTAYCiABKAUiJwoXRG93bmxvYWRTZXR0aW5nc1JlcXVlc3QSDAoEaGFzaBgB",
                    "IAEoCSJzChRHZXRJbnZlbnRvcnlSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgI",
                    "EkoKD2ludmVudG9yeV9kZWx0YRgCIAEoCzIxLlBva2Vtb25Hby5Sb2NrZXRB",
                    "UEkuR2VuZXJhdGVkQ29kZS5JbnZlbnRvcnlEZWx0YSKUAQoOSW52ZW50b3J5",
                    "RGVsdGESHQoVb3JpZ2luYWxfdGltZXN0YW1wX21zGAEgASgDEhgKEG5ld190",
                    "aW1lc3RhbXBfbXMYAiABKAMSSQoPaW52ZW50b3J5X2l0ZW1zGAMgAygLMjAu",
                    "UG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkludmVudG9yeUl0",
                    "ZW0imwEKDUludmVudG9yeUl0ZW0SHQoVbW9kaWZpZWRfdGltZXN0YW1wX21z",
                    "GAEgASgDEhgKEGRlbGV0ZWRfaXRlbV9rZXkYAiABKAMSUQoTaW52ZW50b3J5",
                    "X2l0ZW1fZGF0YRgDIAEoCzI0LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJh",
                    "dGVkQ29kZS5JbnZlbnRvcnlJdGVtRGF0YSLbBQoRSW52ZW50b3J5SXRlbURh",
                    "dGESPwoHcG9rZW1vbhgBIAEoCzIuLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2Vu",
                    "ZXJhdGVkQ29kZS5Qb2tlbW9uRGF0YRI1CgRpdGVtGAIgASgLMicuUG9rZW1v",
                    "bkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkl0ZW0SRgoNcG9rZWRleF9l",
                    "bnRyeRgDIAEoCzIvLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29k",
                    "ZS5Qb2tlZGV4RW50cnkSRAoMcGxheWVyX3N0YXRzGAQgASgLMi4uUG9rZW1v",
                    "bkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLlBsYXllclN0YXRzEkoKD3Bs",
                    "YXllcl9jdXJyZW5jeRgFIAEoCzIxLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2Vu",
                    "ZXJhdGVkQ29kZS5QbGF5ZXJDdXJyZW5jeRJGCg1wbGF5ZXJfY2FtZXJhGAYg",
                    "ASgLMi8uUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLlBsYXll",
                    "ckNhbWVyYRJQChJpbnZlbnRvcnlfdXBncmFkZXMYByABKAsyNC5Qb2tlbW9u",
                    "R28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuSW52ZW50b3J5VXBncmFkZXMS",
                    "RgoNYXBwbGllZF9pdGVtcxgIIAEoCzIvLlBva2Vtb25Hby5Sb2NrZXRBUEku",
                    "R2VuZXJhdGVkQ29kZS5BcHBsaWVkSXRlbXMSSAoOZWdnX2luY3ViYXRvcnMY",
                    "CSABKAsyMC5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuRWdn",
                    "SW5jdWJhdG9ycxJICg5wb2tlbW9uX2ZhbWlseRgKIAEoCzIwLlBva2Vtb25H",
                    "by5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5Qb2tlbW9uRmFtaWx5ItgFCgdQ",
                    "b2tlbW9uEgoKAmlkGAEgASgFEigKDHBva2Vtb25fdHlwZRgCIAEoDjISLkFs",
                    "bEVudW0uUG9rZW1vbklkEgoKAmNwGAMgASgFEg8KB3N0YW1pbmEYBCABKAUS",
                    "EwoLc3RhbWluYV9tYXgYBSABKAUSJAoGbW92ZV8xGAYgASgOMhQuQWxsRW51",
                    "bS5Qb2tlbW9uTW92ZRIkCgZtb3ZlXzIYByABKA4yFC5BbGxFbnVtLlBva2Vt",
                    "b25Nb3ZlEhgKEGRlcGxveWVkX2ZvcnRfaWQYCCABKAUSEgoKb3duZXJfbmFt",
                    "ZRgJIAEoCRIOCgZpc19lZ2cYCiABKAgSHAoUZWdnX2ttX3dhbGtlZF90YXJn",
                    "ZXQYCyABKAUSGwoTZWdnX2ttX3dhbGtlZF9zdGFydBgMIAEoBRIOCgZvcmln",
                    "aW4YDiABKAUSEAoIaGVpZ2h0X20YDyABKAISEQoJd2VpZ2h0X2tnGBAgASgC",
                    "EhkKEWluZGl2aWR1YWxfYXR0YWNrGBEgASgFEhoKEmluZGl2aWR1YWxfZGVm",
                    "ZW5zZRgSIAEoBRIaChJpbmRpdmlkdWFsX3N0YW1pbmEYEyABKAUSFQoNY3Bf",
                    "bXVsdGlwbGllchgUIAEoBRIQCghwb2tlYmFsbBgVIAEoBRIYChBjYXB0dXJl",
                    "ZF9jZWxsX2lkGBYgASgEEhgKEGJhdHRsZXNfYXR0YWNrZWQYFyABKAUSGAoQ",
                    "YmF0dGxlc19kZWZlbmRlZBgYIAEoBRIYChBlZ2dfaW5jdWJhdG9yX2lkGBkg",
                    "ASgFEhgKEGNyZWF0aW9uX3RpbWVfbXMYGiABKAQSFAoMbnVtX3VwZ3JhZGVz",
                    "GBsgASgFEiAKGGFkZGl0aW9uYWxfY3BfbXVsdGlwbGllchgcIAEoBRIQCghm",
                    "YXZvcml0ZRgdIAEoBRIQCghuaWNrbmFtZRgeIAEoCRIRCglmcm9tX2ZvcnQY",
                    "HyABKAUiRgoESXRlbRIfCgRpdGVtGAEgASgOMhEuQWxsRW51bS5JdGVtVHlw",
                    "ZRINCgVjb3VudBgCIAEoBRIOCgZ1bnNlZW4YAyABKAgimQEKDFBva2VkZXhF",
                    "bnRyeRIcChRwb2tlZGV4X2VudHJ5X251bWJlchgBIAEoBRIZChF0aW1lc19l",
                    "bmNvdW50ZXJlZBgCIAEoBRIWCg50aW1lc19jYXB0dXJlZBgDIAEoBRIeChZl",
                    "dm9sdXRpb25fc3RvbmVfcGllY2VzGAQgASgFEhgKEGV2b2x1dGlvbl9zdG9u",
                    "ZXMYBSABKAUi7QQKC1BsYXllclN0YXRzEg0KBWxldmVsGAEgASgFEhIKCmV4",
                    "cGVyaWVuY2UYAiABKAMSFQoNcHJldl9sZXZlbF94cBgDIAEoAxIVCg1uZXh0",
                    "X2xldmVsX3hwGAQgASgDEhEKCWttX3dhbGtlZBgFIAEoAhIcChRwb2tlbW9u",
                    "c19lbmNvdW50ZXJlZBgGIAEoBRIeChZ1bmlxdWVfcG9rZWRleF9lbnRyaWVz",
                    "GAcgASgFEhkKEXBva2Vtb25zX2NhcHR1cmVkGAggASgFEhIKCmV2b2x1dGlv",
                    "bnMYCSABKAUSGAoQcG9rZV9zdG9wX3Zpc2l0cxgKIAEoBRIYChBwb2tlYmFs",
                    "bHNfdGhyb3duGAsgASgFEhQKDGVnZ3NfaGF0Y2hlZBgMIAEoBRIbChNiaWdf",
                    "bWFnaWthcnBfY2F1Z2h0GA0gASgFEhkKEWJhdHRsZV9hdHRhY2tfd29uGA4g",
                    "ASgFEhsKE2JhdHRsZV9hdHRhY2tfdG90YWwYDyABKAUSGwoTYmF0dGxlX2Rl",
                    "ZmVuZGVkX3dvbhgQIAEoBRIbChNiYXR0bGVfdHJhaW5pbmdfd29uGBEgASgF",
                    "Eh0KFWJhdHRsZV90cmFpbmluZ190b3RhbBgSIAEoBRIdChVwcmVzdGlnZV9y",
                    "YWlzZWRfdG90YWwYEyABKAUSHgoWcHJlc3RpZ2VfZHJvcHBlZF90b3RhbBgU",
                    "IAEoBRIYChBwb2tlbW9uX2RlcGxveWVkGBUgASgFEh4KFnBva2Vtb25fY2F1",
                    "Z2h0X2J5X3R5cGUYFiABKAwSHAoUc21hbGxfcmF0dGF0YV9jYXVnaHQYFyAB",
                    "KAUiHgoOUGxheWVyQ3VycmVuY3kSDAoEZ2VtcxgBIAEoBSIpCgxQbGF5ZXJD",
                    "YW1lcmESGQoRaXNfZGVmYXVsdF9jYW1lcmEYASABKAgiZAoRSW52ZW50b3J5",
                    "VXBncmFkZXMSTwoSaW52ZW50b3J5X3VwZ3JhZGVzGAEgAygLMjMuUG9rZW1v",
                    "bkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkludmVudG9yeVVwZ3JhZGUi",
                    "hAEKEEludmVudG9yeVVwZ3JhZGUSHwoEaXRlbRgBIAEoDjIRLkFsbEVudW0u",
                    "SXRlbVR5cGUSMwoMdXBncmFkZV90eXBlGAIgASgOMh0uQWxsRW51bS5JbnZl",
                    "bnRvcnlVcGdyYWRlVHlwZRIaChJhZGRpdGlvbmFsX3N0b3JhZ2UYAyABKAUi",
                    "TAoMQXBwbGllZEl0ZW1zEjwKBGl0ZW0YBCABKAsyLi5Qb2tlbW9uR28uUm9j",
                    "a2V0QVBJLkdlbmVyYXRlZENvZGUuQXBwbGllZEl0ZW0ihwEKC0FwcGxpZWRJ",
                    "dGVtEiIKCWl0ZW1fdHlwZRgBIAEoDjIPLkFsbEVudW0uSXRlbUlkEi0KEml0",
                    "ZW1fdHlwZV9jYXRlZ29yeRgCIAEoDjIRLkFsbEVudW0uSXRlbVR5cGUSEQoJ",
                    "ZXhwaXJlX21zGAMgASgDEhIKCmFwcGxpZWRfbXMYBCABKAMiVwoNRWdnSW5j",
                    "dWJhdG9ycxJGCg1lZ2dfaW5jdWJhdG9yGAEgASgLMi8uUG9rZW1vbkdvLlJv",
                    "Y2tldEFQSS5HZW5lcmF0ZWRDb2RlLkVnZ0luY3ViYXRvciLXAQoMRWdnSW5j",
                    "dWJhdG9yEg8KB2l0ZW1faWQYASABKAkSJAoJaXRlbV90eXBlGAIgASgOMhEu",
                    "QWxsRW51bS5JdGVtVHlwZRIxCg5pbmN1YmF0b3JfdHlwZRgDIAEoDjIZLkFs",
                    "bEVudW0uRWdnSW5jdWJhdG9yVHlwZRIWCg51c2VzX3JlbWFpbmluZxgEIAEo",
                    "BRISCgpwb2tlbW9uX2lkGAUgASgDEhcKD3N0YXJ0X2ttX3dhbGtlZBgGIAEo",
                    "ARIYChB0YXJnZXRfa21fd2Fsa2VkGAcgASgBIksKDVBva2Vtb25GYW1pbHkS",
                    "KwoJZmFtaWx5X2lkGAEgASgOMhguQWxsRW51bS5Qb2tlbW9uRmFtaWx5SWQS",
                    "DQoFY2FuZHkYAiABKAUiaAoUR2V0TWFwT2JqZWN0c1JlcXVlc3QSDwoHY2Vs",
                    "bF9pZBgBIAEoDBIaChJzaW5jZV90aW1lc3RhbXBfbXMYAiABKAwSEAoIbGF0",
                    "aXR1ZGUYAyABKAESEQoJbG9uZ2l0dWRlGAQgASgBIoEBChVHZXRNYXBPYmpl",
                    "Y3RzUmVzcG9uc2USPQoJbWFwX2NlbGxzGAEgAygLMiouUG9rZW1vbkdvLlJv",
                    "Y2tldEFQSS5HZW5lcmF0ZWRDb2RlLk1hcENlbGwSKQoGc3RhdHVzGAIgASgO",
                    "MhkuQWxsRW51bS5NYXBPYmplY3RzU3RhdHVzIuQECgdNYXBDZWxsEhIKCnMy",
                    "X2NlbGxfaWQYASABKAQSHAoUY3VycmVudF90aW1lc3RhbXBfbXMYAiABKAMS",
                    "OgoFZm9ydHMYAyADKAsyKy5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRl",
                    "ZENvZGUuRm9ydERhdGESQwoMc3Bhd25fcG9pbnRzGAQgAygLMi0uUG9rZW1v",
                    "bkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLlNwYXduUG9pbnQSFwoPZGVs",
                    "ZXRlZF9vYmplY3RzGAYgAygJEhkKEWlzX3RydW5jYXRlZF9saXN0GAcgASgI",
                    "EkYKDmZvcnRfc3VtbWFyaWVzGAggAygLMi4uUG9rZW1vbkdvLlJvY2tldEFQ",
                    "SS5HZW5lcmF0ZWRDb2RlLkZvcnRTdW1tYXJ5Ek0KFmRlY2ltYXRlZF9zcGF3",
                    "bl9wb2ludHMYCSADKAsyLS5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRl",
                    "ZENvZGUuU3Bhd25Qb2ludBJFCg13aWxkX3Bva2Vtb25zGAUgAygLMi4uUG9r",
                    "ZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLldpbGRQb2tlbW9uEkkK",
                    "EmNhdGNoYWJsZV9wb2tlbW9ucxgKIAMoCzItLlBva2Vtb25Hby5Sb2NrZXRB",
                    "UEkuR2VuZXJhdGVkQ29kZS5NYXBQb2tlbW9uEkkKD25lYXJieV9wb2tlbW9u",
                    "cxgLIAMoCzIwLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5O",
                    "ZWFyYnlQb2tlbW9uIpMECghGb3J0RGF0YRIKCgJpZBgBIAEoCRIiChpsYXN0",
                    "X21vZGlmaWVkX3RpbWVzdGFtcF9tcxgCIAEoAxIQCghsYXRpdHVkZRgDIAEo",
                    "ARIRCglsb25naXR1ZGUYBCABKAESDwoHZW5hYmxlZBgIIAEoCBIfCgR0eXBl",
                    "GAkgASgOMhEuQWxsRW51bS5Gb3J0VHlwZRIpCg1vd25lZF9ieV90ZWFtGAUg",
                    "ASgOMhIuQWxsRW51bS5UZWFtQ29sb3ISLAoQZ3VhcmRfcG9rZW1vbl9pZBgG",
                    "IAEoDjISLkFsbEVudW0uUG9rZW1vbklkEhgKEGd1YXJkX3Bva2Vtb25fY3AY",
                    "ByABKAUSEgoKZ3ltX3BvaW50cxgKIAEoAxIUCgxpc19pbl9iYXR0bGUYCyAB",
                    "KAgSJgoeY29vbGRvd25fY29tcGxldGVfdGltZXN0YW1wX21zGA4gASgDEiUK",
                    "B3Nwb25zb3IYDyABKA4yFC5BbGxFbnVtLkZvcnRTcG9uc29yEjIKDnJlbmRl",
                    "cmluZ190eXBlGBAgASgOMhouQWxsRW51bS5Gb3J0UmVuZGVyaW5nVHlwZRIc",
                    "ChRhY3RpdmVfZm9ydF9tb2RpZmllchgMIAEoDBJCCglsdXJlX2luZm8YDSAB",
                    "KAsyLy5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuRm9ydEx1",
                    "cmVJbmZvIoMBCgxGb3J0THVyZUluZm8SDwoHZm9ydF9pZBgBIAEoCRIQCgh1",
                    "bmtub3duMhgCIAEoARItChFhY3RpdmVfcG9rZW1vbl9pZBgDIAEoDjISLkFs",
                    "bEVudW0uUG9rZW1vbklkEiEKGWx1cmVfZXhwaXJlc190aW1lc3RhbXBfbXMY",
                    "BCABKAMiMQoKU3Bhd25Qb2ludBIQCghsYXRpdHVkZRgCIAEoARIRCglsb25n",
                    "aXR1ZGUYAyABKAEibwoLRm9ydFN1bW1hcnkSFwoPZm9ydF9zdW1tYXJ5X2lk",
                    "GAEgASgFEiIKGmxhc3RfbW9kaWZpZWRfdGltZXN0YW1wX21zGAIgASgFEhAK",
                    "CGxhdGl0dWRlGAMgASgFEhEKCWxvbmdpdHVkZRgEIAEoBSLmAQoLV2lsZFBv",
                    "a2Vtb24SFAoMZW5jb3VudGVyX2lkGAEgASgGEiIKGmxhc3RfbW9kaWZpZWRf",
                    "dGltZXN0YW1wX21zGAIgASgDEhAKCGxhdGl0dWRlGAMgASgBEhEKCWxvbmdp",
                    "dHVkZRgEIAEoARIVCg1zcGF3bnBvaW50X2lkGAUgASgJEkQKDHBva2Vtb25f",
                    "ZGF0YRgHIAEoCzIuLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29k",
                    "ZS5Qb2tlbW9uRGF0YRIbChN0aW1lX3RpbGxfaGlkZGVuX21zGAsgASgFItoF",
                    "CgtQb2tlbW9uRGF0YRIKCgJpZBgBIAEoBhImCgpwb2tlbW9uX2lkGAIgASgO",
                    "MhIuQWxsRW51bS5Qb2tlbW9uSWQSCgoCY3AYAyABKAUSDwoHc3RhbWluYRgE",
                    "IAEoBRITCgtzdGFtaW5hX21heBgFIAEoBRIkCgZtb3ZlXzEYBiABKA4yFC5B",
                    "bGxFbnVtLlBva2Vtb25Nb3ZlEiQKBm1vdmVfMhgHIAEoDjIULkFsbEVudW0u",
                    "UG9rZW1vbk1vdmUSGAoQZGVwbG95ZWRfZm9ydF9pZBgIIAEoBRISCgpvd25l",
                    "cl9uYW1lGAkgASgJEg4KBmlzX2VnZxgKIAEoCBIcChRlZ2dfa21fd2Fsa2Vk",
                    "X3RhcmdldBgLIAEoBRIbChNlZ2dfa21fd2Fsa2VkX3N0YXJ0GAwgASgFEg4K",
                    "Bm9yaWdpbhgOIAEoBRIQCghoZWlnaHRfbRgPIAEoAhIRCgl3ZWlnaHRfa2cY",
                    "ECABKAISGQoRaW5kaXZpZHVhbF9hdHRhY2sYESABKAUSGgoSaW5kaXZpZHVh",
                    "bF9kZWZlbnNlGBIgASgFEhoKEmluZGl2aWR1YWxfc3RhbWluYRgTIAEoBRIV",
                    "Cg1jcF9tdWx0aXBsaWVyGBQgASgFEhAKCHBva2ViYWxsGBUgASgFEhgKEGNh",
                    "cHR1cmVkX2NlbGxfaWQYFiABKAQSGAoQYmF0dGxlc19hdHRhY2tlZBgXIAEo",
                    "BRIYChBiYXR0bGVzX2RlZmVuZGVkGBggASgFEhgKEGVnZ19pbmN1YmF0b3Jf",
                    "aWQYGSABKAUSGAoQY3JlYXRpb25fdGltZV9tcxgaIAEoBBIUCgxudW1fdXBn",
                    "cmFkZXMYGyABKAUSIAoYYWRkaXRpb25hbF9jcF9tdWx0aXBsaWVyGBwgASgF",
                    "EhAKCGZhdm9yaXRlGB0gASgFEhAKCG5pY2tuYW1lGB4gASgJEhEKCWZyb21f",
                    "Zm9ydBgfIAEoBSKnAQoKTWFwUG9rZW1vbhIVCg1zcGF3bnBvaW50X2lkGAEg",
                    "ASgJEhQKDGVuY291bnRlcl9pZBgCIAEoBhImCgpwb2tlbW9uX2lkGAMgASgO",
                    "MhIuQWxsRW51bS5Qb2tlbW9uSWQSHwoXZXhwaXJhdGlvbl90aW1lc3RhbXBf",
                    "bXMYBCABKAMSEAoIbGF0aXR1ZGUYBSABKAESEQoJbG9uZ2l0dWRlGAYgASgB",
                    "ImkKDU5lYXJieVBva2Vtb24SJgoKcG9rZW1vbl9pZBgBIAEoDjISLkFsbEVu",
                    "dW0uUG9rZW1vbklkEhoKEmRpc3RhbmNlX2luX21ldGVycxgCIAEoAhIUCgxl",
                    "bmNvdW50ZXJfaWQYAyABKAYifAoYRG93bmxvYWRTZXR0aW5nc1Jlc3BvbnNl",
                    "Eg0KBWVycm9yGAEgASgJEgwKBGhhc2gYAiABKAkSQwoIc2V0dGluZ3MYAyAB",
                    "KAsyMS5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuR2xvYmFs",
                    "U2V0dGluZ3Mi2gIKDkdsb2JhbFNldHRpbmdzEkYKDWZvcnRfc2V0dGluZ3MY",
                    "AiABKAsyLy5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuRm9y",
                    "dFNldHRpbmdzEkQKDG1hcF9zZXR0aW5ncxgDIAEoCzIuLlBva2Vtb25Hby5S",
                    "b2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5NYXBTZXR0aW5ncxJICg5sZXZlbF9z",
                    "ZXR0aW5ncxgEIAEoCzIwLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVk",
                    "Q29kZS5MZXZlbFNldHRpbmdzElAKEmludmVudG9yeV9zZXR0aW5ncxgFIAEo",
                    "CzI0LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5JbnZlbnRv",
                    "cnlTZXR0aW5ncxIeChZtaW5pbXVtX2NsaWVudF92ZXJzaW9uGAYgASgJIuQB",
                    "CgxGb3J0U2V0dGluZ3MSIAoYaW50ZXJhY3Rpb25fcmFuZ2VfbWV0ZXJzGAEg",
                    "ASgBEiIKGm1heF90b3RhbF9kZXBsb3llZF9wb2tlbW9uGAIgASgFEiMKG21h",
                    "eF9wbGF5ZXJfZGVwbG95ZWRfcG9rZW1vbhgDIAEoBRIhChlkZXBsb3lfc3Rh",
                    "bWluYV9tdWx0aXBsaWVyGAQgASgBEiAKGGRlcGxveV9hdHRhY2tfbXVsdGlw",
                    "bGllchgFIAEoARIkChxmYXJfaW50ZXJhY3Rpb25fcmFuZ2VfbWV0ZXJzGAYg",
                    "ASgBIo8CCgtNYXBTZXR0aW5ncxIdChVwb2tlbW9uX3Zpc2libGVfcmFuZ2UY",
                    "ASABKAESHQoVcG9rZV9uYXZfcmFuZ2VfbWV0ZXJzGAIgASgBEh4KFmVuY291",
                    "bnRlcl9yYW5nZV9tZXRlcnMYAyABKAESKwojZ2V0X21hcF9vYmplY3RzX21p",
                    "bl9yZWZyZXNoX3NlY29uZHMYBCABKAISKwojZ2V0X21hcF9vYmplY3RzX21h",
                    "eF9yZWZyZXNoX3NlY29uZHMYBSABKAISKwojZ2V0X21hcF9vYmplY3RzX21p",
                    "bl9kaXN0YW5jZV9tZXRlcnMYBiABKAISGwoTZ29vZ2xlX21hcHNfYXBpX2tl",
                    "eRgHIAEoCSJRCg1MZXZlbFNldHRpbmdzEhsKE3RyYWluZXJfY3BfbW9kaWZp",
                    "ZXIYAiABKAESIwobdHJhaW5lcl9kaWZmaWN1bHR5X21vZGlmaWVyGAMgASgB",
                    "IoABChFJbnZlbnRvcnlTZXR0aW5ncxITCgttYXhfcG9rZW1vbhgBIAEoBRIV",
                    "Cg1tYXhfYmFnX2l0ZW1zGAIgASgFEhQKDGJhc2VfcG9rZW1vbhgDIAEoBRIW",
                    "Cg5iYXNlX2JhZ19pdGVtcxgEIAEoBRIRCgliYXNlX2VnZ3MYBSABKAUiOgoT",
                    "UGxheWVyVXBkYXRlUmVxdWVzdBIQCghsYXRpdHVkZRgBIAEoARIRCglsb25n",
                    "aXR1ZGUYAiABKAEirwEKFFBsYXllclVwZGF0ZVJlc3BvbnNlEkUKDXdpbGRf",
                    "cG9rZW1vbnMYASADKAsyLi5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRl",
                    "ZENvZGUuV2lsZFBva2Vtb24SOgoFZm9ydHMYAiADKAsyKy5Qb2tlbW9uR28u",
                    "Um9ja2V0QVBJLkdlbmVyYXRlZENvZGUuRm9ydERhdGESFAoMZm9ydHNfbmVh",
                    "cmJ5GAMgASgFIh4KHERvd25sb2FkSXRlbVRlbXBsYXRlc1JlcXVlc3Qi2woK",
                    "HURvd25sb2FkSXRlbVRlbXBsYXRlc1Jlc3BvbnNlEg8KB3N1Y2Nlc3MYASAB",
                    "KAgSZQoOaXRlbV90ZW1wbGF0ZXMYAiADKAsyTS5Qb2tlbW9uR28uUm9ja2V0",
                    "QVBJLkdlbmVyYXRlZENvZGUuRG93bmxvYWRJdGVtVGVtcGxhdGVzUmVzcG9u",
                    "c2UuSXRlbVRlbXBsYXRlEhQKDHRpbWVzdGFtcF9tcxgDIAEoBBqrCQoMSXRl",
                    "bVRlbXBsYXRlEhMKC3RlbXBsYXRlX2lkGAEgASgJEkwKEHBva2Vtb25fc2V0",
                    "dGluZ3MYAiABKAsyMi5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENv",
                    "ZGUuUG9rZW1vblNldHRpbmdzEkYKDWl0ZW1fc2V0dGluZ3MYAyABKAsyLy5Q",
                    "b2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuSXRlbVNldHRpbmdz",
                    "EkYKDW1vdmVfc2V0dGluZ3MYBCABKAsyLy5Qb2tlbW9uR28uUm9ja2V0QVBJ",
                    "LkdlbmVyYXRlZENvZGUuTW92ZVNldHRpbmdzElcKFm1vdmVfc2VxdWVuY2Vf",
                    "c2V0dGluZ3MYBSABKAsyNy5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRl",
                    "ZENvZGUuTW92ZVNlcXVlbmNlU2V0dGluZ3MSUAoOdHlwZV9lZmZlY3RpdmUY",
                    "CCABKAsyOC5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuVHlw",
                    "ZUVmZmVjdGl2ZVNldHRpbmdzEkgKDmJhZGdlX3NldHRpbmdzGAogASgLMjAu",
                    "UG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkJhZGdlU2V0dGlu",
                    "Z3MSQQoGY2FtZXJhGAsgASgLMjEuUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5l",
                    "cmF0ZWRDb2RlLkNhbWVyYVNldHRpbmdzEkwKDHBsYXllcl9sZXZlbBgMIAEo",
                    "CzI2LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5QbGF5ZXJM",
                    "ZXZlbFNldHRpbmdzEkYKCWd5bV9sZXZlbBgNIAEoCzIzLlBva2Vtb25Hby5S",
                    "b2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5HeW1MZXZlbFNldHRpbmdzEk0KD2Jh",
                    "dHRsZV9zZXR0aW5ncxgOIAEoCzI0LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2Vu",
                    "ZXJhdGVkQ29kZS5HeW1CYXR0bGVTZXR0aW5ncxJQChJlbmNvdW50ZXJfc2V0",
                    "dGluZ3MYDyABKAsyNC5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENv",
                    "ZGUuRW5jb3VudGVyU2V0dGluZ3MSSwoQaWFwX2l0ZW1fZGlzcGxheRgQIAEo",
                    "CzIxLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5JYXBJdGVt",
                    "RGlzcGxheRJECgxpYXBfc2V0dGluZ3MYESABKAsyLi5Qb2tlbW9uR28uUm9j",
                    "a2V0QVBJLkdlbmVyYXRlZENvZGUuSWFwU2V0dGluZ3MSUwoQcG9rZW1vbl91",
                    "cGdyYWRlcxgSIAEoCzI5LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVk",
                    "Q29kZS5Qb2tlbW9uVXBncmFkZVNldHRpbmdzElEKD2VxdWlwcGVkX2JhZGdl",
                    "cxgTIAEoCzI4LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5F",
                    "cXVpcHBlZEJhZGdlU2V0dGluZ3MiaQoVVXNlSXRlbUNhcHR1cmVSZXF1ZXN0",
                    "EiAKB2l0ZW1faWQYASABKA4yDy5BbGxFbnVtLkl0ZW1JZBIUCgxlbmNvdW50",
                    "ZXJfaWQYAiABKAYSGAoQc3Bhd25fcG9pbnRfZ3VpZBgDIAEoCSKxAQoWVXNl",
                    "SXRlbUNhcHR1cmVSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgIEhkKEWl0ZW1f",
                    "Y2FwdHVyZV9tdWx0GAIgASgBEhYKDml0ZW1fZmxlZV9tdWx0GAMgASgBEhUK",
                    "DXN0b3BfbW92ZW1lbnQYBCABKAgSEwoLc3RvcF9hdHRhY2sYBSABKAgSEgoK",
                    "dGFyZ2V0X21heBgGIAEoCBITCgt0YXJnZXRfc2xvdxgHIAEoCCIrChVSZWxl",
                    "YXNlUG9rZW1vblJlcXVlc3QSEgoKcG9rZW1vbl9pZBgBIAEoBiLfAQoWUmVs",
                    "ZWFzZVBva2Vtb25SZXNwb25zZRJQCgZyZXN1bHQYASABKA4yQC5Qb2tlbW9u",
                    "R28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuUmVsZWFzZVBva2Vtb25SZXNw",
                    "b25zZS5SZXN1bHQSFQoNY2FuZHlfYXdhcmRlZBgCIAEoBSJcCgZSZXN1bHQS",
                    "CQoFVU5TRVQQABILCgdTVUNDRVNTEAESFAoQUE9LRU1PTl9ERVBMT1lFRBAC",
                    "EgoKBkZBSUxFRBADEhgKFEVSUk9SX1BPS0VNT05fSVNfRUdHEAQiFwoVR2V0",
                    "SGF0Y2hlZEVnZ3NSZXF1ZXN0Io4BChZHZXRIYXRjaGVkRWdnc1Jlc3BvbnNl",
                    "Eg8KB3N1Y2Nlc3MYASABKAgSFgoKcG9rZW1vbl9pZBgCIAMoBEICEAESGgoS",
                    "ZXhwZXJpZW5jZV9hd2FyZGVkGAMgAygFEhUKDWNhbmR5X2F3YXJkZWQYBCAD",
                    "KAUSGAoQc3RhcmR1c3RfYXdhcmRlZBgFIAMoBSKGAQoRRm9ydFNlYXJjaFJl",
                    "cXVlc3QSDwoHZm9ydF9pZBgBIAEoCRIXCg9wbGF5ZXJfbGF0aXR1ZGUYAiAB",
                    "KAESGAoQcGxheWVyX2xvbmdpdHVkZRgDIAEoARIVCg1mb3J0X2xhdGl0dWRl",
                    "GAQgASgBEhYKDmZvcnRfbG9uZ2l0dWRlGAUgASgBIq0EChJGb3J0U2VhcmNo",
                    "UmVzcG9uc2USTAoGcmVzdWx0GAEgASgOMjwuUG9rZW1vbkdvLlJvY2tldEFQ",
                    "SS5HZW5lcmF0ZWRDb2RlLkZvcnRTZWFyY2hSZXNwb25zZS5SZXN1bHQSVgoN",
                    "aXRlbXNfYXdhcmRlZBgCIAMoCzI/LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2Vu",
                    "ZXJhdGVkQ29kZS5Gb3J0U2VhcmNoUmVzcG9uc2UuSXRlbUF3YXJkEhQKDGdl",
                    "bXNfYXdhcmRlZBgDIAEoBRJIChBwb2tlbW9uX2RhdGFfZWdnGAQgASgLMi4u",
                    "UG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLlBva2Vtb25EYXRh",
                    "EhoKEmV4cGVyaWVuY2VfYXdhcmRlZBgFIAEoBRImCh5jb29sZG93bl9jb21w",
                    "bGV0ZV90aW1lc3RhbXBfbXMYBiABKAMSIgoaY2hhaW5faGFja19zZXF1ZW5j",
                    "ZV9udW1iZXIYByABKAUaQQoJSXRlbUF3YXJkEiAKB2l0ZW1faWQYASABKA4y",
                    "Dy5BbGxFbnVtLkl0ZW1JZBISCgppdGVtX2NvdW50GAIgASgFImYKBlJlc3Vs",
                    "dBIRCg1OT19SRVNVTFRfU0VUEAASCwoHU1VDQ0VTUxABEhAKDE9VVF9PRl9S",
                    "QU5HRRACEhYKEklOX0NPT0xET1dOX1BFUklPRBADEhIKDklOVkVOVE9SWV9G",
                    "VUxMEAQiSgoSRm9ydERldGFpbHNSZXF1ZXN0Eg8KB2ZvcnRfaWQYASABKAkS",
                    "EAoIbGF0aXR1ZGUYAiABKAESEQoJbG9uZ2l0dWRlGAMgASgBIocDChNGb3J0",
                    "RGV0YWlsc1Jlc3BvbnNlEg8KB2ZvcnRfaWQYASABKAkSJgoKdGVhbV9jb2xv",
                    "chgCIAEoDjISLkFsbEVudW0uVGVhbUNvbG9yEkQKDHBva2Vtb25fZGF0YRgD",
                    "IAEoCzIuLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5Qb2tl",
                    "bW9uRGF0YRIMCgRuYW1lGAQgASgJEhIKCmltYWdlX3VybHMYBSADKAkSCgoC",
                    "ZnAYBiABKAUSDwoHc3RhbWluYRgHIAEoBRITCgttYXhfc3RhbWluYRgIIAEo",
                    "BRIfCgR0eXBlGAkgASgOMhEuQWxsRW51bS5Gb3J0VHlwZRIQCghsYXRpdHVk",
                    "ZRgKIAEoARIRCglsb25naXR1ZGUYCyABKAESEwoLZGVzY3JpcHRpb24YDCAB",
                    "KAkSQgoJbW9kaWZpZXJzGA0gAygLMi8uUG9rZW1vbkdvLlJvY2tldEFQSS5H",
                    "ZW5lcmF0ZWRDb2RlLkZvcnRNb2RpZmllciJzCgxGb3J0TW9kaWZpZXISIAoH",
                    "aXRlbV9pZBgBIAEoDjIPLkFsbEVudW0uSXRlbUlkEh8KF2V4cGlyYXRpb25f",
                    "dGltZXN0YW1wX21zGAIgASgDEiAKGGRlcGxveWVyX3BsYXllcl9jb2RlbmFt",
                    "ZRgDIAEoCSJyChBFbmNvdW50ZXJSZXF1ZXN0EhQKDGVuY291bnRlcl9pZBgB",
                    "IAEoBhIVCg1zcGF3bnBvaW50X2lkGAIgASgJEhcKD3BsYXllcl9sYXRpdHVk",
                    "ZRgDIAEoARIYChBwbGF5ZXJfbG9uZ2l0dWRlGAQgASgBIs0EChFFbmNvdW50",
                    "ZXJSZXNwb25zZRJECgx3aWxkX3Bva2Vtb24YASABKAsyLi5Qb2tlbW9uR28u",
                    "Um9ja2V0QVBJLkdlbmVyYXRlZENvZGUuV2lsZFBva2Vtb24SUwoKYmFja2dy",
                    "b3VuZBgCIAEoDjI/LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29k",
                    "ZS5FbmNvdW50ZXJSZXNwb25zZS5CYWNrZ3JvdW5kEksKBnN0YXR1cxgDIAEo",
                    "DjI7LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5FbmNvdW50",
                    "ZXJSZXNwb25zZS5TdGF0dXMSUgoTY2FwdHVyZV9wcm9iYWJpbGl0eRgEIAEo",
                    "CzI1LlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5DYXB0dXJl",
                    "UHJvYmFiaWxpdHkiIgoKQmFja2dyb3VuZBIICgRQQVJLEAASCgoGREVTRVJU",
                    "EAEi1wEKBlN0YXR1cxITCg9FTkNPVU5URVJfRVJST1IQABIVChFFTkNPVU5U",
                    "RVJfU1VDQ0VTUxABEhcKE0VOQ09VTlRFUl9OT1RfRk9VTkQQAhIUChBFTkNP",
                    "VU5URVJfQ0xPU0VEEAMSGgoWRU5DT1VOVEVSX1BPS0VNT05fRkxFRBAEEhoK",
                    "FkVOQ09VTlRFUl9OT1RfSU5fUkFOR0UQBRIeChpFTkNPVU5URVJfQUxSRUFE",
                    "WV9IQVBQRU5FRBAGEhoKFlBPS0VNT05fSU5WRU5UT1JZX0ZVTEwQByJ7ChJD",
                    "YXB0dXJlUHJvYmFiaWxpdHkSJgoNcG9rZWJhbGxfdHlwZRgBIAMoDjIPLkFs",
                    "bEVudW0uSXRlbUlkEhsKE2NhcHR1cmVfcHJvYmFiaWxpdHkYAiADKAISIAoY",
                    "cmV0aWNsZV9kaWZmaWN1bHR5X3NjYWxlGAwgASgBInAKFERpc2tFbmNvdW50",
                    "ZXJSZXF1ZXN0EhQKDGVuY291bnRlcl9pZBgBIAEoBhIPCgdmb3J0X2lkGAIg",
                    "ASgJEhcKD3BsYXllcl9sYXRpdHVkZRgDIAEoARIYChBwbGF5ZXJfbG9uZ2l0",
                    "dWRlGAQgASgBIogDChVEaXNrRW5jb3VudGVyUmVzcG9uc2USTwoGcmVzdWx0",
                    "GAEgASgOMj8uUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkRp",
                    "c2tFbmNvdW50ZXJSZXNwb25zZS5SZXN1bHQSRAoMcG9rZW1vbl9kYXRhGAIg",
                    "ASgLMi4uUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLlBva2Vt",
                    "b25EYXRhElIKE2NhcHR1cmVfcHJvYmFiaWxpdHkYAyABKAsyNS5Qb2tlbW9u",
                    "R28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuQ2FwdHVyZVByb2JhYmlsaXR5",
                    "IoMBCgZSZXN1bHQSCwoHVU5LTk9XThAAEgsKB1NVQ0NFU1MQARIRCg1OT1Rf",
                    "QVZBSUxBQkxFEAISEAoMTk9UX0lOX1JBTkdFEAMSHgoaRU5DT1VOVEVSX0FM",
                    "UkVBRFlfRklOSVNIRUQQBBIaChZQT0tFTU9OX0lOVkVOVE9SWV9GVUxMEAUi",
                    "wwEKE0NhdGNoUG9rZW1vblJlcXVlc3QSFAoMZW5jb3VudGVyX2lkGAEgASgG",
                    "EhAKCHBva2ViYWxsGAIgASgFEh8KF25vcm1hbGl6ZWRfcmV0aWNsZV9zaXpl",
                    "GAMgASgBEhgKEHNwYXduX3BvaW50X2d1aWQYBCABKAkSEwoLaGl0X3Bva2Vt",
                    "b24YBSABKAgSFQoNc3Bpbl9tb2RpZmllchgGIAEoARIdChVOb3JtYWxpemVk",
                    "SGl0UG9zaXRpb24YByABKAEixgIKFENhdGNoUG9rZW1vblJlc3BvbnNlElMK",
                    "BnN0YXR1cxgBIAEoDjJDLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVk",
                    "Q29kZS5DYXRjaFBva2Vtb25SZXNwb25zZS5DYXRjaFN0YXR1cxIUCgxtaXNz",
                    "X3BlcmNlbnQYAiABKAESGwoTY2FwdHVyZWRfcG9rZW1vbl9pZBgDIAEoBBI/",
                    "CgZzY29yZXMYBCABKAsyLy5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRl",
                    "ZENvZGUuQ2FwdHVyZVNjb3JlImUKC0NhdGNoU3RhdHVzEg8KC0NBVENIX0VS",
                    "Uk9SEAASEQoNQ0FUQ0hfU1VDQ0VTUxABEhAKDENBVENIX0VTQ0FQRRACEg4K",
                    "CkNBVENIX0ZMRUUQAxIQCgxDQVRDSF9NSVNTRUQQBCJpCgxDYXB0dXJlU2Nv",
                    "cmUSLAoNYWN0aXZpdHlfdHlwZRgBIAMoDjIVLkFsbEVudW0uQWN0aXZpdHlU",
                    "eXBlEgoKAnhwGAIgAygFEg0KBWNhbmR5GAMgAygFEhAKCHN0YXJkdXN0GAQg",
                    "AygFIhsKGUNoZWNrQXdhcmRlZEJhZGdlc1JlcXVlc3QidwoaQ2hlY2tBd2Fy",
                    "ZGVkQmFkZ2VzUmVzcG9uc2USDwoHc3VjY2VzcxgBIAEoCBIqCg5hd2FyZGVk",
                    "X2JhZGdlcxgCIAMoDjISLkFsbEVudW0uQmFkZ2VUeXBlEhwKFGF3YXJkZWRf",
                    "YmFkZ2VfbGV2ZWxzGAMgAygFInkKFUVxdWlwcGVkQmFkZ2VTZXR0aW5ncxIf",
                    "ChdlcXVpcF9iYWRnZV9jb29sZG93bl9tcxgBIAEoAxIfChdjYXRjaF9wcm9i",
                    "YWJpbGl0eV9ib251cxgCIAMoAhIeChZmbGVlX3Byb2JhYmlsaXR5X2JvbnVz",
                    "GAMgAygCIoQBChZQb2tlbW9uVXBncmFkZVNldHRpbmdzEhoKEnVwZ3JhZGVz",
                    "X3Blcl9sZXZlbBgBIAEoBRIjChthbGxvd2VkX2xldmVsc19hYm92ZV9wbGF5",
                    "ZXIYAiABKAUSEgoKY2FuZHlfY29zdBgDIAMoBRIVCg1zdGFyZHVzdF9jb3N0",
                    "GAQgAygFIowCCgtJYXBTZXR0aW5ncxIZChFkYWlseV9ib251c19jb2lucxgB",
                    "IAEoBRIoCiBkYWlseV9kZWZlbmRlcl9ib251c19wZXJfcG9rZW1vbhgCIAMo",
                    "BRIqCiJkYWlseV9kZWZlbmRlcl9ib251c19tYXhfZGVmZW5kZXJzGAMgASgF",
                    "EiUKHWRhaWx5X2RlZmVuZGVyX2JvbnVzX2N1cnJlbmN5GAQgAygJEiIKGm1p",
                    "bl90aW1lX2JldHdlZW5fY2xhaW1zX21zGAUgASgDEhsKE2RhaWx5X2JvbnVz",
                    "X2VuYWJsZWQYBiABKAgSJAocZGFpbHlfZGVmZW5kZXJfYm9udXNfZW5hYmxl",
                    "ZBgHIAEoCCKUAQoOSWFwSXRlbURpc3BsYXkSCwoDc2t1GAEgASgJEi4KCGNh",
                    "dGVnb3J5GAIgASgOMhwuQWxsRW51bS5Ib2xvSWFwSXRlbUNhdGVnb3J5EhIK",
                    "CnNvcnRfb3JkZXIYAyABKAUSIQoIaXRlbV9pZHMYBCADKA4yDy5BbGxFbnVt",
                    "Lkl0ZW1JZBIOCgZjb3VudHMYBSADKAUirgEKEUVuY291bnRlclNldHRpbmdz",
                    "EhwKFHNwaW5fYm9udXNfdGhyZXNob2xkGAEgASgCEiEKGWV4Y2VsbGVudF90",
                    "aHJvd190aHJlc2hvbGQYAiABKAISHQoVZ3JlYXRfdGhyb3dfdGhyZXNob2xk",
                    "GAMgASgCEhwKFG5pY2VfdGhyb3dfdGhyZXNob2xkGAQgASgCEhsKE21pbGVz",
                    "dG9uZV90aHJlc2hvbGQYBSABKAUixgMKEUd5bUJhdHRsZVNldHRpbmdzEhYK",
                    "DmVuZXJneV9wZXJfc2VjGAEgASgCEhkKEWRvZGdlX2VuZXJneV9jb3N0GAIg",
                    "ASgCEhgKEHJldGFyZ2V0X3NlY29uZHMYAyABKAISHQoVZW5lbXlfYXR0YWNr",
                    "X2ludGVydmFsGAQgASgCEh4KFmF0dGFja19zZXJ2ZXJfaW50ZXJ2YWwYBSAB",
                    "KAISHgoWcm91bmRfZHVyYXRpb25fc2Vjb25kcxgGIAEoAhIjChtib251c190",
                    "aW1lX3Blcl9hbGx5X3NlY29uZHMYByABKAISJAocbWF4aW11bV9hdHRhY2tl",
                    "cnNfcGVyX2JhdHRsZRgIIAEoBRIpCiFzYW1lX3R5cGVfYXR0YWNrX2JvbnVz",
                    "X211bHRpcGxpZXIYCSABKAISFgoObWF4aW11bV9lbmVyZ3kYCiABKAUSJAoc",
                    "ZW5lcmd5X2RlbHRhX3Blcl9oZWFsdGhfbG9zdBgLIAEoAhIZChFkb2RnZV9k",
                    "dXJhdGlvbl9tcxgMIAEoBRIcChRtaW5pbXVtX3BsYXllcl9sZXZlbBgNIAEo",
                    "BRIYChBzd2FwX2R1cmF0aW9uX21zGA4gASgFIncKEEd5bUxldmVsU2V0dGlu",
                    "Z3MSGwoTcmVxdWlyZWRfZXhwZXJpZW5jZRgBIAMoBRIUCgxsZWFkZXJfc2xv",
                    "dHMYAiADKAUSFQoNdHJhaW5lcl9zbG90cxgDIAMoBRIZChFzZWFyY2hfcm9s",
                    "bF9ib251cxgEIAMoBSKdAQoTUGxheWVyTGV2ZWxTZXR0aW5ncxIQCghyYW5r",
                    "X251bRgBIAMoBRIbChNyZXF1aXJlZF9leHBlcmllbmNlGAIgAygFEhUKDWNw",
                    "X211bHRpcGxpZXIYAyADKAISHAoUbWF4X2VnZ19wbGF5ZXJfbGV2ZWwYBCAB",
                    "KAUSIgoabWF4X2VuY291bnRlcl9wbGF5ZXJfbGV2ZWwYBSABKAUixQMKDkNh",
                    "bWVyYVNldHRpbmdzEhMKC25leHRfY2FtZXJhGAEgASgJEjMKDWludGVycG9s",
                    "YXRpb24YAiADKA4yHC5BbGxFbnVtLkNhbWVyYUludGVycG9sYXRpb24SKgoL",
                    "dGFyZ2V0X3R5cGUYAyADKA4yFS5BbGxFbnVtLkNhbWVyYVRhcmdldBIVCg1l",
                    "YXNlX2luX3NwZWVkGAQgAygCEhYKDmVhc3Rfb3V0X3NwZWVkGAUgAygCEhgK",
                    "EGR1cmF0aW9uX3NlY29uZHMYBiADKAISFAoMd2FpdF9zZWNvbmRzGAcgAygC",
                    "EhoKEnRyYW5zaXRpb25fc2Vjb25kcxgIIAMoAhIUCgxhbmdsZV9kZWdyZWUY",
                    "CSADKAISGwoTYW5nbGVfb2Zmc2V0X2RlZ3JlZRgKIAMoAhIUCgxwaXRjaF9k",
                    "ZWdyZWUYCyADKAISGwoTcGl0Y2hfb2Zmc2V0X2RlZ3JlZRgMIAMoAhITCgty",
                    "b2xsX2RlZ3JlZRgNIAMoAhIXCg9kaXN0YW5jZV9tZXRlcnMYDiADKAISFgoO",
                    "aGVpZ2h0X3BlcmNlbnQYDyADKAISFgoOdmVydF9jdHJfcmF0aW8YECADKAIi",
                    "XAoNQmFkZ2VTZXR0aW5ncxImCgpiYWRnZV90eXBlGAEgASgOMhIuQWxsRW51",
                    "bS5CYWRnZVR5cGUSEgoKYmFkZ2VfcmFuaxgCIAEoBRIPCgd0YXJnZXRzGAMg",
                    "AygFIlkKFVR5cGVFZmZlY3RpdmVTZXR0aW5ncxIVCg1hdHRhY2tfc2NhbGFy",
                    "GAEgAygCEikKC2F0dGFja190eXBlGAIgASgOMhQuQWxsRW51bS5Qb2tlbW9u",
                    "VHlwZSIoChRNb3ZlU2VxdWVuY2VTZXR0aW5ncxIQCghzZXF1ZW5jZRgBIAMo",
                    "CSKnAwoMTW92ZVNldHRpbmdzEjEKC21vdmVtZW50X2lkGAEgASgOMhwuQWxs",
                    "RW51bS5Qb2tlbW9uTW92ZW1lbnRUeXBlEhQKDGFuaW1hdGlvbl9pZBgCIAEo",
                    "BRIqCgxwb2tlbW9uX3R5cGUYAyABKA4yFC5BbGxFbnVtLlBva2Vtb25UeXBl",
                    "Eg0KBXBvd2VyGAQgASgCEhcKD2FjY3VyYWN5X2NoYW5jZRgFIAEoAhIXCg9j",
                    "cml0aWNhbF9jaGFuY2UYBiABKAISEwoLaGVhbF9zY2FsYXIYByABKAISGwoT",
                    "c3RhbWluYV9sb3NzX3NjYWxhchgIIAEoAhIZChF0cmFpbmVyX2xldmVsX21p",
                    "bhgJIAEoBRIZChF0cmFpbmVyX2xldmVsX21heBgKIAEoBRIQCgh2ZnhfbmFt",
                    "ZRgLIAEoCRITCgtkdXJhdGlvbl9tcxgMIAEoBRIeChZkYW1hZ2Vfd2luZG93",
                    "X3N0YXJ0X21zGA0gASgFEhwKFGRhbWFnZV93aW5kb3dfZW5kX21zGA4gASgF",
                    "EhQKDGVuZXJneV9kZWx0YRgPIAEoBSK+BgoPUG9rZW1vblNldHRpbmdzEiYK",
                    "CnBva2Vtb25faWQYASABKA4yEi5BbGxFbnVtLlBva2Vtb25JZBITCgttb2Rl",
                    "bF9zY2FsZRgDIAEoAhIiCgR0eXBlGAQgASgOMhQuQWxsRW51bS5Qb2tlbW9u",
                    "VHlwZRIkCgZ0eXBlXzIYBSABKA4yFC5BbGxFbnVtLlBva2Vtb25UeXBlEkMK",
                    "BmNhbWVyYRgGIAEoCzIzLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVk",
                    "Q29kZS5DYW1lcmFBdHRyaWJ1dGVzEkkKCWVuY291bnRlchgHIAEoCzI2LlBv",
                    "a2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5FbmNvdW50ZXJBdHRy",
                    "aWJ1dGVzEkEKBXN0YXRzGAggASgLMjIuUG9rZW1vbkdvLlJvY2tldEFQSS5H",
                    "ZW5lcmF0ZWRDb2RlLlN0YXRzQXR0cmlidXRlcxIpCgtxdWlja19tb3ZlcxgJ",
                    "IAMoDjIULkFsbEVudW0uUG9rZW1vbk1vdmUSLQoPY2luZW1hdGljX21vdmVz",
                    "GAogAygOMhQuQWxsRW51bS5Qb2tlbW9uTW92ZRIWCg5hbmltYXRpb25fdGlt",
                    "ZRgLIAMoAhIpCg1ldm9sdXRpb25faWRzGAwgAygOMhIuQWxsRW51bS5Qb2tl",
                    "bW9uSWQSFgoOZXZvbHV0aW9uX3BpcHMYDSABKAUSJAoFY2xhc3MYDiABKA4y",
                    "FS5BbGxFbnVtLlBva2Vtb25DbGFzcxIYChBwb2tlZGV4X2hlaWdodF9tGA8g",
                    "ASgCEhkKEXBva2VkZXhfd2VpZ2h0X2tnGBAgASgCEi0KEXBhcmVudF9wb2tl",
                    "bW9uX2lkGBEgASgOMhIuQWxsRW51bS5Qb2tlbW9uSWQSFgoOaGVpZ2h0X3N0",
                    "ZF9kZXYYEiABKAISFgoOd2VpZ2h0X3N0ZF9kZXYYEyABKAISHAoUa21fZGlz",
                    "dGFuY2VfdG9faGF0Y2gYFCABKAISKwoJZmFtaWx5X2lkGBUgASgOMhguQWxs",
                    "RW51bS5Qb2tlbW9uRmFtaWx5SWQSFwoPY2FuZHlfdG9fZXZvbHZlGBYgASgF",
                    "IpcBChBDYW1lcmFBdHRyaWJ1dGVzEhUKDWRpc2tfcmFkaXVzX20YASABKAIS",
                    "GQoRY3lsaW5kZXJfcmFkaXVzX20YAiABKAISGQoRY3lsaW5kZXJfaGVpZ2h0",
                    "X20YAyABKAISGQoRY3lsaW5kZXJfZ3JvdW5kX20YBCABKAISGwoTc2hvdWxk",
                    "ZXJfbW9kZV9zY2FsZRgFIAEoAiKdAgoTRW5jb3VudGVyQXR0cmlidXRlcxIZ",
                    "ChFiYXNlX2NhcHR1cmVfcmF0ZRgBIAEoAhIWCg5iYXNlX2ZsZWVfcmF0ZRgC",
                    "IAEoAhIaChJjb2xsaXNpb25fcmFkaXVzX20YAyABKAISGgoSY29sbGlzaW9u",
                    "X2hlaWdodF9tGAQgASgCEh8KF2NvbGxpc2lvbl9oZWFkX3JhZGl1c19tGAUg",
                    "ASgCEjMKDW1vdmVtZW50X3R5cGUYBiABKA4yHC5BbGxFbnVtLlBva2Vtb25N",
                    "b3ZlbWVudFR5cGUSGAoQbW92ZW1lbnRfdGltZXJfcxgHIAEoAhITCgtqdW1w",
                    "X3RpbWVfcxgIIAEoAhIWCg5hdHRhY2tfdGltZXJfcxgJIAEoAiJuCg9TdGF0",
                    "c0F0dHJpYnV0ZXMSFAoMYmFzZV9zdGFtaW5hGAEgASgFEhMKC2Jhc2VfYXR0",
                    "YWNrGAIgASgFEhQKDGJhc2VfZGVmZW5zZRgDIAEoBRIaChJkb2RnZV9lbmVy",
                    "Z3lfZGVsdGEYCCABKAUinAcKDEl0ZW1TZXR0aW5ncxIgCgdpdGVtX2lkGAEg",
                    "ASgOMg8uQWxsRW51bS5JdGVtSWQSJAoJaXRlbV90eXBlGAIgASgOMhEuQWxs",
                    "RW51bS5JdGVtVHlwZRInCghjYXRlZ29yeRgDIAEoDjIVLkFsbEVudW0uSXRl",
                    "bUNhdGVnb3J5EhEKCWRyb3BfZnJlcRgEIAEoAhIaChJkcm9wX3RyYWluZXJf",
                    "bGV2ZWwYBSABKAUSRwoIcG9rZWJhbGwYBiABKAsyNS5Qb2tlbW9uR28uUm9j",
                    "a2V0QVBJLkdlbmVyYXRlZENvZGUuUG9rZWJhbGxBdHRyaWJ1dGVzEkMKBnBv",
                    "dGlvbhgHIAEoCzIzLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29k",
                    "ZS5Qb3Rpb25BdHRyaWJ1dGVzEkMKBnJldml2ZRgIIAEoCzIzLlBva2Vtb25H",
                    "by5Sb2NrZXRBUEkuR2VuZXJhdGVkQ29kZS5SZXZpdmVBdHRyaWJ1dGVzEkMK",
                    "BmJhdHRsZRgJIAEoCzIzLlBva2Vtb25Hby5Sb2NrZXRBUEkuR2VuZXJhdGVk",
                    "Q29kZS5CYXR0bGVBdHRyaWJ1dGVzEj8KBGZvb2QYCiABKAsyMS5Qb2tlbW9u",
                    "R28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuRm9vZEF0dHJpYnV0ZXMSWAoR",
                    "aW52ZW50b3J5X3VwZ3JhZGUYCyABKAsyPS5Qb2tlbW9uR28uUm9ja2V0QVBJ",
                    "LkdlbmVyYXRlZENvZGUuSW52ZW50b3J5VXBncmFkZUF0dHJpYnV0ZXMSTgoI",
                    "eHBfYm9vc3QYDCABKAsyPC5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRl",
                    "ZENvZGUuRXhwZXJpZW5jZUJvb3N0QXR0cmlidXRlcxJFCgdpbmNlbnNlGA0g",
                    "ASgLMjQuUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkluY2Vu",
                    "c2VBdHRyaWJ1dGVzElAKDWVnZ19pbmN1YmF0b3IYDiABKAsyOS5Qb2tlbW9u",
                    "R28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuRWdnSW5jdWJhdG9yQXR0cmli",
                    "dXRlcxJQCg1mb3J0X21vZGlmaWVyGA8gASgLMjkuUG9rZW1vbkdvLlJvY2tl",
                    "dEFQSS5HZW5lcmF0ZWRDb2RlLkZvcnRNb2RpZmllckF0dHJpYnV0ZXMiJwoQ",
                    "QmF0dGxlQXR0cmlidXRlcxITCgtzdGFfcGVyY2VudBgBIAEoAiJ2ChZFZ2dJ",
                    "bmN1YmF0b3JBdHRyaWJ1dGVzEjEKDmluY3ViYXRvcl90eXBlGAEgASgOMhku",
                    "QWxsRW51bS5FZ2dJbmN1YmF0b3JUeXBlEgwKBHVzZXMYAiABKAUSGwoTZGlz",
                    "dGFuY2VfbXVsdGlwbGllchgDIAEoAiJNChlFeHBlcmllbmNlQm9vc3RBdHRy",
                    "aWJ1dGVzEhUKDXhwX211bHRpcGxpZXIYASABKAISGQoRYm9vc3RfZHVyYXRp",
                    "b25fbXMYAiABKAUibwoORm9vZEF0dHJpYnV0ZXMSKAoLaXRlbV9lZmZlY3QY",
                    "ASADKA4yEy5BbGxFbnVtLkl0ZW1FZmZlY3QSGwoTaXRlbV9lZmZlY3RfcGVy",
                    "Y2VudBgCIAMoAhIWCg5ncm93dGhfcGVyY2VudBgDIAEoAiJiChZGb3J0TW9k",
                    "aWZpZXJBdHRyaWJ1dGVzEiEKGW1vZGlmaWVyX2xpZmV0aW1lX3NlY29uZHMY",
                    "ASABKAUSJQoddHJveV9kaXNrX251bV9wb2tlbW9uX3NwYXduZWQYAiABKAUi",
                    "yQIKEUluY2Vuc2VBdHRyaWJ1dGVzEiAKGGluY2Vuc2VfbGlmZXRpbWVfc2Vj",
                    "b25kcxgBIAEoBRIqCgxwb2tlbW9uX3R5cGUYAiADKA4yFC5BbGxFbnVtLlBv",
                    "a2Vtb25UeXBlEigKIHBva2Vtb25faW5jZW5zZV90eXBlX3Byb2JhYmlsaXR5",
                    "GAMgASgCEjAKKHN0YW5kaW5nX3RpbWVfYmV0d2Vlbl9lbmNvdW50ZXJzX3Nl",
                    "Y29uZHMYBCABKAUSLQolbW92aW5nX3RpbWVfYmV0d2Vlbl9lbmNvdW50ZXJf",
                    "c2Vjb25kcxgFIAEoBRI1Ci1kaXN0YW5jZV9yZXF1aXJlZF9mb3Jfc2hvcnRl",
                    "cl9pbnRlcnZhbF9tZXRlcnMYBiABKAUSJAoccG9rZW1vbl9hdHRyYWN0ZWRf",
                    "bGVuZ3RoX3NlYxgHIAEoBSJtChpJbnZlbnRvcnlVcGdyYWRlQXR0cmlidXRl",
                    "cxIaChJhZGRpdGlvbmFsX3N0b3JhZ2UYASABKAUSMwoMdXBncmFkZV90eXBl",
                    "GAIgASgOMh0uQWxsRW51bS5JbnZlbnRvcnlVcGdyYWRlVHlwZSKMAQoSUG9r",
                    "ZWJhbGxBdHRyaWJ1dGVzEigKC2l0ZW1fZWZmZWN0GAEgASgOMhMuQWxsRW51",
                    "bS5JdGVtRWZmZWN0EhUKDWNhcHR1cmVfbXVsdGkYAiABKAISHAoUY2FwdHVy",
                    "ZV9tdWx0aV9lZmZlY3QYAyABKAISFwoPaXRlbV9lZmZlY3RfbW9kGAQgASgC",
                    "IjsKEFBvdGlvbkF0dHJpYnV0ZXMSEwoLc3RhX3BlcmNlbnQYASABKAISEgoK",
                    "c3RhX2Ftb3VudBgCIAEoBSInChBSZXZpdmVBdHRyaWJ1dGVzEhMKC3N0YV9w",
                    "ZXJjZW50GAEgASgCIiQKD1RyYW5zZmVyUG9rZW1vbhIRCglQb2tlbW9uSWQY",
                    "ASABKAYiOgoSVHJhbnNmZXJQb2tlbW9uT3V0Eg4KBlN0YXR1cxgBIAEoBRIU",
                    "CgxDYW5keUF3YXJkZWQYAiABKAUiIgoNRXZvbHZlUG9rZW1vbhIRCglQb2tl",
                    "bW9uSWQYASABKAYikAEKEEV2b2x2ZVBva2Vtb25PdXQSDgoGUmVzdWx0GAEg",
                    "ASgFEkIKDkV2b2x2ZWRQb2tlbW9uGAIgASgLMiouUG9rZW1vbkdvLlJvY2tl",
                    "dEFQSS5HZW5lcmF0ZWRDb2RlLlBva2Vtb24SEgoKRXhwQXdhcmRlZBgDIAEo",
                    "BRIUCgxDYW5keUF3YXJkZWQYBCABKAViBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::AllEnum.AllEnumReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[]
                {
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.GetPlayerResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.GetPlayerResponse.Parser,
                        new[] {"Unknown1", "Profile"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.Profile),
                        global::PokeGodar.WebAPI.GeneratedCode.Profile.Parser,
                        new[]
                        {
                            "CreationTime", "Username", "Team", "Tutorial", "Avatar", "PokeStorage", "ItemStorage",
                            "DailyBonus", "Unknown12", "Unknown13", "Currency"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.DailyBonus),
                        global::PokeGodar.WebAPI.GeneratedCode.DailyBonus.Parser,
                        new[] {"NextCollectTimestampMs", "NextDefenderBonusCollectTimestampMs"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.Currency),
                        global::PokeGodar.WebAPI.GeneratedCode.Currency.Parser, new[] {"Type", "Amount"}, null, null,
                        null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.AvatarDetails),
                        global::PokeGodar.WebAPI.GeneratedCode.AvatarDetails.Parser,
                        new[] {"Unknown2", "Unknown3", "Unknown9", "Unknown10"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.DownloadSettingsRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.DownloadSettingsRequest.Parser, new[] {"Hash"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.GetInventoryResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.GetInventoryResponse.Parser,
                        new[] {"Success", "InventoryDelta"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.InventoryDelta),
                        global::PokeGodar.WebAPI.GeneratedCode.InventoryDelta.Parser,
                        new[] {"OriginalTimestampMs", "NewTimestampMs", "InventoryItems"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.InventoryItem),
                        global::PokeGodar.WebAPI.GeneratedCode.InventoryItem.Parser,
                        new[] {"ModifiedTimestampMs", "DeletedItemKey", "InventoryItemData"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.InventoryItemData),
                        global::PokeGodar.WebAPI.GeneratedCode.InventoryItemData.Parser,
                        new[]
                        {
                            "Pokemon", "Item", "PokedexEntry", "PlayerStats", "PlayerCurrency", "PlayerCamera",
                            "InventoryUpgrades", "AppliedItems", "EggIncubators", "PokemonFamily"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.Pokemon),
                        global::PokeGodar.WebAPI.GeneratedCode.Pokemon.Parser,
                        new[]
                        {
                            "Id", "PokemonType", "Cp", "Stamina", "StaminaMax", "Move1", "Move2", "DeployedFortId",
                            "OwnerName", "IsEgg", "EggKmWalkedTarget", "EggKmWalkedStart", "Origin", "HeightM",
                            "WeightKg", "IndividualAttack", "IndividualDefense", "IndividualStamina", "CpMultiplier",
                            "Pokeball", "CapturedCellId", "BattlesAttacked", "BattlesDefended", "EggIncubatorId",
                            "CreationTimeMs", "NumUpgrades", "AdditionalCpMultiplier", "Favorite", "Nickname",
                            "FromFort"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.Item),
                        global::PokeGodar.WebAPI.GeneratedCode.Item.Parser, new[] {"Item_", "Count", "Unseen"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PokedexEntry),
                        global::PokeGodar.WebAPI.GeneratedCode.PokedexEntry.Parser,
                        new[]
                        {
                            "PokedexEntryNumber", "TimesEncountered", "TimesCaptured", "EvolutionStonePieces",
                            "EvolutionStones"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PlayerStats),
                        global::PokeGodar.WebAPI.GeneratedCode.PlayerStats.Parser,
                        new[]
                        {
                            "Level", "Experience", "PrevLevelXp", "NextLevelXp", "KmWalked", "PokemonsEncountered",
                            "UniquePokedexEntries", "PokemonsCaptured", "Evolutions", "PokeStopVisits",
                            "PokeballsThrown", "EggsHatched", "BigMagikarpCaught", "BattleAttackWon",
                            "BattleAttackTotal", "BattleDefendedWon", "BattleTrainingWon", "BattleTrainingTotal",
                            "PrestigeRaisedTotal", "PrestigeDroppedTotal", "PokemonDeployed", "PokemonCaughtByType",
                            "SmallRattataCaught"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PlayerCurrency),
                        global::PokeGodar.WebAPI.GeneratedCode.PlayerCurrency.Parser, new[] {"Gems"}, null, null,
                        null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PlayerCamera),
                        global::PokeGodar.WebAPI.GeneratedCode.PlayerCamera.Parser, new[] {"IsDefaultCamera"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrades),
                        global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrades.Parser, new[] {"InventoryUpgrades_"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrade),
                        global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrade.Parser,
                        new[] {"Item", "UpgradeType", "AdditionalStorage"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.AppliedItems),
                        global::PokeGodar.WebAPI.GeneratedCode.AppliedItems.Parser, new[] {"Item"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.AppliedItem),
                        global::PokeGodar.WebAPI.GeneratedCode.AppliedItem.Parser,
                        new[] {"ItemType", "ItemTypeCategory", "ExpireMs", "AppliedMs"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.EggIncubators),
                        global::PokeGodar.WebAPI.GeneratedCode.EggIncubators.Parser, new[] {"EggIncubator"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.EggIncubator),
                        global::PokeGodar.WebAPI.GeneratedCode.EggIncubator.Parser,
                        new[]
                        {
                            "ItemId", "ItemType", "IncubatorType", "UsesRemaining", "PokemonId", "StartKmWalked",
                            "TargetKmWalked"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PokemonFamily),
                        global::PokeGodar.WebAPI.GeneratedCode.PokemonFamily.Parser, new[] {"FamilyId", "Candy"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.GetMapObjectsRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.GetMapObjectsRequest.Parser,
                        new[] {"CellId", "SinceTimestampMs", "Latitude", "Longitude"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.GetMapObjectsResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.GetMapObjectsResponse.Parser,
                        new[] {"MapCells", "Status"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.MapCell),
                        global::PokeGodar.WebAPI.GeneratedCode.MapCell.Parser,
                        new[]
                        {
                            "S2CellId", "CurrentTimestampMs", "Forts", "SpawnPoints", "DeletedObjects", "IsTruncatedList",
                            "FortSummaries", "DecimatedSpawnPoints", "WildPokemons", "CatchablePokemons",
                            "NearbyPokemons"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortData),
                        global::PokeGodar.WebAPI.GeneratedCode.FortData.Parser,
                        new[]
                        {
                            "Id", "LastModifiedTimestampMs", "Latitude", "Longitude", "Enabled", "Type", "OwnedByTeam",
                            "GuardPokemonId", "GuardPokemonCp", "GymPoints", "IsInBattle", "CooldownCompleteTimestampMs",
                            "Sponsor", "RenderingType", "ActiveFortModifier", "LureInfo"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortLureInfo),
                        global::PokeGodar.WebAPI.GeneratedCode.FortLureInfo.Parser,
                        new[] {"FortId", "Unknown2", "ActivePokemonId", "LureExpiresTimestampMs"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint),
                        global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint.Parser, new[] {"Latitude", "Longitude"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortSummary),
                        global::PokeGodar.WebAPI.GeneratedCode.FortSummary.Parser,
                        new[] {"FortSummaryId", "LastModifiedTimestampMs", "Latitude", "Longitude"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.WildPokemon),
                        global::PokeGodar.WebAPI.GeneratedCode.WildPokemon.Parser,
                        new[]
                        {
                            "EncounterId", "LastModifiedTimestampMs", "Latitude", "Longitude", "SpawnpointId",
                            "PokemonData", "TimeTillHiddenMs"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PokemonData),
                        global::PokeGodar.WebAPI.GeneratedCode.PokemonData.Parser,
                        new[]
                        {
                            "Id", "PokemonId", "Cp", "Stamina", "StaminaMax", "Move1", "Move2", "DeployedFortId",
                            "OwnerName", "IsEgg", "EggKmWalkedTarget", "EggKmWalkedStart", "Origin", "HeightM",
                            "WeightKg", "IndividualAttack", "IndividualDefense", "IndividualStamina", "CpMultiplier",
                            "Pokeball", "CapturedCellId", "BattlesAttacked", "BattlesDefended", "EggIncubatorId",
                            "CreationTimeMs", "NumUpgrades", "AdditionalCpMultiplier", "Favorite", "Nickname",
                            "FromFort"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.MapPokemon),
                        global::PokeGodar.WebAPI.GeneratedCode.MapPokemon.Parser,
                        new[]
                        {"SpawnpointId", "EncounterId", "PokemonId", "ExpirationTimestampMs", "Latitude", "Longitude"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.NearbyPokemon),
                        global::PokeGodar.WebAPI.GeneratedCode.NearbyPokemon.Parser,
                        new[] {"PokemonId", "DistanceInMeters", "EncounterId"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.DownloadSettingsResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.DownloadSettingsResponse.Parser,
                        new[] {"Error", "Hash", "Settings"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.GlobalSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.GlobalSettings.Parser,
                        new[]
                        {"FortSettings", "MapSettings", "LevelSettings", "InventorySettings", "MinimumClientVersion"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.FortSettings.Parser,
                        new[]
                        {
                            "InteractionRangeMeters", "MaxTotalDeployedPokemon", "MaxPlayerDeployedPokemon",
                            "DeployStaminaMultiplier", "DeployAttackMultiplier", "FarInteractionRangeMeters"
                        }, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.MapSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.MapSettings.Parser,
                        new[]
                        {
                            "PokemonVisibleRange", "PokeNavRangeMeters", "EncounterRangeMeters",
                            "GetMapObjectsMinRefreshSeconds", "GetMapObjectsMaxRefreshSeconds",
                            "GetMapObjectsMinDistanceMeters", "GoogleMapsApiKey"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.LevelSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.LevelSettings.Parser,
                        new[] {"TrainerCpModifier", "TrainerDifficultyModifier"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.InventorySettings),
                        global::PokeGodar.WebAPI.GeneratedCode.InventorySettings.Parser,
                        new[] {"MaxPokemon", "MaxBagItems", "BasePokemon", "BaseBagItems", "BaseEggs"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.PlayerUpdateRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.PlayerUpdateRequest.Parser,
                        new[] {"Latitude", "Longitude"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.PlayerUpdateResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.PlayerUpdateResponse.Parser,
                        new[] {"WildPokemons", "Forts", "FortsNearby"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesRequest.Parser, null, null, null,
                        null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Parser,
                        new[] {"Success", "ItemTemplates", "TimestampMs"}, null, null,
                        new pbr::GeneratedClrTypeInfo[]
                        {
                            new pbr::GeneratedClrTypeInfo(
                                typeof(
                                    global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Types.
                                        ItemTemplate),
                                global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Types
                                    .ItemTemplate.Parser,
                                new[]
                                {
                                    "TemplateId", "PokemonSettings", "ItemSettings", "MoveSettings", "MoveSequenceSettings",
                                    "TypeEffective", "BadgeSettings", "Camera", "PlayerLevel", "GymLevel",
                                    "BattleSettings", "EncounterSettings", "IapItemDisplay", "IapSettings",
                                    "PokemonUpgrades", "EquippedBadges"
                                }, null, null, null)
                        }),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.UseItemCaptureRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.UseItemCaptureRequest.Parser,
                        new[] {"ItemId", "EncounterId", "SpawnPointGuid"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.UseItemCaptureResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.UseItemCaptureResponse.Parser,
                        new[]
                        {
                            "Success", "ItemCaptureMult", "ItemFleeMult", "StopMovement", "StopAttack", "TargetMax",
                            "TargetSlow"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonRequest.Parser, new[] {"PokemonId"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonResponse.Parser,
                        new[] {"Result", "CandyAwarded"}, null,
                        new[] {typeof(global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonResponse.Types.Result)},
                        null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.GetHatchedEggsRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.GetHatchedEggsRequest.Parser, null, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.GetHatchedEggsResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.GetHatchedEggsResponse.Parser,
                        new[] {"Success", "PokemonId", "ExperienceAwarded", "CandyAwarded", "StardustAwarded"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortSearchRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.FortSearchRequest.Parser,
                        new[] {"FortId", "PlayerLatitude", "PlayerLongitude", "FortLatitude", "FortLongitude"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Parser,
                        new[]
                        {
                            "Result", "ItemsAwarded", "GemsAwarded", "PokemonDataEgg", "ExperienceAwarded",
                            "CooldownCompleteTimestampMs", "ChainHackSequenceNumber"
                        }, null,
                        new[] {typeof(global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.Result)},
                        new pbr::GeneratedClrTypeInfo[]
                        {
                            new pbr::GeneratedClrTypeInfo(
                                typeof(global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.ItemAward),
                                global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.ItemAward.Parser,
                                new[] {"ItemId", "ItemCount"}, null, null, null)
                        }),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortDetailsRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.FortDetailsRequest.Parser,
                        new[] {"FortId", "Latitude", "Longitude"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.FortDetailsResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.FortDetailsResponse.Parser,
                        new[]
                        {
                            "FortId", "TeamColor", "PokemonData", "Name", "ImageUrls", "Fp", "Stamina", "MaxStamina",
                            "Type", "Latitude", "Longitude", "Description", "Modifiers"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FortModifier),
                        global::PokeGodar.WebAPI.GeneratedCode.FortModifier.Parser,
                        new[] {"ItemId", "ExpirationTimestampMs", "DeployerPlayerCodename"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.EncounterRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.EncounterRequest.Parser,
                        new[] {"EncounterId", "SpawnpointId", "PlayerLatitude", "PlayerLongitude"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Parser,
                        new[] {"WildPokemon", "Background", "Status", "CaptureProbability"}, null,
                        new[]
                        {
                            typeof(global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Background),
                            typeof(global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Status)
                        }, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability),
                        global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability.Parser,
                        new[] {"PokeballType", "CaptureProbability_", "ReticleDifficultyScale"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterRequest.Parser,
                        new[] {"EncounterId", "FortId", "PlayerLatitude", "PlayerLongitude"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterResponse.Parser,
                        new[] {"Result", "PokemonData", "CaptureProbability"}, null,
                        new[] {typeof(global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterResponse.Types.Result)},
                        null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonRequest.Parser,
                        new[]
                        {
                            "EncounterId", "Pokeball", "NormalizedReticleSize", "SpawnPointGuid", "HitPokemon",
                            "SpinModifier", "NormalizedHitPosition"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonResponse.Parser,
                        new[] {"Status", "MissPercent", "CapturedPokemonId", "Scores"}, null,
                        new[] {typeof(global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonResponse.Types.CatchStatus)},
                        null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.CaptureScore),
                        global::PokeGodar.WebAPI.GeneratedCode.CaptureScore.Parser,
                        new[] {"ActivityType", "Xp", "Candy", "Stardust"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.CheckAwardedBadgesRequest),
                        global::PokeGodar.WebAPI.GeneratedCode.CheckAwardedBadgesRequest.Parser, null, null, null,
                        null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.CheckAwardedBadgesResponse),
                        global::PokeGodar.WebAPI.GeneratedCode.CheckAwardedBadgesResponse.Parser,
                        new[] {"Success", "AwardedBadges", "AwardedBadgeLevels"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.EquippedBadgeSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.EquippedBadgeSettings.Parser,
                        new[] {"EquipBadgeCooldownMs", "CatchProbabilityBonus", "FleeProbabilityBonus"}, null, null,
                        null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.PokemonUpgradeSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.PokemonUpgradeSettings.Parser,
                        new[] {"UpgradesPerLevel", "AllowedLevelsAbovePlayer", "CandyCost", "StardustCost"}, null, null,
                        null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.IapSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.IapSettings.Parser,
                        new[]
                        {
                            "DailyBonusCoins", "DailyDefenderBonusPerPokemon", "DailyDefenderBonusMaxDefenders",
                            "DailyDefenderBonusCurrency", "MinTimeBetweenClaimsMs", "DailyBonusEnabled",
                            "DailyDefenderBonusEnabled"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.IapItemDisplay),
                        global::PokeGodar.WebAPI.GeneratedCode.IapItemDisplay.Parser,
                        new[] {"Sku", "Category", "SortOrder", "ItemIds", "Counts"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.EncounterSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.EncounterSettings.Parser,
                        new[]
                        {
                            "SpinBonusThreshold", "ExcellentThrowThreshold", "GreatThrowThreshold", "NiceThrowThreshold",
                            "MilestoneThreshold"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.GymBattleSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.GymBattleSettings.Parser,
                        new[]
                        {
                            "EnergyPerSec", "DodgeEnergyCost", "RetargetSeconds", "EnemyAttackInterval",
                            "AttackServerInterval", "RoundDurationSeconds", "BonusTimePerAllySeconds",
                            "MaximumAttackersPerBattle", "SameTypeAttackBonusMultiplier", "MaximumEnergy",
                            "EnergyDeltaPerHealthLost", "DodgeDurationMs", "MinimumPlayerLevel", "SwapDurationMs"
                        }, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.GymLevelSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.GymLevelSettings.Parser,
                        new[] {"RequiredExperience", "LeaderSlots", "TrainerSlots", "SearchRollBonus"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.PlayerLevelSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.PlayerLevelSettings.Parser,
                        new[]
                        {
                            "RankNum", "RequiredExperience", "CpMultiplier", "MaxEggPlayerLevel", "MaxEncounterPlayerLevel"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.CameraSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.CameraSettings.Parser,
                        new[]
                        {
                            "NextCamera", "Interpolation", "TargetType", "EaseInSpeed", "EastOutSpeed", "DurationSeconds",
                            "WaitSeconds", "TransitionSeconds", "AngleDegree", "AngleOffsetDegree", "PitchDegree",
                            "PitchOffsetDegree", "RollDegree", "DistanceMeters", "HeightPercent", "VertCtrRatio"
                        }, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.BadgeSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.BadgeSettings.Parser,
                        new[] {"BadgeType", "BadgeRank", "Targets"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.TypeEffectiveSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.TypeEffectiveSettings.Parser,
                        new[] {"AttackScalar", "AttackType"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.MoveSequenceSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.MoveSequenceSettings.Parser, new[] {"Sequence"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.MoveSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.MoveSettings.Parser,
                        new[]
                        {
                            "MovementId", "AnimationId", "PokemonType", "Power", "AccuracyChance", "CriticalChance",
                            "HealScalar", "StaminaLossScalar", "TrainerLevelMin", "TrainerLevelMax", "VfxName",
                            "DurationMs", "DamageWindowStartMs", "DamageWindowEndMs", "EnergyDelta"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PokemonSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.PokemonSettings.Parser,
                        new[]
                        {
                            "PokemonId", "ModelScale", "Type", "Type2", "Camera", "Encounter", "Stats", "QuickMoves",
                            "CinematicMoves", "AnimationTime", "EvolutionIds", "EvolutionPips", "Class",
                            "PokedexHeightM", "PokedexWeightKg", "ParentPokemonId", "HeightStdDev", "WeightStdDev",
                            "KmDistanceToHatch", "FamilyId", "CandyToEvolve"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.CameraAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.CameraAttributes.Parser,
                        new[]
                        {"DiskRadiusM", "CylinderRadiusM", "CylinderHeightM", "CylinderGroundM", "ShoulderModeScale"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.EncounterAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.EncounterAttributes.Parser,
                        new[]
                        {
                            "BaseCaptureRate", "BaseFleeRate", "CollisionRadiusM", "CollisionHeightM",
                            "CollisionHeadRadiusM", "MovementType", "MovementTimerS", "JumpTimeS", "AttackTimerS"
                        }, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.StatsAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.StatsAttributes.Parser,
                        new[] {"BaseStamina", "BaseAttack", "BaseDefense", "DodgeEnergyDelta"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.ItemSettings),
                        global::PokeGodar.WebAPI.GeneratedCode.ItemSettings.Parser,
                        new[]
                        {
                            "ItemId", "ItemType", "Category", "DropFreq", "DropTrainerLevel", "Pokeball", "Potion",
                            "Revive", "Battle", "Food", "InventoryUpgrade", "XpBoost", "Incense", "EggIncubator",
                            "FortModifier"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.BattleAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.BattleAttributes.Parser, new[] {"StaPercent"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.EggIncubatorAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.EggIncubatorAttributes.Parser,
                        new[] {"IncubatorType", "Uses", "DistanceMultiplier"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.ExperienceBoostAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.ExperienceBoostAttributes.Parser,
                        new[] {"XpMultiplier", "BoostDurationMs"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.FoodAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.FoodAttributes.Parser,
                        new[] {"ItemEffect", "ItemEffectPercent", "GrowthPercent"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.FortModifierAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.FortModifierAttributes.Parser,
                        new[] {"ModifierLifetimeSeconds", "TroyDiskNumPokemonSpawned"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.IncenseAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.IncenseAttributes.Parser,
                        new[]
                        {
                            "IncenseLifetimeSeconds", "PokemonType", "PokemonIncenseTypeProbability",
                            "StandingTimeBetweenEncountersSeconds", "MovingTimeBetweenEncounterSeconds",
                            "DistanceRequiredForShorterIntervalMeters", "PokemonAttractedLengthSec"
                        }, null, null, null),
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgradeAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgradeAttributes.Parser,
                        new[] {"AdditionalStorage", "UpgradeType"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PokeballAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.PokeballAttributes.Parser,
                        new[] {"ItemEffect", "CaptureMulti", "CaptureMultiEffect", "ItemEffectMod"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.PotionAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.PotionAttributes.Parser,
                        new[] {"StaPercent", "StaAmount"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.ReviveAttributes),
                        global::PokeGodar.WebAPI.GeneratedCode.ReviveAttributes.Parser, new[] {"StaPercent"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.TransferPokemon),
                        global::PokeGodar.WebAPI.GeneratedCode.TransferPokemon.Parser, new[] {"PokemonId"}, null,
                        null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.TransferPokemonOut),
                        global::PokeGodar.WebAPI.GeneratedCode.TransferPokemonOut.Parser,
                        new[] {"Status", "CandyAwarded"}, null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.EvolvePokemon),
                        global::PokeGodar.WebAPI.GeneratedCode.EvolvePokemon.Parser, new[] {"PokemonId"}, null, null,
                        null),
                    new pbr::GeneratedClrTypeInfo(typeof(global::PokeGodar.WebAPI.GeneratedCode.EvolvePokemonOut),
                        global::PokeGodar.WebAPI.GeneratedCode.EvolvePokemonOut.Parser,
                        new[] {"Result", "EvolvedPokemon", "ExpAwarded", "CandyAwarded"}, null, null, null)
                }));
        }

        #endregion
    }

    #region Messages

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GetPlayerResponse : pb::IMessage<GetPlayerResponse>
    {
        /// <summary>Field number for the "unknown1" field.</summary>
        public const int Unknown1FieldNumber = 1;

        /// <summary>Field number for the "profile" field.</summary>
        public const int ProfileFieldNumber = 2;

        private static readonly pb::MessageParser<GetPlayerResponse> _parser =
            new pb::MessageParser<GetPlayerResponse>(() => new GetPlayerResponse());

        private global::PokeGodar.WebAPI.GeneratedCode.Profile profile_;
        private int unknown1_;

        public GetPlayerResponse()
        {
            OnConstruction();
        }

        public GetPlayerResponse(GetPlayerResponse other) : this()
        {
            unknown1_ = other.unknown1_;
            Profile = other.profile_ != null ? other.Profile.Clone() : null;
        }

        public static pb::MessageParser<GetPlayerResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[0]; }
        }

        public int Unknown1
        {
            get { return unknown1_; }
            set { unknown1_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.Profile Profile
        {
            get { return profile_; }
            set { profile_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetPlayerResponse Clone()
        {
            return new GetPlayerResponse(this);
        }

        public bool Equals(GetPlayerResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Unknown1 != other.Unknown1) return false;
            if (!Equals(Profile, other.Profile)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Unknown1 != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Unknown1);
            }
            if (profile_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Profile);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Unknown1 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown1);
            }
            if (profile_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Profile);
            }
            return size;
        }

        public void MergeFrom(GetPlayerResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Unknown1 != 0)
            {
                Unknown1 = other.Unknown1;
            }
            if (other.profile_ != null)
            {
                if (profile_ == null)
                {
                    profile_ = new global::PokeGodar.WebAPI.GeneratedCode.Profile();
                }
                Profile.MergeFrom(other.Profile);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Unknown1 = input.ReadInt32();
                            break;
                        }
                    case 18:
                        {
                            if (profile_ == null)
                            {
                                profile_ = new global::PokeGodar.WebAPI.GeneratedCode.Profile();
                            }
                            input.ReadMessage(profile_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GetPlayerResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Unknown1 != 0) hash ^= Unknown1.GetHashCode();
            if (profile_ != null) hash ^= Profile.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Profile : pb::IMessage<Profile>
    {
        /// <summary>Field number for the "creation_time" field.</summary>
        public const int CreationTimeFieldNumber = 1;

        /// <summary>Field number for the "username" field.</summary>
        public const int UsernameFieldNumber = 2;

        /// <summary>Field number for the "team" field.</summary>
        public const int TeamFieldNumber = 5;

        /// <summary>Field number for the "tutorial" field.</summary>
        public const int TutorialFieldNumber = 7;

        /// <summary>Field number for the "avatar" field.</summary>
        public const int AvatarFieldNumber = 8;

        /// <summary>Field number for the "poke_storage" field.</summary>
        public const int PokeStorageFieldNumber = 9;

        /// <summary>Field number for the "item_storage" field.</summary>
        public const int ItemStorageFieldNumber = 10;

        /// <summary>Field number for the "daily_bonus" field.</summary>
        public const int DailyBonusFieldNumber = 11;

        /// <summary>Field number for the "unknown12" field.</summary>
        public const int Unknown12FieldNumber = 12;

        /// <summary>Field number for the "unknown13" field.</summary>
        public const int Unknown13FieldNumber = 13;

        /// <summary>Field number for the "currency" field.</summary>
        public const int CurrencyFieldNumber = 14;

        private static readonly pb::MessageParser<Profile> _parser = new pb::MessageParser<Profile>(() => new Profile());

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.Currency>
            _repeated_currency_codec
                = pb::FieldCodec.ForMessage(114, global::PokeGodar.WebAPI.GeneratedCode.Currency.Parser);

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.Currency> currency_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.Currency>();

        private global::PokeGodar.WebAPI.GeneratedCode.AvatarDetails avatar_;
        private long creationTime_;
        private global::PokeGodar.WebAPI.GeneratedCode.DailyBonus dailyBonus_;
        private int itemStorage_;
        private int pokeStorage_;
        private global::AllEnum.TeamColor team_ = 0;
        private pb::ByteString tutorial_ = pb::ByteString.Empty;
        private pb::ByteString unknown12_ = pb::ByteString.Empty;
        private pb::ByteString unknown13_ = pb::ByteString.Empty;
        private string username_ = "";

        public Profile()
        {
            OnConstruction();
        }

        public Profile(Profile other) : this()
        {
            creationTime_ = other.creationTime_;
            username_ = other.username_;
            team_ = other.team_;
            tutorial_ = other.tutorial_;
            Avatar = other.avatar_ != null ? other.Avatar.Clone() : null;
            pokeStorage_ = other.pokeStorage_;
            itemStorage_ = other.itemStorage_;
            DailyBonus = other.dailyBonus_ != null ? other.DailyBonus.Clone() : null;
            unknown12_ = other.unknown12_;
            unknown13_ = other.unknown13_;
            currency_ = other.currency_.Clone();
        }

        public static pb::MessageParser<Profile> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[1]; }
        }

        public long CreationTime
        {
            get { return creationTime_; }
            set { creationTime_ = value; }
        }

        public string Username
        {
            get { return username_; }
            set { username_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::AllEnum.TeamColor Team
        {
            get { return team_; }
            set { team_ = value; }
        }

        public pb::ByteString Tutorial
        {
            get { return tutorial_; }
            set { tutorial_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.AvatarDetails Avatar
        {
            get { return avatar_; }
            set { avatar_ = value; }
        }

        public int PokeStorage
        {
            get { return pokeStorage_; }
            set { pokeStorage_ = value; }
        }

        public int ItemStorage
        {
            get { return itemStorage_; }
            set { itemStorage_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.DailyBonus DailyBonus
        {
            get { return dailyBonus_; }
            set { dailyBonus_ = value; }
        }

        public pb::ByteString Unknown12
        {
            get { return unknown12_; }
            set { unknown12_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public pb::ByteString Unknown13
        {
            get { return unknown13_; }
            set { unknown13_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.Currency> Currency
        {
            get { return currency_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Profile Clone()
        {
            return new Profile(this);
        }

        public bool Equals(Profile other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (CreationTime != other.CreationTime) return false;
            if (Username != other.Username) return false;
            if (Team != other.Team) return false;
            if (Tutorial != other.Tutorial) return false;
            if (!Equals(Avatar, other.Avatar)) return false;
            if (PokeStorage != other.PokeStorage) return false;
            if (ItemStorage != other.ItemStorage) return false;
            if (!Equals(DailyBonus, other.DailyBonus)) return false;
            if (Unknown12 != other.Unknown12) return false;
            if (Unknown13 != other.Unknown13) return false;
            if (!currency_.Equals(other.currency_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (CreationTime != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(CreationTime);
            }
            if (Username.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Username);
            }
            if (Team != 0)
            {
                output.WriteRawTag(40);
                output.WriteEnum((int)Team);
            }
            if (Tutorial.Length != 0)
            {
                output.WriteRawTag(58);
                output.WriteBytes(Tutorial);
            }
            if (avatar_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(Avatar);
            }
            if (PokeStorage != 0)
            {
                output.WriteRawTag(72);
                output.WriteInt32(PokeStorage);
            }
            if (ItemStorage != 0)
            {
                output.WriteRawTag(80);
                output.WriteInt32(ItemStorage);
            }
            if (dailyBonus_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(DailyBonus);
            }
            if (Unknown12.Length != 0)
            {
                output.WriteRawTag(98);
                output.WriteBytes(Unknown12);
            }
            if (Unknown13.Length != 0)
            {
                output.WriteRawTag(106);
                output.WriteBytes(Unknown13);
            }
            currency_.WriteTo(output, _repeated_currency_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (CreationTime != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(CreationTime);
            }
            if (Username.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
            }
            if (Team != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Team);
            }
            if (Tutorial.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(Tutorial);
            }
            if (avatar_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
            }
            if (PokeStorage != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeStorage);
            }
            if (ItemStorage != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemStorage);
            }
            if (dailyBonus_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyBonus);
            }
            if (Unknown12.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown12);
            }
            if (Unknown13.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown13);
            }
            size += currency_.CalculateSize(_repeated_currency_codec);
            return size;
        }

        public void MergeFrom(Profile other)
        {
            if (other == null)
            {
                return;
            }
            if (other.CreationTime != 0L)
            {
                CreationTime = other.CreationTime;
            }
            if (other.Username.Length != 0)
            {
                Username = other.Username;
            }
            if (other.Team != 0)
            {
                Team = other.Team;
            }
            if (other.Tutorial.Length != 0)
            {
                Tutorial = other.Tutorial;
            }
            if (other.avatar_ != null)
            {
                if (avatar_ == null)
                {
                    avatar_ = new global::PokeGodar.WebAPI.GeneratedCode.AvatarDetails();
                }
                Avatar.MergeFrom(other.Avatar);
            }
            if (other.PokeStorage != 0)
            {
                PokeStorage = other.PokeStorage;
            }
            if (other.ItemStorage != 0)
            {
                ItemStorage = other.ItemStorage;
            }
            if (other.dailyBonus_ != null)
            {
                if (dailyBonus_ == null)
                {
                    dailyBonus_ = new global::PokeGodar.WebAPI.GeneratedCode.DailyBonus();
                }
                DailyBonus.MergeFrom(other.DailyBonus);
            }
            if (other.Unknown12.Length != 0)
            {
                Unknown12 = other.Unknown12;
            }
            if (other.Unknown13.Length != 0)
            {
                Unknown13 = other.Unknown13;
            }
            currency_.Add(other.currency_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            CreationTime = input.ReadInt64();
                            break;
                        }
                    case 18:
                        {
                            Username = input.ReadString();
                            break;
                        }
                    case 40:
                        {
                            team_ = (global::AllEnum.TeamColor)input.ReadEnum();
                            break;
                        }
                    case 58:
                        {
                            Tutorial = input.ReadBytes();
                            break;
                        }
                    case 66:
                        {
                            if (avatar_ == null)
                            {
                                avatar_ = new global::PokeGodar.WebAPI.GeneratedCode.AvatarDetails();
                            }
                            input.ReadMessage(avatar_);
                            break;
                        }
                    case 72:
                        {
                            PokeStorage = input.ReadInt32();
                            break;
                        }
                    case 80:
                        {
                            ItemStorage = input.ReadInt32();
                            break;
                        }
                    case 90:
                        {
                            if (dailyBonus_ == null)
                            {
                                dailyBonus_ = new global::PokeGodar.WebAPI.GeneratedCode.DailyBonus();
                            }
                            input.ReadMessage(dailyBonus_);
                            break;
                        }
                    case 98:
                        {
                            Unknown12 = input.ReadBytes();
                            break;
                        }
                    case 106:
                        {
                            Unknown13 = input.ReadBytes();
                            break;
                        }
                    case 114:
                        {
                            currency_.AddEntriesFrom(input, _repeated_currency_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as Profile);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (CreationTime != 0L) hash ^= CreationTime.GetHashCode();
            if (Username.Length != 0) hash ^= Username.GetHashCode();
            if (Team != 0) hash ^= Team.GetHashCode();
            if (Tutorial.Length != 0) hash ^= Tutorial.GetHashCode();
            if (avatar_ != null) hash ^= Avatar.GetHashCode();
            if (PokeStorage != 0) hash ^= PokeStorage.GetHashCode();
            if (ItemStorage != 0) hash ^= ItemStorage.GetHashCode();
            if (dailyBonus_ != null) hash ^= DailyBonus.GetHashCode();
            if (Unknown12.Length != 0) hash ^= Unknown12.GetHashCode();
            if (Unknown13.Length != 0) hash ^= Unknown13.GetHashCode();
            hash ^= currency_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class DailyBonus : pb::IMessage<DailyBonus>
    {
        /// <summary>Field number for the "NextCollectTimestampMs" field.</summary>
        public const int NextCollectTimestampMsFieldNumber = 1;

        /// <summary>Field number for the "NextDefenderBonusCollectTimestampMs" field.</summary>
        public const int NextDefenderBonusCollectTimestampMsFieldNumber = 2;

        private static readonly pb::MessageParser<DailyBonus> _parser =
            new pb::MessageParser<DailyBonus>(() => new DailyBonus());

        private long nextCollectTimestampMs_;
        private long nextDefenderBonusCollectTimestampMs_;

        public DailyBonus()
        {
            OnConstruction();
        }

        public DailyBonus(DailyBonus other) : this()
        {
            nextCollectTimestampMs_ = other.nextCollectTimestampMs_;
            nextDefenderBonusCollectTimestampMs_ = other.nextDefenderBonusCollectTimestampMs_;
        }

        public static pb::MessageParser<DailyBonus> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[2]; }
        }

        public long NextCollectTimestampMs
        {
            get { return nextCollectTimestampMs_; }
            set { nextCollectTimestampMs_ = value; }
        }

        public long NextDefenderBonusCollectTimestampMs
        {
            get { return nextDefenderBonusCollectTimestampMs_; }
            set { nextDefenderBonusCollectTimestampMs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DailyBonus Clone()
        {
            return new DailyBonus(this);
        }

        public bool Equals(DailyBonus other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (NextCollectTimestampMs != other.NextCollectTimestampMs) return false;
            if (NextDefenderBonusCollectTimestampMs != other.NextDefenderBonusCollectTimestampMs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (NextCollectTimestampMs != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(NextCollectTimestampMs);
            }
            if (NextDefenderBonusCollectTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(NextDefenderBonusCollectTimestampMs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (NextCollectTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextCollectTimestampMs);
            }
            if (NextDefenderBonusCollectTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextDefenderBonusCollectTimestampMs);
            }
            return size;
        }

        public void MergeFrom(DailyBonus other)
        {
            if (other == null)
            {
                return;
            }
            if (other.NextCollectTimestampMs != 0L)
            {
                NextCollectTimestampMs = other.NextCollectTimestampMs;
            }
            if (other.NextDefenderBonusCollectTimestampMs != 0L)
            {
                NextDefenderBonusCollectTimestampMs = other.NextDefenderBonusCollectTimestampMs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            NextCollectTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 16:
                        {
                            NextDefenderBonusCollectTimestampMs = input.ReadInt64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as DailyBonus);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (NextCollectTimestampMs != 0L) hash ^= NextCollectTimestampMs.GetHashCode();
            if (NextDefenderBonusCollectTimestampMs != 0L) hash ^= NextDefenderBonusCollectTimestampMs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Currency : pb::IMessage<Currency>
    {
        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 1;

        /// <summary>Field number for the "amount" field.</summary>
        public const int AmountFieldNumber = 2;

        private static readonly pb::MessageParser<Currency> _parser =
            new pb::MessageParser<Currency>(() => new Currency());

        private int amount_;
        private string type_ = "";

        public Currency()
        {
            OnConstruction();
        }

        public Currency(Currency other) : this()
        {
            type_ = other.type_;
            amount_ = other.amount_;
        }

        public static pb::MessageParser<Currency> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[3]; }
        }

        public string Type
        {
            get { return type_; }
            set { type_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public int Amount
        {
            get { return amount_; }
            set { amount_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Currency Clone()
        {
            return new Currency(this);
        }

        public bool Equals(Currency other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Type != other.Type) return false;
            if (Amount != other.Amount) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Type.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Type);
            }
            if (Amount != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Amount);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Type.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
            }
            if (Amount != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
            }
            return size;
        }

        public void MergeFrom(Currency other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Type.Length != 0)
            {
                Type = other.Type;
            }
            if (other.Amount != 0)
            {
                Amount = other.Amount;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            Type = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            Amount = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as Currency);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Type.Length != 0) hash ^= Type.GetHashCode();
            if (Amount != 0) hash ^= Amount.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class AvatarDetails : pb::IMessage<AvatarDetails>
    {
        /// <summary>Field number for the "unknown2" field.</summary>
        public const int Unknown2FieldNumber = 2;

        /// <summary>Field number for the "unknown3" field.</summary>
        public const int Unknown3FieldNumber = 3;

        /// <summary>Field number for the "unknown9" field.</summary>
        public const int Unknown9FieldNumber = 9;

        /// <summary>Field number for the "unknown10" field.</summary>
        public const int Unknown10FieldNumber = 10;

        private static readonly pb::MessageParser<AvatarDetails> _parser =
            new pb::MessageParser<AvatarDetails>(() => new AvatarDetails());

        private int unknown10_;
        private int unknown2_;
        private int unknown3_;
        private int unknown9_;

        public AvatarDetails()
        {
            OnConstruction();
        }

        public AvatarDetails(AvatarDetails other) : this()
        {
            unknown2_ = other.unknown2_;
            unknown3_ = other.unknown3_;
            unknown9_ = other.unknown9_;
            unknown10_ = other.unknown10_;
        }

        public static pb::MessageParser<AvatarDetails> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[4]; }
        }

        public int Unknown2
        {
            get { return unknown2_; }
            set { unknown2_ = value; }
        }

        public int Unknown3
        {
            get { return unknown3_; }
            set { unknown3_ = value; }
        }

        public int Unknown9
        {
            get { return unknown9_; }
            set { unknown9_ = value; }
        }

        public int Unknown10
        {
            get { return unknown10_; }
            set { unknown10_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AvatarDetails Clone()
        {
            return new AvatarDetails(this);
        }

        public bool Equals(AvatarDetails other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Unknown2 != other.Unknown2) return false;
            if (Unknown3 != other.Unknown3) return false;
            if (Unknown9 != other.Unknown9) return false;
            if (Unknown10 != other.Unknown10) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Unknown2 != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Unknown2);
            }
            if (Unknown3 != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(Unknown3);
            }
            if (Unknown9 != 0)
            {
                output.WriteRawTag(72);
                output.WriteInt32(Unknown9);
            }
            if (Unknown10 != 0)
            {
                output.WriteRawTag(80);
                output.WriteInt32(Unknown10);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Unknown2 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown2);
            }
            if (Unknown3 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown3);
            }
            if (Unknown9 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown9);
            }
            if (Unknown10 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown10);
            }
            return size;
        }

        public void MergeFrom(AvatarDetails other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Unknown2 != 0)
            {
                Unknown2 = other.Unknown2;
            }
            if (other.Unknown3 != 0)
            {
                Unknown3 = other.Unknown3;
            }
            if (other.Unknown9 != 0)
            {
                Unknown9 = other.Unknown9;
            }
            if (other.Unknown10 != 0)
            {
                Unknown10 = other.Unknown10;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 16:
                        {
                            Unknown2 = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            Unknown3 = input.ReadInt32();
                            break;
                        }
                    case 72:
                        {
                            Unknown9 = input.ReadInt32();
                            break;
                        }
                    case 80:
                        {
                            Unknown10 = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as AvatarDetails);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Unknown2 != 0) hash ^= Unknown2.GetHashCode();
            if (Unknown3 != 0) hash ^= Unknown3.GetHashCode();
            if (Unknown9 != 0) hash ^= Unknown9.GetHashCode();
            if (Unknown10 != 0) hash ^= Unknown10.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class DownloadSettingsRequest : pb::IMessage<DownloadSettingsRequest>
    {
        /// <summary>Field number for the "hash" field.</summary>
        public const int HashFieldNumber = 1;

        private static readonly pb::MessageParser<DownloadSettingsRequest> _parser =
            new pb::MessageParser<DownloadSettingsRequest>(() => new DownloadSettingsRequest());

        private string hash_ = "";

        public DownloadSettingsRequest()
        {
            OnConstruction();
        }

        public DownloadSettingsRequest(DownloadSettingsRequest other) : this()
        {
            hash_ = other.hash_;
        }

        public static pb::MessageParser<DownloadSettingsRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[5]; }
        }

        public string Hash
        {
            get { return hash_; }
            set { hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DownloadSettingsRequest Clone()
        {
            return new DownloadSettingsRequest(this);
        }

        public bool Equals(DownloadSettingsRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Hash != other.Hash) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Hash.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Hash);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Hash.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
            }
            return size;
        }

        public void MergeFrom(DownloadSettingsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Hash.Length != 0)
            {
                Hash = other.Hash;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            Hash = input.ReadString();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as DownloadSettingsRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Hash.Length != 0) hash ^= Hash.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GetInventoryResponse : pb::IMessage<GetInventoryResponse>
    {
        /// <summary>Field number for the "success" field.</summary>
        public const int SuccessFieldNumber = 1;

        /// <summary>Field number for the "inventory_delta" field.</summary>
        public const int InventoryDeltaFieldNumber = 2;

        private static readonly pb::MessageParser<GetInventoryResponse> _parser =
            new pb::MessageParser<GetInventoryResponse>(() => new GetInventoryResponse());

        private global::PokeGodar.WebAPI.GeneratedCode.InventoryDelta inventoryDelta_;
        private bool success_;

        public GetInventoryResponse()
        {
            OnConstruction();
        }

        public GetInventoryResponse(GetInventoryResponse other) : this()
        {
            success_ = other.success_;
            InventoryDelta = other.inventoryDelta_ != null ? other.InventoryDelta.Clone() : null;
        }

        public static pb::MessageParser<GetInventoryResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[6]; }
        }

        public bool Success
        {
            get { return success_; }
            set { success_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.InventoryDelta InventoryDelta
        {
            get { return inventoryDelta_; }
            set { inventoryDelta_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetInventoryResponse Clone()
        {
            return new GetInventoryResponse(this);
        }

        public bool Equals(GetInventoryResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Success != other.Success) return false;
            if (!Equals(InventoryDelta, other.InventoryDelta)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Success != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(Success);
            }
            if (inventoryDelta_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(InventoryDelta);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Success != false)
            {
                size += 1 + 1;
            }
            if (inventoryDelta_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryDelta);
            }
            return size;
        }

        public void MergeFrom(GetInventoryResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Success != false)
            {
                Success = other.Success;
            }
            if (other.inventoryDelta_ != null)
            {
                if (inventoryDelta_ == null)
                {
                    inventoryDelta_ = new global::PokeGodar.WebAPI.GeneratedCode.InventoryDelta();
                }
                InventoryDelta.MergeFrom(other.InventoryDelta);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Success = input.ReadBool();
                            break;
                        }
                    case 18:
                        {
                            if (inventoryDelta_ == null)
                            {
                                inventoryDelta_ = new global::PokeGodar.WebAPI.GeneratedCode.InventoryDelta();
                            }
                            input.ReadMessage(inventoryDelta_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GetInventoryResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Success != false) hash ^= Success.GetHashCode();
            if (inventoryDelta_ != null) hash ^= InventoryDelta.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class InventoryDelta : pb::IMessage<InventoryDelta>
    {
        /// <summary>Field number for the "original_timestamp_ms" field.</summary>
        public const int OriginalTimestampMsFieldNumber = 1;

        /// <summary>Field number for the "new_timestamp_ms" field.</summary>
        public const int NewTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "inventory_items" field.</summary>
        public const int InventoryItemsFieldNumber = 3;

        private static readonly pb::MessageParser<InventoryDelta> _parser =
            new pb::MessageParser<InventoryDelta>(() => new InventoryDelta());

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.InventoryItem>
            _repeated_inventoryItems_codec
                = pb::FieldCodec.ForMessage(26, global::PokeGodar.WebAPI.GeneratedCode.InventoryItem.Parser);

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.InventoryItem> inventoryItems_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.InventoryItem>();

        private long newTimestampMs_;
        private long originalTimestampMs_;

        public InventoryDelta()
        {
            OnConstruction();
        }

        public InventoryDelta(InventoryDelta other) : this()
        {
            originalTimestampMs_ = other.originalTimestampMs_;
            newTimestampMs_ = other.newTimestampMs_;
            inventoryItems_ = other.inventoryItems_.Clone();
        }

        public static pb::MessageParser<InventoryDelta> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[7]; }
        }

        public long OriginalTimestampMs
        {
            get { return originalTimestampMs_; }
            set { originalTimestampMs_ = value; }
        }

        public long NewTimestampMs
        {
            get { return newTimestampMs_; }
            set { newTimestampMs_ = value; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.InventoryItem> InventoryItems
        {
            get { return inventoryItems_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InventoryDelta Clone()
        {
            return new InventoryDelta(this);
        }

        public bool Equals(InventoryDelta other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (OriginalTimestampMs != other.OriginalTimestampMs) return false;
            if (NewTimestampMs != other.NewTimestampMs) return false;
            if (!inventoryItems_.Equals(other.inventoryItems_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (OriginalTimestampMs != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(OriginalTimestampMs);
            }
            if (NewTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(NewTimestampMs);
            }
            inventoryItems_.WriteTo(output, _repeated_inventoryItems_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (OriginalTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(OriginalTimestampMs);
            }
            if (NewTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(NewTimestampMs);
            }
            size += inventoryItems_.CalculateSize(_repeated_inventoryItems_codec);
            return size;
        }

        public void MergeFrom(InventoryDelta other)
        {
            if (other == null)
            {
                return;
            }
            if (other.OriginalTimestampMs != 0L)
            {
                OriginalTimestampMs = other.OriginalTimestampMs;
            }
            if (other.NewTimestampMs != 0L)
            {
                NewTimestampMs = other.NewTimestampMs;
            }
            inventoryItems_.Add(other.inventoryItems_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            OriginalTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 16:
                        {
                            NewTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 26:
                        {
                            inventoryItems_.AddEntriesFrom(input, _repeated_inventoryItems_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as InventoryDelta);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (OriginalTimestampMs != 0L) hash ^= OriginalTimestampMs.GetHashCode();
            if (NewTimestampMs != 0L) hash ^= NewTimestampMs.GetHashCode();
            hash ^= inventoryItems_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class InventoryItem : pb::IMessage<InventoryItem>
    {
        /// <summary>Field number for the "modified_timestamp_ms" field.</summary>
        public const int ModifiedTimestampMsFieldNumber = 1;

        /// <summary>Field number for the "deleted_item_key" field.</summary>
        public const int DeletedItemKeyFieldNumber = 2;

        /// <summary>Field number for the "inventory_item_data" field.</summary>
        public const int InventoryItemDataFieldNumber = 3;

        private static readonly pb::MessageParser<InventoryItem> _parser =
            new pb::MessageParser<InventoryItem>(() => new InventoryItem());

        private long deletedItemKey_;
        private global::PokeGodar.WebAPI.GeneratedCode.InventoryItemData inventoryItemData_;
        private long modifiedTimestampMs_;

        public InventoryItem()
        {
            OnConstruction();
        }

        public InventoryItem(InventoryItem other) : this()
        {
            modifiedTimestampMs_ = other.modifiedTimestampMs_;
            deletedItemKey_ = other.deletedItemKey_;
            InventoryItemData = other.inventoryItemData_ != null ? other.InventoryItemData.Clone() : null;
        }

        public static pb::MessageParser<InventoryItem> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[8]; }
        }

        public long ModifiedTimestampMs
        {
            get { return modifiedTimestampMs_; }
            set { modifiedTimestampMs_ = value; }
        }

        public long DeletedItemKey
        {
            get { return deletedItemKey_; }
            set { deletedItemKey_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.InventoryItemData InventoryItemData
        {
            get { return inventoryItemData_; }
            set { inventoryItemData_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InventoryItem Clone()
        {
            return new InventoryItem(this);
        }

        public bool Equals(InventoryItem other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ModifiedTimestampMs != other.ModifiedTimestampMs) return false;
            if (DeletedItemKey != other.DeletedItemKey) return false;
            if (!Equals(InventoryItemData, other.InventoryItemData)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ModifiedTimestampMs != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(ModifiedTimestampMs);
            }
            if (DeletedItemKey != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(DeletedItemKey);
            }
            if (inventoryItemData_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(InventoryItemData);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ModifiedTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(ModifiedTimestampMs);
            }
            if (DeletedItemKey != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(DeletedItemKey);
            }
            if (inventoryItemData_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryItemData);
            }
            return size;
        }

        public void MergeFrom(InventoryItem other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ModifiedTimestampMs != 0L)
            {
                ModifiedTimestampMs = other.ModifiedTimestampMs;
            }
            if (other.DeletedItemKey != 0L)
            {
                DeletedItemKey = other.DeletedItemKey;
            }
            if (other.inventoryItemData_ != null)
            {
                if (inventoryItemData_ == null)
                {
                    inventoryItemData_ = new global::PokeGodar.WebAPI.GeneratedCode.InventoryItemData();
                }
                InventoryItemData.MergeFrom(other.InventoryItemData);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            ModifiedTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 16:
                        {
                            DeletedItemKey = input.ReadInt64();
                            break;
                        }
                    case 26:
                        {
                            if (inventoryItemData_ == null)
                            {
                                inventoryItemData_ = new global::PokeGodar.WebAPI.GeneratedCode.InventoryItemData();
                            }
                            input.ReadMessage(inventoryItemData_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as InventoryItem);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ModifiedTimestampMs != 0L) hash ^= ModifiedTimestampMs.GetHashCode();
            if (DeletedItemKey != 0L) hash ^= DeletedItemKey.GetHashCode();
            if (inventoryItemData_ != null) hash ^= InventoryItemData.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class InventoryItemData : pb::IMessage<InventoryItemData>
    {
        /// <summary>Field number for the "pokemon" field.</summary>
        public const int PokemonFieldNumber = 1;

        /// <summary>Field number for the "item" field.</summary>
        public const int ItemFieldNumber = 2;

        /// <summary>Field number for the "pokedex_entry" field.</summary>
        public const int PokedexEntryFieldNumber = 3;

        /// <summary>Field number for the "player_stats" field.</summary>
        public const int PlayerStatsFieldNumber = 4;

        /// <summary>Field number for the "player_currency" field.</summary>
        public const int PlayerCurrencyFieldNumber = 5;

        /// <summary>Field number for the "player_camera" field.</summary>
        public const int PlayerCameraFieldNumber = 6;

        /// <summary>Field number for the "inventory_upgrades" field.</summary>
        public const int InventoryUpgradesFieldNumber = 7;

        /// <summary>Field number for the "applied_items" field.</summary>
        public const int AppliedItemsFieldNumber = 8;

        /// <summary>Field number for the "egg_incubators" field.</summary>
        public const int EggIncubatorsFieldNumber = 9;

        /// <summary>Field number for the "pokemon_family" field.</summary>
        public const int PokemonFamilyFieldNumber = 10;

        private static readonly pb::MessageParser<InventoryItemData> _parser =
            new pb::MessageParser<InventoryItemData>(() => new InventoryItemData());

        private global::PokeGodar.WebAPI.GeneratedCode.AppliedItems appliedItems_;
        private global::PokeGodar.WebAPI.GeneratedCode.EggIncubators eggIncubators_;
        private global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrades inventoryUpgrades_;
        private global::PokeGodar.WebAPI.GeneratedCode.Item item_;
        private global::PokeGodar.WebAPI.GeneratedCode.PlayerCamera playerCamera_;
        private global::PokeGodar.WebAPI.GeneratedCode.PlayerCurrency playerCurrency_;
        private global::PokeGodar.WebAPI.GeneratedCode.PlayerStats playerStats_;
        private global::PokeGodar.WebAPI.GeneratedCode.PokedexEntry pokedexEntry_;
        private global::PokeGodar.WebAPI.GeneratedCode.PokemonData pokemon_;
        private global::PokeGodar.WebAPI.GeneratedCode.PokemonFamily pokemonFamily_;

        public InventoryItemData()
        {
            OnConstruction();
        }

        public InventoryItemData(InventoryItemData other) : this()
        {
            Pokemon = other.pokemon_ != null ? other.Pokemon.Clone() : null;
            Item = other.item_ != null ? other.Item.Clone() : null;
            PokedexEntry = other.pokedexEntry_ != null ? other.PokedexEntry.Clone() : null;
            PlayerStats = other.playerStats_ != null ? other.PlayerStats.Clone() : null;
            PlayerCurrency = other.playerCurrency_ != null ? other.PlayerCurrency.Clone() : null;
            PlayerCamera = other.playerCamera_ != null ? other.PlayerCamera.Clone() : null;
            InventoryUpgrades = other.inventoryUpgrades_ != null ? other.InventoryUpgrades.Clone() : null;
            AppliedItems = other.appliedItems_ != null ? other.AppliedItems.Clone() : null;
            EggIncubators = other.eggIncubators_ != null ? other.EggIncubators.Clone() : null;
            PokemonFamily = other.pokemonFamily_ != null ? other.PokemonFamily.Clone() : null;
        }

        public static pb::MessageParser<InventoryItemData> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[9]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokemonData Pokemon
        {
            get { return pokemon_; }
            set { pokemon_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.Item Item
        {
            get { return item_; }
            set { item_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokedexEntry PokedexEntry
        {
            get { return pokedexEntry_; }
            set { pokedexEntry_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PlayerStats PlayerStats
        {
            get { return playerStats_; }
            set { playerStats_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PlayerCurrency PlayerCurrency
        {
            get { return playerCurrency_; }
            set { playerCurrency_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PlayerCamera PlayerCamera
        {
            get { return playerCamera_; }
            set { playerCamera_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrades InventoryUpgrades
        {
            get { return inventoryUpgrades_; }
            set { inventoryUpgrades_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.AppliedItems AppliedItems
        {
            get { return appliedItems_; }
            set { appliedItems_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.EggIncubators EggIncubators
        {
            get { return eggIncubators_; }
            set { eggIncubators_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokemonFamily PokemonFamily
        {
            get { return pokemonFamily_; }
            set { pokemonFamily_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InventoryItemData Clone()
        {
            return new InventoryItemData(this);
        }

        public bool Equals(InventoryItemData other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Pokemon, other.Pokemon)) return false;
            if (!Equals(Item, other.Item)) return false;
            if (!Equals(PokedexEntry, other.PokedexEntry)) return false;
            if (!Equals(PlayerStats, other.PlayerStats)) return false;
            if (!Equals(PlayerCurrency, other.PlayerCurrency)) return false;
            if (!Equals(PlayerCamera, other.PlayerCamera)) return false;
            if (!Equals(InventoryUpgrades, other.InventoryUpgrades)) return false;
            if (!Equals(AppliedItems, other.AppliedItems)) return false;
            if (!Equals(EggIncubators, other.EggIncubators)) return false;
            if (!Equals(PokemonFamily, other.PokemonFamily)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (pokemon_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Pokemon);
            }
            if (item_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Item);
            }
            if (pokedexEntry_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(PokedexEntry);
            }
            if (playerStats_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(PlayerStats);
            }
            if (playerCurrency_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(PlayerCurrency);
            }
            if (playerCamera_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(PlayerCamera);
            }
            if (inventoryUpgrades_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(InventoryUpgrades);
            }
            if (appliedItems_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(AppliedItems);
            }
            if (eggIncubators_ != null)
            {
                output.WriteRawTag(74);
                output.WriteMessage(EggIncubators);
            }
            if (pokemonFamily_ != null)
            {
                output.WriteRawTag(82);
                output.WriteMessage(PokemonFamily);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed partial class RecycleInventoryItem : pb::IMessage<RecycleInventoryItem>
        {
            private static readonly pb::MessageParser<RecycleInventoryItem> _parser = new pb::MessageParser<RecycleInventoryItem>(() => new RecycleInventoryItem());
            public static pb::MessageParser<RecycleInventoryItem> Parser { get { return _parser; } }

            public static pbr::MessageDescriptor Descriptor
            {
                get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[10]; }
            }

            pbr::MessageDescriptor pb::IMessage.Descriptor
            {
                get { return Descriptor; }
            }

            public RecycleInventoryItem()
            {
                OnConstruction();
            }

            partial void OnConstruction();

            public RecycleInventoryItem(RecycleInventoryItem other) : this()
            {
                itemId_ = other.itemId_;
                count_ = other.count_;
            }

            public RecycleInventoryItem Clone()
            {
                return new RecycleInventoryItem(this);
            }

            /// <summary>Field number for the "item_id" field.</summary>
            public const int ItemIdFieldNumber = 1;
            private global::AllEnum.ItemId itemId_ = 0;
            public global::AllEnum.ItemId ItemId
            {
                get { return itemId_; }
                set
                {
                    itemId_ = value;
                }
            }

            /// <summary>Field number for the "count" field.</summary>
            public const int CountFieldNumber = 2;
            private int count_;
            public int Count
            {
                get { return count_; }
                set
                {
                    count_ = value;
                }
            }

            public override bool Equals(object other)
            {
                return Equals(other as RecycleInventoryItem);
            }

            public bool Equals(RecycleInventoryItem other)
            {
                if (ReferenceEquals(other, null))
                {
                    return false;
                }
                if (ReferenceEquals(other, this))
                {
                    return true;
                }
                if (ItemId != other.ItemId) return false;
                if (Count != other.Count) return false;
                return true;
            }

            public override int GetHashCode()
            {
                int hash = 1;
                if (ItemId != 0) hash ^= ItemId.GetHashCode();
                if (Count != 0) hash ^= Count.GetHashCode();
                return hash;
            }

            public override string ToString()
            {
                return pb::JsonFormatter.ToDiagnosticString(this);
            }

            public void WriteTo(pb::CodedOutputStream output)
            {
                if (ItemId != 0)
                {
                    output.WriteRawTag(8);
                    output.WriteEnum((int)ItemId);
                }
                if (Count != 0)
                {
                    output.WriteRawTag(16);
                    output.WriteInt32(Count);
                }
            }

            public int CalculateSize()
            {
                int size = 0;
                if (ItemId != 0)
                {
                    size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
                }
                if (Count != 0)
                {
                    size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
                }
                return size;
            }

            public void MergeFrom(RecycleInventoryItem other)
            {
                if (other == null)
                {
                    return;
                }
                if (other.ItemId != 0)
                {
                    ItemId = other.ItemId;
                }
                if (other.Count != 0)
                {
                    Count = other.Count;
                }
            }

            public void MergeFrom(pb::CodedInputStream input)
            {
                uint tag;
                while ((tag = input.ReadTag()) != 0)
                {
                    switch (tag)
                    {
                        default:
                            input.SkipLastField();
                            break;
                        case 8:
                            {
                                itemId_ = (global::AllEnum.ItemId)input.ReadEnum();
                                break;
                            }
                        case 16:
                            {
                                Count = input.ReadInt32();
                                break;
                            }
                    }
                }
            }

        }

        public int CalculateSize()
        {
            var size = 0;
            if (pokemon_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pokemon);
            }
            if (item_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
            }
            if (pokedexEntry_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokedexEntry);
            }
            if (playerStats_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerStats);
            }
            if (playerCurrency_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerCurrency);
            }
            if (playerCamera_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerCamera);
            }
            if (inventoryUpgrades_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryUpgrades);
            }
            if (appliedItems_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppliedItems);
            }
            if (eggIncubators_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubators);
            }
            if (pokemonFamily_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonFamily);
            }
            return size;
        }

        public void MergeFrom(InventoryItemData other)
        {
            if (other == null)
            {
                return;
            }
            if (other.pokemon_ != null)
            {
                if (pokemon_ == null)
                {
                    pokemon_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                }
                Pokemon.MergeFrom(other.Pokemon);
            }
            if (other.item_ != null)
            {
                if (item_ == null)
                {
                    item_ = new global::PokeGodar.WebAPI.GeneratedCode.Item();
                }
                Item.MergeFrom(other.Item);
            }
            if (other.pokedexEntry_ != null)
            {
                if (pokedexEntry_ == null)
                {
                    pokedexEntry_ = new global::PokeGodar.WebAPI.GeneratedCode.PokedexEntry();
                }
                PokedexEntry.MergeFrom(other.PokedexEntry);
            }
            if (other.playerStats_ != null)
            {
                if (playerStats_ == null)
                {
                    playerStats_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerStats();
                }
                PlayerStats.MergeFrom(other.PlayerStats);
            }
            if (other.playerCurrency_ != null)
            {
                if (playerCurrency_ == null)
                {
                    playerCurrency_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerCurrency();
                }
                PlayerCurrency.MergeFrom(other.PlayerCurrency);
            }
            if (other.playerCamera_ != null)
            {
                if (playerCamera_ == null)
                {
                    playerCamera_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerCamera();
                }
                PlayerCamera.MergeFrom(other.PlayerCamera);
            }
            if (other.inventoryUpgrades_ != null)
            {
                if (inventoryUpgrades_ == null)
                {
                    inventoryUpgrades_ = new global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrades();
                }
                InventoryUpgrades.MergeFrom(other.InventoryUpgrades);
            }
            if (other.appliedItems_ != null)
            {
                if (appliedItems_ == null)
                {
                    appliedItems_ = new global::PokeGodar.WebAPI.GeneratedCode.AppliedItems();
                }
                AppliedItems.MergeFrom(other.AppliedItems);
            }
            if (other.eggIncubators_ != null)
            {
                if (eggIncubators_ == null)
                {
                    eggIncubators_ = new global::PokeGodar.WebAPI.GeneratedCode.EggIncubators();
                }
                EggIncubators.MergeFrom(other.EggIncubators);
            }
            if (other.pokemonFamily_ != null)
            {
                if (pokemonFamily_ == null)
                {
                    pokemonFamily_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonFamily();
                }
                PokemonFamily.MergeFrom(other.PokemonFamily);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            if (pokemon_ == null)
                            {
                                pokemon_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                            }
                            input.ReadMessage(pokemon_);
                            break;
                        }
                    case 18:
                        {
                            if (item_ == null)
                            {
                                item_ = new global::PokeGodar.WebAPI.GeneratedCode.Item();
                            }
                            input.ReadMessage(item_);
                            break;
                        }
                    case 26:
                        {
                            if (pokedexEntry_ == null)
                            {
                                pokedexEntry_ = new global::PokeGodar.WebAPI.GeneratedCode.PokedexEntry();
                            }
                            input.ReadMessage(pokedexEntry_);
                            break;
                        }
                    case 34:
                        {
                            if (playerStats_ == null)
                            {
                                playerStats_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerStats();
                            }
                            input.ReadMessage(playerStats_);
                            break;
                        }
                    case 42:
                        {
                            if (playerCurrency_ == null)
                            {
                                playerCurrency_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerCurrency();
                            }
                            input.ReadMessage(playerCurrency_);
                            break;
                        }
                    case 50:
                        {
                            if (playerCamera_ == null)
                            {
                                playerCamera_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerCamera();
                            }
                            input.ReadMessage(playerCamera_);
                            break;
                        }
                    case 58:
                        {
                            if (inventoryUpgrades_ == null)
                            {
                                inventoryUpgrades_ = new global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrades();
                            }
                            input.ReadMessage(inventoryUpgrades_);
                            break;
                        }
                    case 66:
                        {
                            if (appliedItems_ == null)
                            {
                                appliedItems_ = new global::PokeGodar.WebAPI.GeneratedCode.AppliedItems();
                            }
                            input.ReadMessage(appliedItems_);
                            break;
                        }
                    case 74:
                        {
                            if (eggIncubators_ == null)
                            {
                                eggIncubators_ = new global::PokeGodar.WebAPI.GeneratedCode.EggIncubators();
                            }
                            input.ReadMessage(eggIncubators_);
                            break;
                        }
                    case 82:
                        {
                            if (pokemonFamily_ == null)
                            {
                                pokemonFamily_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonFamily();
                            }
                            input.ReadMessage(pokemonFamily_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as InventoryItemData);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (pokemon_ != null) hash ^= Pokemon.GetHashCode();
            if (item_ != null) hash ^= Item.GetHashCode();
            if (pokedexEntry_ != null) hash ^= PokedexEntry.GetHashCode();
            if (playerStats_ != null) hash ^= PlayerStats.GetHashCode();
            if (playerCurrency_ != null) hash ^= PlayerCurrency.GetHashCode();
            if (playerCamera_ != null) hash ^= PlayerCamera.GetHashCode();
            if (inventoryUpgrades_ != null) hash ^= InventoryUpgrades.GetHashCode();
            if (appliedItems_ != null) hash ^= AppliedItems.GetHashCode();
            if (eggIncubators_ != null) hash ^= EggIncubators.GetHashCode();
            if (pokemonFamily_ != null) hash ^= PokemonFamily.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Pokemon : pb::IMessage<Pokemon>
    {
        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;

        /// <summary>Field number for the "pokemon_type" field.</summary>
        public const int PokemonTypeFieldNumber = 2;

        /// <summary>Field number for the "cp" field.</summary>
        public const int CpFieldNumber = 3;

        /// <summary>Field number for the "stamina" field.</summary>
        public const int StaminaFieldNumber = 4;

        /// <summary>Field number for the "stamina_max" field.</summary>
        public const int StaminaMaxFieldNumber = 5;

        /// <summary>Field number for the "move_1" field.</summary>
        public const int Move1FieldNumber = 6;

        /// <summary>Field number for the "move_2" field.</summary>
        public const int Move2FieldNumber = 7;

        /// <summary>Field number for the "deployed_fort_id" field.</summary>
        public const int DeployedFortIdFieldNumber = 8;

        /// <summary>Field number for the "owner_name" field.</summary>
        public const int OwnerNameFieldNumber = 9;

        /// <summary>Field number for the "is_egg" field.</summary>
        public const int IsEggFieldNumber = 10;

        /// <summary>Field number for the "egg_km_walked_target" field.</summary>
        public const int EggKmWalkedTargetFieldNumber = 11;

        /// <summary>Field number for the "egg_km_walked_start" field.</summary>
        public const int EggKmWalkedStartFieldNumber = 12;

        /// <summary>Field number for the "origin" field.</summary>
        public const int OriginFieldNumber = 14;

        /// <summary>Field number for the "height_m" field.</summary>
        public const int HeightMFieldNumber = 15;

        /// <summary>Field number for the "weight_kg" field.</summary>
        public const int WeightKgFieldNumber = 16;

        /// <summary>Field number for the "individual_attack" field.</summary>
        public const int IndividualAttackFieldNumber = 17;

        /// <summary>Field number for the "individual_defense" field.</summary>
        public const int IndividualDefenseFieldNumber = 18;

        /// <summary>Field number for the "individual_stamina" field.</summary>
        public const int IndividualStaminaFieldNumber = 19;

        /// <summary>Field number for the "cp_multiplier" field.</summary>
        public const int CpMultiplierFieldNumber = 20;

        /// <summary>Field number for the "pokeball" field.</summary>
        public const int PokeballFieldNumber = 21;

        /// <summary>Field number for the "captured_cell_id" field.</summary>
        public const int CapturedCellIdFieldNumber = 22;

        /// <summary>Field number for the "battles_attacked" field.</summary>
        public const int BattlesAttackedFieldNumber = 23;

        /// <summary>Field number for the "battles_defended" field.</summary>
        public const int BattlesDefendedFieldNumber = 24;

        /// <summary>Field number for the "egg_incubator_id" field.</summary>
        public const int EggIncubatorIdFieldNumber = 25;

        /// <summary>Field number for the "creation_time_ms" field.</summary>
        public const int CreationTimeMsFieldNumber = 26;

        /// <summary>Field number for the "num_upgrades" field.</summary>
        public const int NumUpgradesFieldNumber = 27;

        /// <summary>Field number for the "additional_cp_multiplier" field.</summary>
        public const int AdditionalCpMultiplierFieldNumber = 28;

        /// <summary>Field number for the "favorite" field.</summary>
        public const int FavoriteFieldNumber = 29;

        /// <summary>Field number for the "nickname" field.</summary>
        public const int NicknameFieldNumber = 30;

        /// <summary>Field number for the "from_fort" field.</summary>
        public const int FromFortFieldNumber = 31;

        private static readonly pb::MessageParser<Pokemon> _parser = new pb::MessageParser<Pokemon>(() => new Pokemon());
        private int additionalCpMultiplier_;
        private int battlesAttacked_;
        private int battlesDefended_;
        private ulong capturedCellId_;
        private int cp_;
        private int cpMultiplier_;
        private ulong creationTimeMs_;
        private int deployedFortId_;
        private int eggIncubatorId_;
        private int eggKmWalkedStart_;
        private int eggKmWalkedTarget_;
        private int favorite_;
        private int fromFort_;
        private float heightM_;
        private int id_;
        private int individualAttack_;
        private int individualDefense_;
        private int individualStamina_;
        private bool isEgg_;
        private global::AllEnum.PokemonMove move1_ = 0;
        private global::AllEnum.PokemonMove move2_ = 0;
        private string nickname_ = "";
        private int numUpgrades_;
        private int origin_;
        private string ownerName_ = "";
        private int pokeball_;
        private global::AllEnum.PokemonId pokemonType_ = 0;
        private int stamina_;
        private int staminaMax_;
        private float weightKg_;

        public Pokemon()
        {
            OnConstruction();
        }

        public Pokemon(Pokemon other) : this()
        {
            id_ = other.id_;
            pokemonType_ = other.pokemonType_;
            cp_ = other.cp_;
            stamina_ = other.stamina_;
            staminaMax_ = other.staminaMax_;
            move1_ = other.move1_;
            move2_ = other.move2_;
            deployedFortId_ = other.deployedFortId_;
            ownerName_ = other.ownerName_;
            isEgg_ = other.isEgg_;
            eggKmWalkedTarget_ = other.eggKmWalkedTarget_;
            eggKmWalkedStart_ = other.eggKmWalkedStart_;
            origin_ = other.origin_;
            heightM_ = other.heightM_;
            weightKg_ = other.weightKg_;
            individualAttack_ = other.individualAttack_;
            individualDefense_ = other.individualDefense_;
            individualStamina_ = other.individualStamina_;
            cpMultiplier_ = other.cpMultiplier_;
            pokeball_ = other.pokeball_;
            capturedCellId_ = other.capturedCellId_;
            battlesAttacked_ = other.battlesAttacked_;
            battlesDefended_ = other.battlesDefended_;
            eggIncubatorId_ = other.eggIncubatorId_;
            creationTimeMs_ = other.creationTimeMs_;
            numUpgrades_ = other.numUpgrades_;
            additionalCpMultiplier_ = other.additionalCpMultiplier_;
            favorite_ = other.favorite_;
            nickname_ = other.nickname_;
            fromFort_ = other.fromFort_;
        }

        public static pb::MessageParser<Pokemon> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[10]; }
        }

        public int Id
        {
            get { return id_; }
            set { id_ = value; }
        }

        public global::AllEnum.PokemonId PokemonType
        {
            get { return pokemonType_; }
            set { pokemonType_ = value; }
        }

        public int Cp
        {
            get { return cp_; }
            set { cp_ = value; }
        }

        public int Stamina
        {
            get { return stamina_; }
            set { stamina_ = value; }
        }

        public int StaminaMax
        {
            get { return staminaMax_; }
            set { staminaMax_ = value; }
        }

        public global::AllEnum.PokemonMove Move1
        {
            get { return move1_; }
            set { move1_ = value; }
        }

        public global::AllEnum.PokemonMove Move2
        {
            get { return move2_; }
            set { move2_ = value; }
        }

        public int DeployedFortId
        {
            get { return deployedFortId_; }
            set { deployedFortId_ = value; }
        }

        public string OwnerName
        {
            get { return ownerName_; }
            set { ownerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public bool IsEgg
        {
            get { return isEgg_; }
            set { isEgg_ = value; }
        }

        public int EggKmWalkedTarget
        {
            get { return eggKmWalkedTarget_; }
            set { eggKmWalkedTarget_ = value; }
        }

        public int EggKmWalkedStart
        {
            get { return eggKmWalkedStart_; }
            set { eggKmWalkedStart_ = value; }
        }

        public int Origin
        {
            get { return origin_; }
            set { origin_ = value; }
        }

        public float HeightM
        {
            get { return heightM_; }
            set { heightM_ = value; }
        }

        public float WeightKg
        {
            get { return weightKg_; }
            set { weightKg_ = value; }
        }

        public int IndividualAttack
        {
            get { return individualAttack_; }
            set { individualAttack_ = value; }
        }

        public int IndividualDefense
        {
            get { return individualDefense_; }
            set { individualDefense_ = value; }
        }

        public int IndividualStamina
        {
            get { return individualStamina_; }
            set { individualStamina_ = value; }
        }

        public int CpMultiplier
        {
            get { return cpMultiplier_; }
            set { cpMultiplier_ = value; }
        }

        public int Pokeball
        {
            get { return pokeball_; }
            set { pokeball_ = value; }
        }

        public ulong CapturedCellId
        {
            get { return capturedCellId_; }
            set { capturedCellId_ = value; }
        }

        public int BattlesAttacked
        {
            get { return battlesAttacked_; }
            set { battlesAttacked_ = value; }
        }

        public int BattlesDefended
        {
            get { return battlesDefended_; }
            set { battlesDefended_ = value; }
        }

        public int EggIncubatorId
        {
            get { return eggIncubatorId_; }
            set { eggIncubatorId_ = value; }
        }

        public ulong CreationTimeMs
        {
            get { return creationTimeMs_; }
            set { creationTimeMs_ = value; }
        }

        public int NumUpgrades
        {
            get { return numUpgrades_; }
            set { numUpgrades_ = value; }
        }

        public int AdditionalCpMultiplier
        {
            get { return additionalCpMultiplier_; }
            set { additionalCpMultiplier_ = value; }
        }

        public int Favorite
        {
            get { return favorite_; }
            set { favorite_ = value; }
        }

        public string Nickname
        {
            get { return nickname_; }
            set { nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public int FromFort
        {
            get { return fromFort_; }
            set { fromFort_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Pokemon Clone()
        {
            return new Pokemon(this);
        }

        public bool Equals(Pokemon other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Id != other.Id) return false;
            if (PokemonType != other.PokemonType) return false;
            if (Cp != other.Cp) return false;
            if (Stamina != other.Stamina) return false;
            if (StaminaMax != other.StaminaMax) return false;
            if (Move1 != other.Move1) return false;
            if (Move2 != other.Move2) return false;
            if (DeployedFortId != other.DeployedFortId) return false;
            if (OwnerName != other.OwnerName) return false;
            if (IsEgg != other.IsEgg) return false;
            if (EggKmWalkedTarget != other.EggKmWalkedTarget) return false;
            if (EggKmWalkedStart != other.EggKmWalkedStart) return false;
            if (Origin != other.Origin) return false;
            if (HeightM != other.HeightM) return false;
            if (WeightKg != other.WeightKg) return false;
            if (IndividualAttack != other.IndividualAttack) return false;
            if (IndividualDefense != other.IndividualDefense) return false;
            if (IndividualStamina != other.IndividualStamina) return false;
            if (CpMultiplier != other.CpMultiplier) return false;
            if (Pokeball != other.Pokeball) return false;
            if (CapturedCellId != other.CapturedCellId) return false;
            if (BattlesAttacked != other.BattlesAttacked) return false;
            if (BattlesDefended != other.BattlesDefended) return false;
            if (EggIncubatorId != other.EggIncubatorId) return false;
            if (CreationTimeMs != other.CreationTimeMs) return false;
            if (NumUpgrades != other.NumUpgrades) return false;
            if (AdditionalCpMultiplier != other.AdditionalCpMultiplier) return false;
            if (Favorite != other.Favorite) return false;
            if (Nickname != other.Nickname) return false;
            if (FromFort != other.FromFort) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Id != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Id);
            }
            if (PokemonType != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)PokemonType);
            }
            if (Cp != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(Cp);
            }
            if (Stamina != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(Stamina);
            }
            if (StaminaMax != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(StaminaMax);
            }
            if (Move1 != 0)
            {
                output.WriteRawTag(48);
                output.WriteEnum((int)Move1);
            }
            if (Move2 != 0)
            {
                output.WriteRawTag(56);
                output.WriteEnum((int)Move2);
            }
            if (DeployedFortId != 0)
            {
                output.WriteRawTag(64);
                output.WriteInt32(DeployedFortId);
            }
            if (OwnerName.Length != 0)
            {
                output.WriteRawTag(74);
                output.WriteString(OwnerName);
            }
            if (IsEgg != false)
            {
                output.WriteRawTag(80);
                output.WriteBool(IsEgg);
            }
            if (EggKmWalkedTarget != 0)
            {
                output.WriteRawTag(88);
                output.WriteInt32(EggKmWalkedTarget);
            }
            if (EggKmWalkedStart != 0)
            {
                output.WriteRawTag(96);
                output.WriteInt32(EggKmWalkedStart);
            }
            if (Origin != 0)
            {
                output.WriteRawTag(112);
                output.WriteInt32(Origin);
            }
            if (HeightM != 0F)
            {
                output.WriteRawTag(125);
                output.WriteFloat(HeightM);
            }
            if (WeightKg != 0F)
            {
                output.WriteRawTag(133, 1);
                output.WriteFloat(WeightKg);
            }
            if (IndividualAttack != 0)
            {
                output.WriteRawTag(136, 1);
                output.WriteInt32(IndividualAttack);
            }
            if (IndividualDefense != 0)
            {
                output.WriteRawTag(144, 1);
                output.WriteInt32(IndividualDefense);
            }
            if (IndividualStamina != 0)
            {
                output.WriteRawTag(152, 1);
                output.WriteInt32(IndividualStamina);
            }
            if (CpMultiplier != 0)
            {
                output.WriteRawTag(160, 1);
                output.WriteInt32(CpMultiplier);
            }
            if (Pokeball != 0)
            {
                output.WriteRawTag(168, 1);
                output.WriteInt32(Pokeball);
            }
            if (CapturedCellId != 0UL)
            {
                output.WriteRawTag(176, 1);
                output.WriteUInt64(CapturedCellId);
            }
            if (BattlesAttacked != 0)
            {
                output.WriteRawTag(184, 1);
                output.WriteInt32(BattlesAttacked);
            }
            if (BattlesDefended != 0)
            {
                output.WriteRawTag(192, 1);
                output.WriteInt32(BattlesDefended);
            }
            if (EggIncubatorId != 0)
            {
                output.WriteRawTag(200, 1);
                output.WriteInt32(EggIncubatorId);
            }
            if (CreationTimeMs != 0UL)
            {
                output.WriteRawTag(208, 1);
                output.WriteUInt64(CreationTimeMs);
            }
            if (NumUpgrades != 0)
            {
                output.WriteRawTag(216, 1);
                output.WriteInt32(NumUpgrades);
            }
            if (AdditionalCpMultiplier != 0)
            {
                output.WriteRawTag(224, 1);
                output.WriteInt32(AdditionalCpMultiplier);
            }
            if (Favorite != 0)
            {
                output.WriteRawTag(232, 1);
                output.WriteInt32(Favorite);
            }
            if (Nickname.Length != 0)
            {
                output.WriteRawTag(242, 1);
                output.WriteString(Nickname);
            }
            if (FromFort != 0)
            {
                output.WriteRawTag(248, 1);
                output.WriteInt32(FromFort);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Id != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
            }
            if (PokemonType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonType);
            }
            if (Cp != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Cp);
            }
            if (Stamina != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
            }
            if (StaminaMax != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(StaminaMax);
            }
            if (Move1 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Move1);
            }
            if (Move2 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Move2);
            }
            if (DeployedFortId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DeployedFortId);
            }
            if (OwnerName.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerName);
            }
            if (IsEgg != false)
            {
                size += 1 + 1;
            }
            if (EggKmWalkedTarget != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggKmWalkedTarget);
            }
            if (EggKmWalkedStart != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggKmWalkedStart);
            }
            if (Origin != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Origin);
            }
            if (HeightM != 0F)
            {
                size += 1 + 4;
            }
            if (WeightKg != 0F)
            {
                size += 2 + 4;
            }
            if (IndividualAttack != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualAttack);
            }
            if (IndividualDefense != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualDefense);
            }
            if (IndividualStamina != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualStamina);
            }
            if (CpMultiplier != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(CpMultiplier);
            }
            if (Pokeball != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(Pokeball);
            }
            if (CapturedCellId != 0UL)
            {
                size += 2 + pb::CodedOutputStream.ComputeUInt64Size(CapturedCellId);
            }
            if (BattlesAttacked != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattlesAttacked);
            }
            if (BattlesDefended != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattlesDefended);
            }
            if (EggIncubatorId != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(EggIncubatorId);
            }
            if (CreationTimeMs != 0UL)
            {
                size += 2 + pb::CodedOutputStream.ComputeUInt64Size(CreationTimeMs);
            }
            if (NumUpgrades != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(NumUpgrades);
            }
            if (AdditionalCpMultiplier != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(AdditionalCpMultiplier);
            }
            if (Favorite != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(Favorite);
            }
            if (Nickname.Length != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeStringSize(Nickname);
            }
            if (FromFort != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(FromFort);
            }
            return size;
        }

        public void MergeFrom(Pokemon other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Id != 0)
            {
                Id = other.Id;
            }
            if (other.PokemonType != 0)
            {
                PokemonType = other.PokemonType;
            }
            if (other.Cp != 0)
            {
                Cp = other.Cp;
            }
            if (other.Stamina != 0)
            {
                Stamina = other.Stamina;
            }
            if (other.StaminaMax != 0)
            {
                StaminaMax = other.StaminaMax;
            }
            if (other.Move1 != 0)
            {
                Move1 = other.Move1;
            }
            if (other.Move2 != 0)
            {
                Move2 = other.Move2;
            }
            if (other.DeployedFortId != 0)
            {
                DeployedFortId = other.DeployedFortId;
            }
            if (other.OwnerName.Length != 0)
            {
                OwnerName = other.OwnerName;
            }
            if (other.IsEgg != false)
            {
                IsEgg = other.IsEgg;
            }
            if (other.EggKmWalkedTarget != 0)
            {
                EggKmWalkedTarget = other.EggKmWalkedTarget;
            }
            if (other.EggKmWalkedStart != 0)
            {
                EggKmWalkedStart = other.EggKmWalkedStart;
            }
            if (other.Origin != 0)
            {
                Origin = other.Origin;
            }
            if (other.HeightM != 0F)
            {
                HeightM = other.HeightM;
            }
            if (other.WeightKg != 0F)
            {
                WeightKg = other.WeightKg;
            }
            if (other.IndividualAttack != 0)
            {
                IndividualAttack = other.IndividualAttack;
            }
            if (other.IndividualDefense != 0)
            {
                IndividualDefense = other.IndividualDefense;
            }
            if (other.IndividualStamina != 0)
            {
                IndividualStamina = other.IndividualStamina;
            }
            if (other.CpMultiplier != 0)
            {
                CpMultiplier = other.CpMultiplier;
            }
            if (other.Pokeball != 0)
            {
                Pokeball = other.Pokeball;
            }
            if (other.CapturedCellId != 0UL)
            {
                CapturedCellId = other.CapturedCellId;
            }
            if (other.BattlesAttacked != 0)
            {
                BattlesAttacked = other.BattlesAttacked;
            }
            if (other.BattlesDefended != 0)
            {
                BattlesDefended = other.BattlesDefended;
            }
            if (other.EggIncubatorId != 0)
            {
                EggIncubatorId = other.EggIncubatorId;
            }
            if (other.CreationTimeMs != 0UL)
            {
                CreationTimeMs = other.CreationTimeMs;
            }
            if (other.NumUpgrades != 0)
            {
                NumUpgrades = other.NumUpgrades;
            }
            if (other.AdditionalCpMultiplier != 0)
            {
                AdditionalCpMultiplier = other.AdditionalCpMultiplier;
            }
            if (other.Favorite != 0)
            {
                Favorite = other.Favorite;
            }
            if (other.Nickname.Length != 0)
            {
                Nickname = other.Nickname;
            }
            if (other.FromFort != 0)
            {
                FromFort = other.FromFort;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Id = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            pokemonType_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            Cp = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            Stamina = input.ReadInt32();
                            break;
                        }
                    case 40:
                        {
                            StaminaMax = input.ReadInt32();
                            break;
                        }
                    case 48:
                        {
                            move1_ = (global::AllEnum.PokemonMove)input.ReadEnum();
                            break;
                        }
                    case 56:
                        {
                            move2_ = (global::AllEnum.PokemonMove)input.ReadEnum();
                            break;
                        }
                    case 64:
                        {
                            DeployedFortId = input.ReadInt32();
                            break;
                        }
                    case 74:
                        {
                            OwnerName = input.ReadString();
                            break;
                        }
                    case 80:
                        {
                            IsEgg = input.ReadBool();
                            break;
                        }
                    case 88:
                        {
                            EggKmWalkedTarget = input.ReadInt32();
                            break;
                        }
                    case 96:
                        {
                            EggKmWalkedStart = input.ReadInt32();
                            break;
                        }
                    case 112:
                        {
                            Origin = input.ReadInt32();
                            break;
                        }
                    case 125:
                        {
                            HeightM = input.ReadFloat();
                            break;
                        }
                    case 133:
                        {
                            WeightKg = input.ReadFloat();
                            break;
                        }
                    case 136:
                        {
                            IndividualAttack = input.ReadInt32();
                            break;
                        }
                    case 144:
                        {
                            IndividualDefense = input.ReadInt32();
                            break;
                        }
                    case 152:
                        {
                            IndividualStamina = input.ReadInt32();
                            break;
                        }
                    case 160:
                        {
                            CpMultiplier = input.ReadInt32();
                            break;
                        }
                    case 168:
                        {
                            Pokeball = input.ReadInt32();
                            break;
                        }
                    case 176:
                        {
                            CapturedCellId = input.ReadUInt64();
                            break;
                        }
                    case 184:
                        {
                            BattlesAttacked = input.ReadInt32();
                            break;
                        }
                    case 192:
                        {
                            BattlesDefended = input.ReadInt32();
                            break;
                        }
                    case 200:
                        {
                            EggIncubatorId = input.ReadInt32();
                            break;
                        }
                    case 208:
                        {
                            CreationTimeMs = input.ReadUInt64();
                            break;
                        }
                    case 216:
                        {
                            NumUpgrades = input.ReadInt32();
                            break;
                        }
                    case 224:
                        {
                            AdditionalCpMultiplier = input.ReadInt32();
                            break;
                        }
                    case 232:
                        {
                            Favorite = input.ReadInt32();
                            break;
                        }
                    case 242:
                        {
                            Nickname = input.ReadString();
                            break;
                        }
                    case 248:
                        {
                            FromFort = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as Pokemon);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Id != 0) hash ^= Id.GetHashCode();
            if (PokemonType != 0) hash ^= PokemonType.GetHashCode();
            if (Cp != 0) hash ^= Cp.GetHashCode();
            if (Stamina != 0) hash ^= Stamina.GetHashCode();
            if (StaminaMax != 0) hash ^= StaminaMax.GetHashCode();
            if (Move1 != 0) hash ^= Move1.GetHashCode();
            if (Move2 != 0) hash ^= Move2.GetHashCode();
            if (DeployedFortId != 0) hash ^= DeployedFortId.GetHashCode();
            if (OwnerName.Length != 0) hash ^= OwnerName.GetHashCode();
            if (IsEgg != false) hash ^= IsEgg.GetHashCode();
            if (EggKmWalkedTarget != 0) hash ^= EggKmWalkedTarget.GetHashCode();
            if (EggKmWalkedStart != 0) hash ^= EggKmWalkedStart.GetHashCode();
            if (Origin != 0) hash ^= Origin.GetHashCode();
            if (HeightM != 0F) hash ^= HeightM.GetHashCode();
            if (WeightKg != 0F) hash ^= WeightKg.GetHashCode();
            if (IndividualAttack != 0) hash ^= IndividualAttack.GetHashCode();
            if (IndividualDefense != 0) hash ^= IndividualDefense.GetHashCode();
            if (IndividualStamina != 0) hash ^= IndividualStamina.GetHashCode();
            if (CpMultiplier != 0) hash ^= CpMultiplier.GetHashCode();
            if (Pokeball != 0) hash ^= Pokeball.GetHashCode();
            if (CapturedCellId != 0UL) hash ^= CapturedCellId.GetHashCode();
            if (BattlesAttacked != 0) hash ^= BattlesAttacked.GetHashCode();
            if (BattlesDefended != 0) hash ^= BattlesDefended.GetHashCode();
            if (EggIncubatorId != 0) hash ^= EggIncubatorId.GetHashCode();
            if (CreationTimeMs != 0UL) hash ^= CreationTimeMs.GetHashCode();
            if (NumUpgrades != 0) hash ^= NumUpgrades.GetHashCode();
            if (AdditionalCpMultiplier != 0) hash ^= AdditionalCpMultiplier.GetHashCode();
            if (Favorite != 0) hash ^= Favorite.GetHashCode();
            if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
            if (FromFort != 0) hash ^= FromFort.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Item : pb::IMessage<Item>
    {
        /// <summary>Field number for the "item" field.</summary>
        public const int Item_FieldNumber = 1;

        /// <summary>Field number for the "count" field.</summary>
        public const int CountFieldNumber = 2;

        /// <summary>Field number for the "unseen" field.</summary>
        public const int UnseenFieldNumber = 3;

        private static readonly pb::MessageParser<Item> _parser = new pb::MessageParser<Item>(() => new Item());
        private int count_;
        private global::AllEnum.ItemType item_ = 0;
        private bool unseen_;

        public Item()
        {
            OnConstruction();
        }

        public Item(Item other) : this()
        {
            item_ = other.item_;
            count_ = other.count_;
            unseen_ = other.unseen_;
        }

        public static pb::MessageParser<Item> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[11]; }
        }

        public global::AllEnum.ItemType Item_
        {
            get { return item_; }
            set { item_ = value; }
        }

        public int Count
        {
            get { return count_; }
            set { count_ = value; }
        }

        public bool Unseen
        {
            get { return unseen_; }
            set { unseen_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Item Clone()
        {
            return new Item(this);
        }

        public bool Equals(Item other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Item_ != other.Item_) return false;
            if (Count != other.Count) return false;
            if (Unseen != other.Unseen) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Item_ != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Item_);
            }
            if (Count != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Count);
            }
            if (Unseen != false)
            {
                output.WriteRawTag(24);
                output.WriteBool(Unseen);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Item_ != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Item_);
            }
            if (Count != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
            }
            if (Unseen != false)
            {
                size += 1 + 1;
            }
            return size;
        }

        public void MergeFrom(Item other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Item_ != 0)
            {
                Item_ = other.Item_;
            }
            if (other.Count != 0)
            {
                Count = other.Count;
            }
            if (other.Unseen != false)
            {
                Unseen = other.Unseen;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            item_ = (global::AllEnum.ItemType)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            Count = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            Unseen = input.ReadBool();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as Item);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Item_ != 0) hash ^= Item_.GetHashCode();
            if (Count != 0) hash ^= Count.GetHashCode();
            if (Unseen != false) hash ^= Unseen.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PokedexEntry : pb::IMessage<PokedexEntry>
    {
        /// <summary>Field number for the "pokedex_entry_number" field.</summary>
        public const int PokedexEntryNumberFieldNumber = 1;

        /// <summary>Field number for the "times_encountered" field.</summary>
        public const int TimesEncounteredFieldNumber = 2;

        /// <summary>Field number for the "times_captured" field.</summary>
        public const int TimesCapturedFieldNumber = 3;

        /// <summary>Field number for the "evolution_stone_pieces" field.</summary>
        public const int EvolutionStonePiecesFieldNumber = 4;

        /// <summary>Field number for the "evolution_stones" field.</summary>
        public const int EvolutionStonesFieldNumber = 5;

        private static readonly pb::MessageParser<PokedexEntry> _parser =
            new pb::MessageParser<PokedexEntry>(() => new PokedexEntry());

        private int evolutionStonePieces_;
        private int evolutionStones_;
        private int pokedexEntryNumber_;
        private int timesCaptured_;
        private int timesEncountered_;

        public PokedexEntry()
        {
            OnConstruction();
        }

        public PokedexEntry(PokedexEntry other) : this()
        {
            pokedexEntryNumber_ = other.pokedexEntryNumber_;
            timesEncountered_ = other.timesEncountered_;
            timesCaptured_ = other.timesCaptured_;
            evolutionStonePieces_ = other.evolutionStonePieces_;
            evolutionStones_ = other.evolutionStones_;
        }

        public static pb::MessageParser<PokedexEntry> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[12]; }
        }

        public int PokedexEntryNumber
        {
            get { return pokedexEntryNumber_; }
            set { pokedexEntryNumber_ = value; }
        }

        public int TimesEncountered
        {
            get { return timesEncountered_; }
            set { timesEncountered_ = value; }
        }

        public int TimesCaptured
        {
            get { return timesCaptured_; }
            set { timesCaptured_ = value; }
        }

        public int EvolutionStonePieces
        {
            get { return evolutionStonePieces_; }
            set { evolutionStonePieces_ = value; }
        }

        public int EvolutionStones
        {
            get { return evolutionStones_; }
            set { evolutionStones_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PokedexEntry Clone()
        {
            return new PokedexEntry(this);
        }

        public bool Equals(PokedexEntry other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PokedexEntryNumber != other.PokedexEntryNumber) return false;
            if (TimesEncountered != other.TimesEncountered) return false;
            if (TimesCaptured != other.TimesCaptured) return false;
            if (EvolutionStonePieces != other.EvolutionStonePieces) return false;
            if (EvolutionStones != other.EvolutionStones) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (PokedexEntryNumber != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(PokedexEntryNumber);
            }
            if (TimesEncountered != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(TimesEncountered);
            }
            if (TimesCaptured != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(TimesCaptured);
            }
            if (EvolutionStonePieces != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(EvolutionStonePieces);
            }
            if (EvolutionStones != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(EvolutionStones);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (PokedexEntryNumber != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokedexEntryNumber);
            }
            if (TimesEncountered != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesEncountered);
            }
            if (TimesCaptured != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesCaptured);
            }
            if (EvolutionStonePieces != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStonePieces);
            }
            if (EvolutionStones != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStones);
            }
            return size;
        }

        public void MergeFrom(PokedexEntry other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PokedexEntryNumber != 0)
            {
                PokedexEntryNumber = other.PokedexEntryNumber;
            }
            if (other.TimesEncountered != 0)
            {
                TimesEncountered = other.TimesEncountered;
            }
            if (other.TimesCaptured != 0)
            {
                TimesCaptured = other.TimesCaptured;
            }
            if (other.EvolutionStonePieces != 0)
            {
                EvolutionStonePieces = other.EvolutionStonePieces;
            }
            if (other.EvolutionStones != 0)
            {
                EvolutionStones = other.EvolutionStones;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            PokedexEntryNumber = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            TimesEncountered = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            TimesCaptured = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            EvolutionStonePieces = input.ReadInt32();
                            break;
                        }
                    case 40:
                        {
                            EvolutionStones = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PokedexEntry);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (PokedexEntryNumber != 0) hash ^= PokedexEntryNumber.GetHashCode();
            if (TimesEncountered != 0) hash ^= TimesEncountered.GetHashCode();
            if (TimesCaptured != 0) hash ^= TimesCaptured.GetHashCode();
            if (EvolutionStonePieces != 0) hash ^= EvolutionStonePieces.GetHashCode();
            if (EvolutionStones != 0) hash ^= EvolutionStones.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PlayerStats : pb::IMessage<PlayerStats>
    {
        /// <summary>Field number for the "level" field.</summary>
        public const int LevelFieldNumber = 1;

        /// <summary>Field number for the "experience" field.</summary>
        public const int ExperienceFieldNumber = 2;

        /// <summary>Field number for the "prev_level_xp" field.</summary>
        public const int PrevLevelXpFieldNumber = 3;

        /// <summary>Field number for the "next_level_xp" field.</summary>
        public const int NextLevelXpFieldNumber = 4;

        /// <summary>Field number for the "km_walked" field.</summary>
        public const int KmWalkedFieldNumber = 5;

        /// <summary>Field number for the "pokemons_encountered" field.</summary>
        public const int PokemonsEncounteredFieldNumber = 6;

        /// <summary>Field number for the "unique_pokedex_entries" field.</summary>
        public const int UniquePokedexEntriesFieldNumber = 7;

        /// <summary>Field number for the "pokemons_captured" field.</summary>
        public const int PokemonsCapturedFieldNumber = 8;

        /// <summary>Field number for the "evolutions" field.</summary>
        public const int EvolutionsFieldNumber = 9;

        /// <summary>Field number for the "poke_stop_visits" field.</summary>
        public const int PokeStopVisitsFieldNumber = 10;

        /// <summary>Field number for the "pokeballs_thrown" field.</summary>
        public const int PokeballsThrownFieldNumber = 11;

        /// <summary>Field number for the "eggs_hatched" field.</summary>
        public const int EggsHatchedFieldNumber = 12;

        /// <summary>Field number for the "big_magikarp_caught" field.</summary>
        public const int BigMagikarpCaughtFieldNumber = 13;

        /// <summary>Field number for the "battle_attack_won" field.</summary>
        public const int BattleAttackWonFieldNumber = 14;

        /// <summary>Field number for the "battle_attack_total" field.</summary>
        public const int BattleAttackTotalFieldNumber = 15;

        /// <summary>Field number for the "battle_defended_won" field.</summary>
        public const int BattleDefendedWonFieldNumber = 16;

        /// <summary>Field number for the "battle_training_won" field.</summary>
        public const int BattleTrainingWonFieldNumber = 17;

        /// <summary>Field number for the "battle_training_total" field.</summary>
        public const int BattleTrainingTotalFieldNumber = 18;

        /// <summary>Field number for the "prestige_raised_total" field.</summary>
        public const int PrestigeRaisedTotalFieldNumber = 19;

        /// <summary>Field number for the "prestige_dropped_total" field.</summary>
        public const int PrestigeDroppedTotalFieldNumber = 20;

        /// <summary>Field number for the "pokemon_deployed" field.</summary>
        public const int PokemonDeployedFieldNumber = 21;

        /// <summary>Field number for the "pokemon_caught_by_type" field.</summary>
        public const int PokemonCaughtByTypeFieldNumber = 22;

        /// <summary>Field number for the "small_rattata_caught" field.</summary>
        public const int SmallRattataCaughtFieldNumber = 23;

        private static readonly pb::MessageParser<PlayerStats> _parser =
            new pb::MessageParser<PlayerStats>(() => new PlayerStats());

        private int battleAttackTotal_;
        private int battleAttackWon_;
        private int battleDefendedWon_;
        private int battleTrainingTotal_;
        private int battleTrainingWon_;
        private int bigMagikarpCaught_;
        private int eggsHatched_;
        private int evolutions_;
        private long experience_;
        private float kmWalked_;
        private int level_;
        private long nextLevelXp_;
        private int pokeballsThrown_;
        private pb::ByteString pokemonCaughtByType_ = pb::ByteString.Empty;
        private int pokemonDeployed_;
        private int pokemonsCaptured_;
        private int pokemonsEncountered_;
        private int pokeStopVisits_;
        private int prestigeDroppedTotal_;
        private int prestigeRaisedTotal_;
        private long prevLevelXp_;
        private int smallRattataCaught_;
        private int uniquePokedexEntries_;

        public PlayerStats()
        {
            OnConstruction();
        }

        public PlayerStats(PlayerStats other) : this()
        {
            level_ = other.level_;
            experience_ = other.experience_;
            prevLevelXp_ = other.prevLevelXp_;
            nextLevelXp_ = other.nextLevelXp_;
            kmWalked_ = other.kmWalked_;
            pokemonsEncountered_ = other.pokemonsEncountered_;
            uniquePokedexEntries_ = other.uniquePokedexEntries_;
            pokemonsCaptured_ = other.pokemonsCaptured_;
            evolutions_ = other.evolutions_;
            pokeStopVisits_ = other.pokeStopVisits_;
            pokeballsThrown_ = other.pokeballsThrown_;
            eggsHatched_ = other.eggsHatched_;
            bigMagikarpCaught_ = other.bigMagikarpCaught_;
            battleAttackWon_ = other.battleAttackWon_;
            battleAttackTotal_ = other.battleAttackTotal_;
            battleDefendedWon_ = other.battleDefendedWon_;
            battleTrainingWon_ = other.battleTrainingWon_;
            battleTrainingTotal_ = other.battleTrainingTotal_;
            prestigeRaisedTotal_ = other.prestigeRaisedTotal_;
            prestigeDroppedTotal_ = other.prestigeDroppedTotal_;
            pokemonDeployed_ = other.pokemonDeployed_;
            pokemonCaughtByType_ = other.pokemonCaughtByType_;
            smallRattataCaught_ = other.smallRattataCaught_;
        }

        public static pb::MessageParser<PlayerStats> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[13]; }
        }

        public int Level
        {
            get { return level_; }
            set { level_ = value; }
        }

        public long Experience
        {
            get { return experience_; }
            set { experience_ = value; }
        }

        public long PrevLevelXp
        {
            get { return prevLevelXp_; }
            set { prevLevelXp_ = value; }
        }

        public long NextLevelXp
        {
            get { return nextLevelXp_; }
            set { nextLevelXp_ = value; }
        }

        public float KmWalked
        {
            get { return kmWalked_; }
            set { kmWalked_ = value; }
        }

        public int PokemonsEncountered
        {
            get { return pokemonsEncountered_; }
            set { pokemonsEncountered_ = value; }
        }

        public int UniquePokedexEntries
        {
            get { return uniquePokedexEntries_; }
            set { uniquePokedexEntries_ = value; }
        }

        public int PokemonsCaptured
        {
            get { return pokemonsCaptured_; }
            set { pokemonsCaptured_ = value; }
        }

        public int Evolutions
        {
            get { return evolutions_; }
            set { evolutions_ = value; }
        }

        public int PokeStopVisits
        {
            get { return pokeStopVisits_; }
            set { pokeStopVisits_ = value; }
        }

        public int PokeballsThrown
        {
            get { return pokeballsThrown_; }
            set { pokeballsThrown_ = value; }
        }

        public int EggsHatched
        {
            get { return eggsHatched_; }
            set { eggsHatched_ = value; }
        }

        public int BigMagikarpCaught
        {
            get { return bigMagikarpCaught_; }
            set { bigMagikarpCaught_ = value; }
        }

        public int BattleAttackWon
        {
            get { return battleAttackWon_; }
            set { battleAttackWon_ = value; }
        }

        public int BattleAttackTotal
        {
            get { return battleAttackTotal_; }
            set { battleAttackTotal_ = value; }
        }

        public int BattleDefendedWon
        {
            get { return battleDefendedWon_; }
            set { battleDefendedWon_ = value; }
        }

        public int BattleTrainingWon
        {
            get { return battleTrainingWon_; }
            set { battleTrainingWon_ = value; }
        }

        public int BattleTrainingTotal
        {
            get { return battleTrainingTotal_; }
            set { battleTrainingTotal_ = value; }
        }

        public int PrestigeRaisedTotal
        {
            get { return prestigeRaisedTotal_; }
            set { prestigeRaisedTotal_ = value; }
        }

        public int PrestigeDroppedTotal
        {
            get { return prestigeDroppedTotal_; }
            set { prestigeDroppedTotal_ = value; }
        }

        public int PokemonDeployed
        {
            get { return pokemonDeployed_; }
            set { pokemonDeployed_ = value; }
        }

        /// <summary>
        ///     TODO: repeated PokemonType ??
        /// </summary>
        public pb::ByteString PokemonCaughtByType
        {
            get { return pokemonCaughtByType_; }
            set { pokemonCaughtByType_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public int SmallRattataCaught
        {
            get { return smallRattataCaught_; }
            set { smallRattataCaught_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PlayerStats Clone()
        {
            return new PlayerStats(this);
        }

        public bool Equals(PlayerStats other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Level != other.Level) return false;
            if (Experience != other.Experience) return false;
            if (PrevLevelXp != other.PrevLevelXp) return false;
            if (NextLevelXp != other.NextLevelXp) return false;
            if (KmWalked != other.KmWalked) return false;
            if (PokemonsEncountered != other.PokemonsEncountered) return false;
            if (UniquePokedexEntries != other.UniquePokedexEntries) return false;
            if (PokemonsCaptured != other.PokemonsCaptured) return false;
            if (Evolutions != other.Evolutions) return false;
            if (PokeStopVisits != other.PokeStopVisits) return false;
            if (PokeballsThrown != other.PokeballsThrown) return false;
            if (EggsHatched != other.EggsHatched) return false;
            if (BigMagikarpCaught != other.BigMagikarpCaught) return false;
            if (BattleAttackWon != other.BattleAttackWon) return false;
            if (BattleAttackTotal != other.BattleAttackTotal) return false;
            if (BattleDefendedWon != other.BattleDefendedWon) return false;
            if (BattleTrainingWon != other.BattleTrainingWon) return false;
            if (BattleTrainingTotal != other.BattleTrainingTotal) return false;
            if (PrestigeRaisedTotal != other.PrestigeRaisedTotal) return false;
            if (PrestigeDroppedTotal != other.PrestigeDroppedTotal) return false;
            if (PokemonDeployed != other.PokemonDeployed) return false;
            if (PokemonCaughtByType != other.PokemonCaughtByType) return false;
            if (SmallRattataCaught != other.SmallRattataCaught) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Level != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Level);
            }
            if (Experience != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(Experience);
            }
            if (PrevLevelXp != 0L)
            {
                output.WriteRawTag(24);
                output.WriteInt64(PrevLevelXp);
            }
            if (NextLevelXp != 0L)
            {
                output.WriteRawTag(32);
                output.WriteInt64(NextLevelXp);
            }
            if (KmWalked != 0F)
            {
                output.WriteRawTag(45);
                output.WriteFloat(KmWalked);
            }
            if (PokemonsEncountered != 0)
            {
                output.WriteRawTag(48);
                output.WriteInt32(PokemonsEncountered);
            }
            if (UniquePokedexEntries != 0)
            {
                output.WriteRawTag(56);
                output.WriteInt32(UniquePokedexEntries);
            }
            if (PokemonsCaptured != 0)
            {
                output.WriteRawTag(64);
                output.WriteInt32(PokemonsCaptured);
            }
            if (Evolutions != 0)
            {
                output.WriteRawTag(72);
                output.WriteInt32(Evolutions);
            }
            if (PokeStopVisits != 0)
            {
                output.WriteRawTag(80);
                output.WriteInt32(PokeStopVisits);
            }
            if (PokeballsThrown != 0)
            {
                output.WriteRawTag(88);
                output.WriteInt32(PokeballsThrown);
            }
            if (EggsHatched != 0)
            {
                output.WriteRawTag(96);
                output.WriteInt32(EggsHatched);
            }
            if (BigMagikarpCaught != 0)
            {
                output.WriteRawTag(104);
                output.WriteInt32(BigMagikarpCaught);
            }
            if (BattleAttackWon != 0)
            {
                output.WriteRawTag(112);
                output.WriteInt32(BattleAttackWon);
            }
            if (BattleAttackTotal != 0)
            {
                output.WriteRawTag(120);
                output.WriteInt32(BattleAttackTotal);
            }
            if (BattleDefendedWon != 0)
            {
                output.WriteRawTag(128, 1);
                output.WriteInt32(BattleDefendedWon);
            }
            if (BattleTrainingWon != 0)
            {
                output.WriteRawTag(136, 1);
                output.WriteInt32(BattleTrainingWon);
            }
            if (BattleTrainingTotal != 0)
            {
                output.WriteRawTag(144, 1);
                output.WriteInt32(BattleTrainingTotal);
            }
            if (PrestigeRaisedTotal != 0)
            {
                output.WriteRawTag(152, 1);
                output.WriteInt32(PrestigeRaisedTotal);
            }
            if (PrestigeDroppedTotal != 0)
            {
                output.WriteRawTag(160, 1);
                output.WriteInt32(PrestigeDroppedTotal);
            }
            if (PokemonDeployed != 0)
            {
                output.WriteRawTag(168, 1);
                output.WriteInt32(PokemonDeployed);
            }
            if (PokemonCaughtByType.Length != 0)
            {
                output.WriteRawTag(178, 1);
                output.WriteBytes(PokemonCaughtByType);
            }
            if (SmallRattataCaught != 0)
            {
                output.WriteRawTag(184, 1);
                output.WriteInt32(SmallRattataCaught);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Level != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
            }
            if (Experience != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(Experience);
            }
            if (PrevLevelXp != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(PrevLevelXp);
            }
            if (NextLevelXp != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextLevelXp);
            }
            if (KmWalked != 0F)
            {
                size += 1 + 4;
            }
            if (PokemonsEncountered != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonsEncountered);
            }
            if (UniquePokedexEntries != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(UniquePokedexEntries);
            }
            if (PokemonsCaptured != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonsCaptured);
            }
            if (Evolutions != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Evolutions);
            }
            if (PokeStopVisits != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeStopVisits);
            }
            if (PokeballsThrown != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeballsThrown);
            }
            if (EggsHatched != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggsHatched);
            }
            if (BigMagikarpCaught != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BigMagikarpCaught);
            }
            if (BattleAttackWon != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleAttackWon);
            }
            if (BattleAttackTotal != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleAttackTotal);
            }
            if (BattleDefendedWon != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleDefendedWon);
            }
            if (BattleTrainingWon != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleTrainingWon);
            }
            if (BattleTrainingTotal != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleTrainingTotal);
            }
            if (PrestigeRaisedTotal != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(PrestigeRaisedTotal);
            }
            if (PrestigeDroppedTotal != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(PrestigeDroppedTotal);
            }
            if (PokemonDeployed != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(PokemonDeployed);
            }
            if (PokemonCaughtByType.Length != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeBytesSize(PokemonCaughtByType);
            }
            if (SmallRattataCaught != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(SmallRattataCaught);
            }
            return size;
        }

        public void MergeFrom(PlayerStats other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Level != 0)
            {
                Level = other.Level;
            }
            if (other.Experience != 0L)
            {
                Experience = other.Experience;
            }
            if (other.PrevLevelXp != 0L)
            {
                PrevLevelXp = other.PrevLevelXp;
            }
            if (other.NextLevelXp != 0L)
            {
                NextLevelXp = other.NextLevelXp;
            }
            if (other.KmWalked != 0F)
            {
                KmWalked = other.KmWalked;
            }
            if (other.PokemonsEncountered != 0)
            {
                PokemonsEncountered = other.PokemonsEncountered;
            }
            if (other.UniquePokedexEntries != 0)
            {
                UniquePokedexEntries = other.UniquePokedexEntries;
            }
            if (other.PokemonsCaptured != 0)
            {
                PokemonsCaptured = other.PokemonsCaptured;
            }
            if (other.Evolutions != 0)
            {
                Evolutions = other.Evolutions;
            }
            if (other.PokeStopVisits != 0)
            {
                PokeStopVisits = other.PokeStopVisits;
            }
            if (other.PokeballsThrown != 0)
            {
                PokeballsThrown = other.PokeballsThrown;
            }
            if (other.EggsHatched != 0)
            {
                EggsHatched = other.EggsHatched;
            }
            if (other.BigMagikarpCaught != 0)
            {
                BigMagikarpCaught = other.BigMagikarpCaught;
            }
            if (other.BattleAttackWon != 0)
            {
                BattleAttackWon = other.BattleAttackWon;
            }
            if (other.BattleAttackTotal != 0)
            {
                BattleAttackTotal = other.BattleAttackTotal;
            }
            if (other.BattleDefendedWon != 0)
            {
                BattleDefendedWon = other.BattleDefendedWon;
            }
            if (other.BattleTrainingWon != 0)
            {
                BattleTrainingWon = other.BattleTrainingWon;
            }
            if (other.BattleTrainingTotal != 0)
            {
                BattleTrainingTotal = other.BattleTrainingTotal;
            }
            if (other.PrestigeRaisedTotal != 0)
            {
                PrestigeRaisedTotal = other.PrestigeRaisedTotal;
            }
            if (other.PrestigeDroppedTotal != 0)
            {
                PrestigeDroppedTotal = other.PrestigeDroppedTotal;
            }
            if (other.PokemonDeployed != 0)
            {
                PokemonDeployed = other.PokemonDeployed;
            }
            if (other.PokemonCaughtByType.Length != 0)
            {
                PokemonCaughtByType = other.PokemonCaughtByType;
            }
            if (other.SmallRattataCaught != 0)
            {
                SmallRattataCaught = other.SmallRattataCaught;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Level = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            Experience = input.ReadInt64();
                            break;
                        }
                    case 24:
                        {
                            PrevLevelXp = input.ReadInt64();
                            break;
                        }
                    case 32:
                        {
                            NextLevelXp = input.ReadInt64();
                            break;
                        }
                    case 45:
                        {
                            KmWalked = input.ReadFloat();
                            break;
                        }
                    case 48:
                        {
                            PokemonsEncountered = input.ReadInt32();
                            break;
                        }
                    case 56:
                        {
                            UniquePokedexEntries = input.ReadInt32();
                            break;
                        }
                    case 64:
                        {
                            PokemonsCaptured = input.ReadInt32();
                            break;
                        }
                    case 72:
                        {
                            Evolutions = input.ReadInt32();
                            break;
                        }
                    case 80:
                        {
                            PokeStopVisits = input.ReadInt32();
                            break;
                        }
                    case 88:
                        {
                            PokeballsThrown = input.ReadInt32();
                            break;
                        }
                    case 96:
                        {
                            EggsHatched = input.ReadInt32();
                            break;
                        }
                    case 104:
                        {
                            BigMagikarpCaught = input.ReadInt32();
                            break;
                        }
                    case 112:
                        {
                            BattleAttackWon = input.ReadInt32();
                            break;
                        }
                    case 120:
                        {
                            BattleAttackTotal = input.ReadInt32();
                            break;
                        }
                    case 128:
                        {
                            BattleDefendedWon = input.ReadInt32();
                            break;
                        }
                    case 136:
                        {
                            BattleTrainingWon = input.ReadInt32();
                            break;
                        }
                    case 144:
                        {
                            BattleTrainingTotal = input.ReadInt32();
                            break;
                        }
                    case 152:
                        {
                            PrestigeRaisedTotal = input.ReadInt32();
                            break;
                        }
                    case 160:
                        {
                            PrestigeDroppedTotal = input.ReadInt32();
                            break;
                        }
                    case 168:
                        {
                            PokemonDeployed = input.ReadInt32();
                            break;
                        }
                    case 178:
                        {
                            PokemonCaughtByType = input.ReadBytes();
                            break;
                        }
                    case 184:
                        {
                            SmallRattataCaught = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PlayerStats);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Level != 0) hash ^= Level.GetHashCode();
            if (Experience != 0L) hash ^= Experience.GetHashCode();
            if (PrevLevelXp != 0L) hash ^= PrevLevelXp.GetHashCode();
            if (NextLevelXp != 0L) hash ^= NextLevelXp.GetHashCode();
            if (KmWalked != 0F) hash ^= KmWalked.GetHashCode();
            if (PokemonsEncountered != 0) hash ^= PokemonsEncountered.GetHashCode();
            if (UniquePokedexEntries != 0) hash ^= UniquePokedexEntries.GetHashCode();
            if (PokemonsCaptured != 0) hash ^= PokemonsCaptured.GetHashCode();
            if (Evolutions != 0) hash ^= Evolutions.GetHashCode();
            if (PokeStopVisits != 0) hash ^= PokeStopVisits.GetHashCode();
            if (PokeballsThrown != 0) hash ^= PokeballsThrown.GetHashCode();
            if (EggsHatched != 0) hash ^= EggsHatched.GetHashCode();
            if (BigMagikarpCaught != 0) hash ^= BigMagikarpCaught.GetHashCode();
            if (BattleAttackWon != 0) hash ^= BattleAttackWon.GetHashCode();
            if (BattleAttackTotal != 0) hash ^= BattleAttackTotal.GetHashCode();
            if (BattleDefendedWon != 0) hash ^= BattleDefendedWon.GetHashCode();
            if (BattleTrainingWon != 0) hash ^= BattleTrainingWon.GetHashCode();
            if (BattleTrainingTotal != 0) hash ^= BattleTrainingTotal.GetHashCode();
            if (PrestigeRaisedTotal != 0) hash ^= PrestigeRaisedTotal.GetHashCode();
            if (PrestigeDroppedTotal != 0) hash ^= PrestigeDroppedTotal.GetHashCode();
            if (PokemonDeployed != 0) hash ^= PokemonDeployed.GetHashCode();
            if (PokemonCaughtByType.Length != 0) hash ^= PokemonCaughtByType.GetHashCode();
            if (SmallRattataCaught != 0) hash ^= SmallRattataCaught.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PlayerCurrency : pb::IMessage<PlayerCurrency>
    {
        /// <summary>Field number for the "gems" field.</summary>
        public const int GemsFieldNumber = 1;

        private static readonly pb::MessageParser<PlayerCurrency> _parser =
            new pb::MessageParser<PlayerCurrency>(() => new PlayerCurrency());

        private int gems_;

        public PlayerCurrency()
        {
            OnConstruction();
        }

        public PlayerCurrency(PlayerCurrency other) : this()
        {
            gems_ = other.gems_;
        }

        public static pb::MessageParser<PlayerCurrency> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[14]; }
        }

        public int Gems
        {
            get { return gems_; }
            set { gems_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PlayerCurrency Clone()
        {
            return new PlayerCurrency(this);
        }

        public bool Equals(PlayerCurrency other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Gems != other.Gems) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Gems != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Gems);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Gems != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gems);
            }
            return size;
        }

        public void MergeFrom(PlayerCurrency other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Gems != 0)
            {
                Gems = other.Gems;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Gems = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PlayerCurrency);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Gems != 0) hash ^= Gems.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PlayerCamera : pb::IMessage<PlayerCamera>
    {
        /// <summary>Field number for the "is_default_camera" field.</summary>
        public const int IsDefaultCameraFieldNumber = 1;

        private static readonly pb::MessageParser<PlayerCamera> _parser =
            new pb::MessageParser<PlayerCamera>(() => new PlayerCamera());

        private bool isDefaultCamera_;

        public PlayerCamera()
        {
            OnConstruction();
        }

        public PlayerCamera(PlayerCamera other) : this()
        {
            isDefaultCamera_ = other.isDefaultCamera_;
        }

        public static pb::MessageParser<PlayerCamera> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[15]; }
        }

        public bool IsDefaultCamera
        {
            get { return isDefaultCamera_; }
            set { isDefaultCamera_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PlayerCamera Clone()
        {
            return new PlayerCamera(this);
        }

        public bool Equals(PlayerCamera other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IsDefaultCamera != other.IsDefaultCamera) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (IsDefaultCamera != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(IsDefaultCamera);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (IsDefaultCamera != false)
            {
                size += 1 + 1;
            }
            return size;
        }

        public void MergeFrom(PlayerCamera other)
        {
            if (other == null)
            {
                return;
            }
            if (other.IsDefaultCamera != false)
            {
                IsDefaultCamera = other.IsDefaultCamera;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            IsDefaultCamera = input.ReadBool();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PlayerCamera);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (IsDefaultCamera != false) hash ^= IsDefaultCamera.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class InventoryUpgrades : pb::IMessage<InventoryUpgrades>
    {
        /// <summary>Field number for the "inventory_upgrades" field.</summary>
        public const int InventoryUpgrades_FieldNumber = 1;

        private static readonly pb::MessageParser<InventoryUpgrades> _parser =
            new pb::MessageParser<InventoryUpgrades>(() => new InventoryUpgrades());

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrade>
            _repeated_inventoryUpgrades_codec
                = pb::FieldCodec.ForMessage(10, global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrade.Parser);

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrade>
            inventoryUpgrades_ = new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrade>();

        public InventoryUpgrades()
        {
            OnConstruction();
        }

        public InventoryUpgrades(InventoryUpgrades other) : this()
        {
            inventoryUpgrades_ = other.inventoryUpgrades_.Clone();
        }

        public static pb::MessageParser<InventoryUpgrades> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[16]; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgrade> InventoryUpgrades_
        {
            get { return inventoryUpgrades_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InventoryUpgrades Clone()
        {
            return new InventoryUpgrades(this);
        }

        public bool Equals(InventoryUpgrades other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!inventoryUpgrades_.Equals(other.inventoryUpgrades_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            inventoryUpgrades_.WriteTo(output, _repeated_inventoryUpgrades_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            size += inventoryUpgrades_.CalculateSize(_repeated_inventoryUpgrades_codec);
            return size;
        }

        public void MergeFrom(InventoryUpgrades other)
        {
            if (other == null)
            {
                return;
            }
            inventoryUpgrades_.Add(other.inventoryUpgrades_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            inventoryUpgrades_.AddEntriesFrom(input, _repeated_inventoryUpgrades_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as InventoryUpgrades);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= inventoryUpgrades_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class InventoryUpgrade : pb::IMessage<InventoryUpgrade>
    {
        /// <summary>Field number for the "item" field.</summary>
        public const int ItemFieldNumber = 1;

        /// <summary>Field number for the "upgrade_type" field.</summary>
        public const int UpgradeTypeFieldNumber = 2;

        /// <summary>Field number for the "additional_storage" field.</summary>
        public const int AdditionalStorageFieldNumber = 3;

        private static readonly pb::MessageParser<InventoryUpgrade> _parser =
            new pb::MessageParser<InventoryUpgrade>(() => new InventoryUpgrade());

        private int additionalStorage_;
        private global::AllEnum.ItemType item_ = 0;
        private global::AllEnum.InventoryUpgradeType upgradeType_ = 0;

        public InventoryUpgrade()
        {
            OnConstruction();
        }

        public InventoryUpgrade(InventoryUpgrade other) : this()
        {
            item_ = other.item_;
            upgradeType_ = other.upgradeType_;
            additionalStorage_ = other.additionalStorage_;
        }

        public static pb::MessageParser<InventoryUpgrade> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[17]; }
        }

        public global::AllEnum.ItemType Item
        {
            get { return item_; }
            set { item_ = value; }
        }

        public global::AllEnum.InventoryUpgradeType UpgradeType
        {
            get { return upgradeType_; }
            set { upgradeType_ = value; }
        }

        public int AdditionalStorage
        {
            get { return additionalStorage_; }
            set { additionalStorage_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InventoryUpgrade Clone()
        {
            return new InventoryUpgrade(this);
        }

        public bool Equals(InventoryUpgrade other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Item != other.Item) return false;
            if (UpgradeType != other.UpgradeType) return false;
            if (AdditionalStorage != other.AdditionalStorage) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Item != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Item);
            }
            if (UpgradeType != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)UpgradeType);
            }
            if (AdditionalStorage != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(AdditionalStorage);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Item != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Item);
            }
            if (UpgradeType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)UpgradeType);
            }
            if (AdditionalStorage != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdditionalStorage);
            }
            return size;
        }

        public void MergeFrom(InventoryUpgrade other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Item != 0)
            {
                Item = other.Item;
            }
            if (other.UpgradeType != 0)
            {
                UpgradeType = other.UpgradeType;
            }
            if (other.AdditionalStorage != 0)
            {
                AdditionalStorage = other.AdditionalStorage;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            item_ = (global::AllEnum.ItemType)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            upgradeType_ = (global::AllEnum.InventoryUpgradeType)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            AdditionalStorage = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as InventoryUpgrade);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Item != 0) hash ^= Item.GetHashCode();
            if (UpgradeType != 0) hash ^= UpgradeType.GetHashCode();
            if (AdditionalStorage != 0) hash ^= AdditionalStorage.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class AppliedItems : pb::IMessage<AppliedItems>
    {
        /// <summary>Field number for the "item" field.</summary>
        public const int ItemFieldNumber = 4;

        private static readonly pb::MessageParser<AppliedItems> _parser =
            new pb::MessageParser<AppliedItems>(() => new AppliedItems());

        private global::PokeGodar.WebAPI.GeneratedCode.AppliedItem item_;

        public AppliedItems()
        {
            OnConstruction();
        }

        public AppliedItems(AppliedItems other) : this()
        {
            Item = other.item_ != null ? other.Item.Clone() : null;
        }

        public static pb::MessageParser<AppliedItems> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[18]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.AppliedItem Item
        {
            get { return item_; }
            set { item_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AppliedItems Clone()
        {
            return new AppliedItems(this);
        }

        public bool Equals(AppliedItems other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Item, other.Item)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (item_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(Item);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (item_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
            }
            return size;
        }

        public void MergeFrom(AppliedItems other)
        {
            if (other == null)
            {
                return;
            }
            if (other.item_ != null)
            {
                if (item_ == null)
                {
                    item_ = new global::PokeGodar.WebAPI.GeneratedCode.AppliedItem();
                }
                Item.MergeFrom(other.Item);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 34:
                        {
                            if (item_ == null)
                            {
                                item_ = new global::PokeGodar.WebAPI.GeneratedCode.AppliedItem();
                            }
                            input.ReadMessage(item_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as AppliedItems);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (item_ != null) hash ^= Item.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class AppliedItem : pb::IMessage<AppliedItem>
    {
        /// <summary>Field number for the "item_type" field.</summary>
        public const int ItemTypeFieldNumber = 1;

        /// <summary>Field number for the "item_type_category" field.</summary>
        public const int ItemTypeCategoryFieldNumber = 2;

        /// <summary>Field number for the "expire_ms" field.</summary>
        public const int ExpireMsFieldNumber = 3;

        /// <summary>Field number for the "applied_ms" field.</summary>
        public const int AppliedMsFieldNumber = 4;

        private static readonly pb::MessageParser<AppliedItem> _parser =
            new pb::MessageParser<AppliedItem>(() => new AppliedItem());

        private long appliedMs_;
        private long expireMs_;
        private global::AllEnum.ItemId itemType_ = 0;
        private global::AllEnum.ItemType itemTypeCategory_ = 0;

        public AppliedItem()
        {
            OnConstruction();
        }

        public AppliedItem(AppliedItem other) : this()
        {
            itemType_ = other.itemType_;
            itemTypeCategory_ = other.itemTypeCategory_;
            expireMs_ = other.expireMs_;
            appliedMs_ = other.appliedMs_;
        }

        public static pb::MessageParser<AppliedItem> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[19]; }
        }

        public global::AllEnum.ItemId ItemType
        {
            get { return itemType_; }
            set { itemType_ = value; }
        }

        public global::AllEnum.ItemType ItemTypeCategory
        {
            get { return itemTypeCategory_; }
            set { itemTypeCategory_ = value; }
        }

        public long ExpireMs
        {
            get { return expireMs_; }
            set { expireMs_ = value; }
        }

        public long AppliedMs
        {
            get { return appliedMs_; }
            set { appliedMs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AppliedItem Clone()
        {
            return new AppliedItem(this);
        }

        public bool Equals(AppliedItem other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ItemType != other.ItemType) return false;
            if (ItemTypeCategory != other.ItemTypeCategory) return false;
            if (ExpireMs != other.ExpireMs) return false;
            if (AppliedMs != other.AppliedMs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ItemType != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)ItemType);
            }
            if (ItemTypeCategory != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)ItemTypeCategory);
            }
            if (ExpireMs != 0L)
            {
                output.WriteRawTag(24);
                output.WriteInt64(ExpireMs);
            }
            if (AppliedMs != 0L)
            {
                output.WriteRawTag(32);
                output.WriteInt64(AppliedMs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ItemType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemType);
            }
            if (ItemTypeCategory != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemTypeCategory);
            }
            if (ExpireMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpireMs);
            }
            if (AppliedMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(AppliedMs);
            }
            return size;
        }

        public void MergeFrom(AppliedItem other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ItemType != 0)
            {
                ItemType = other.ItemType;
            }
            if (other.ItemTypeCategory != 0)
            {
                ItemTypeCategory = other.ItemTypeCategory;
            }
            if (other.ExpireMs != 0L)
            {
                ExpireMs = other.ExpireMs;
            }
            if (other.AppliedMs != 0L)
            {
                AppliedMs = other.AppliedMs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            itemType_ = (global::AllEnum.ItemId)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            itemTypeCategory_ = (global::AllEnum.ItemType)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            ExpireMs = input.ReadInt64();
                            break;
                        }
                    case 32:
                        {
                            AppliedMs = input.ReadInt64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as AppliedItem);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ItemType != 0) hash ^= ItemType.GetHashCode();
            if (ItemTypeCategory != 0) hash ^= ItemTypeCategory.GetHashCode();
            if (ExpireMs != 0L) hash ^= ExpireMs.GetHashCode();
            if (AppliedMs != 0L) hash ^= AppliedMs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EggIncubators : pb::IMessage<EggIncubators>
    {
        /// <summary>Field number for the "egg_incubator" field.</summary>
        public const int EggIncubatorFieldNumber = 1;

        private static readonly pb::MessageParser<EggIncubators> _parser =
            new pb::MessageParser<EggIncubators>(() => new EggIncubators());

        private global::PokeGodar.WebAPI.GeneratedCode.EggIncubator eggIncubator_;

        public EggIncubators()
        {
            OnConstruction();
        }

        public EggIncubators(EggIncubators other) : this()
        {
            EggIncubator = other.eggIncubator_ != null ? other.EggIncubator.Clone() : null;
        }

        public static pb::MessageParser<EggIncubators> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[20]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.EggIncubator EggIncubator
        {
            get { return eggIncubator_; }
            set { eggIncubator_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EggIncubators Clone()
        {
            return new EggIncubators(this);
        }

        public bool Equals(EggIncubators other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(EggIncubator, other.EggIncubator)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (eggIncubator_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(EggIncubator);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (eggIncubator_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubator);
            }
            return size;
        }

        public void MergeFrom(EggIncubators other)
        {
            if (other == null)
            {
                return;
            }
            if (other.eggIncubator_ != null)
            {
                if (eggIncubator_ == null)
                {
                    eggIncubator_ = new global::PokeGodar.WebAPI.GeneratedCode.EggIncubator();
                }
                EggIncubator.MergeFrom(other.EggIncubator);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            if (eggIncubator_ == null)
                            {
                                eggIncubator_ = new global::PokeGodar.WebAPI.GeneratedCode.EggIncubator();
                            }
                            input.ReadMessage(eggIncubator_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EggIncubators);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (eggIncubator_ != null) hash ^= EggIncubator.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EggIncubator : pb::IMessage<EggIncubator>
    {
        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;

        /// <summary>Field number for the "item_type" field.</summary>
        public const int ItemTypeFieldNumber = 2;

        /// <summary>Field number for the "incubator_type" field.</summary>
        public const int IncubatorTypeFieldNumber = 3;

        /// <summary>Field number for the "uses_remaining" field.</summary>
        public const int UsesRemainingFieldNumber = 4;

        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 5;

        /// <summary>Field number for the "start_km_walked" field.</summary>
        public const int StartKmWalkedFieldNumber = 6;

        /// <summary>Field number for the "target_km_walked" field.</summary>
        public const int TargetKmWalkedFieldNumber = 7;

        private static readonly pb::MessageParser<EggIncubator> _parser =
            new pb::MessageParser<EggIncubator>(() => new EggIncubator());

        private global::AllEnum.EggIncubatorType incubatorType_ = 0;
        private string itemId_ = "";
        private global::AllEnum.ItemType itemType_ = 0;
        private long pokemonId_;
        private double startKmWalked_;
        private double targetKmWalked_;
        private int usesRemaining_;

        public EggIncubator()
        {
            OnConstruction();
        }

        public EggIncubator(EggIncubator other) : this()
        {
            itemId_ = other.itemId_;
            itemType_ = other.itemType_;
            incubatorType_ = other.incubatorType_;
            usesRemaining_ = other.usesRemaining_;
            pokemonId_ = other.pokemonId_;
            startKmWalked_ = other.startKmWalked_;
            targetKmWalked_ = other.targetKmWalked_;
        }

        public static pb::MessageParser<EggIncubator> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[21]; }
        }

        public string ItemId
        {
            get { return itemId_; }
            set { itemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::AllEnum.ItemType ItemType
        {
            get { return itemType_; }
            set { itemType_ = value; }
        }

        public global::AllEnum.EggIncubatorType IncubatorType
        {
            get { return incubatorType_; }
            set { incubatorType_ = value; }
        }

        public int UsesRemaining
        {
            get { return usesRemaining_; }
            set { usesRemaining_ = value; }
        }

        /// <summary>
        ///     TODO: Check if is PokemonType
        /// </summary>
        public long PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        public double StartKmWalked
        {
            get { return startKmWalked_; }
            set { startKmWalked_ = value; }
        }

        public double TargetKmWalked
        {
            get { return targetKmWalked_; }
            set { targetKmWalked_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EggIncubator Clone()
        {
            return new EggIncubator(this);
        }

        public bool Equals(EggIncubator other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ItemId != other.ItemId) return false;
            if (ItemType != other.ItemType) return false;
            if (IncubatorType != other.IncubatorType) return false;
            if (UsesRemaining != other.UsesRemaining) return false;
            if (PokemonId != other.PokemonId) return false;
            if (StartKmWalked != other.StartKmWalked) return false;
            if (TargetKmWalked != other.TargetKmWalked) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ItemId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(ItemId);
            }
            if (ItemType != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)ItemType);
            }
            if (IncubatorType != 0)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)IncubatorType);
            }
            if (UsesRemaining != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(UsesRemaining);
            }
            if (PokemonId != 0L)
            {
                output.WriteRawTag(40);
                output.WriteInt64(PokemonId);
            }
            if (StartKmWalked != 0D)
            {
                output.WriteRawTag(49);
                output.WriteDouble(StartKmWalked);
            }
            if (TargetKmWalked != 0D)
            {
                output.WriteRawTag(57);
                output.WriteDouble(TargetKmWalked);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ItemId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemId);
            }
            if (ItemType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemType);
            }
            if (IncubatorType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)IncubatorType);
            }
            if (UsesRemaining != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(UsesRemaining);
            }
            if (PokemonId != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(PokemonId);
            }
            if (StartKmWalked != 0D)
            {
                size += 1 + 8;
            }
            if (TargetKmWalked != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(EggIncubator other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ItemId.Length != 0)
            {
                ItemId = other.ItemId;
            }
            if (other.ItemType != 0)
            {
                ItemType = other.ItemType;
            }
            if (other.IncubatorType != 0)
            {
                IncubatorType = other.IncubatorType;
            }
            if (other.UsesRemaining != 0)
            {
                UsesRemaining = other.UsesRemaining;
            }
            if (other.PokemonId != 0L)
            {
                PokemonId = other.PokemonId;
            }
            if (other.StartKmWalked != 0D)
            {
                StartKmWalked = other.StartKmWalked;
            }
            if (other.TargetKmWalked != 0D)
            {
                TargetKmWalked = other.TargetKmWalked;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            ItemId = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            itemType_ = (global::AllEnum.ItemType)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            incubatorType_ = (global::AllEnum.EggIncubatorType)input.ReadEnum();
                            break;
                        }
                    case 32:
                        {
                            UsesRemaining = input.ReadInt32();
                            break;
                        }
                    case 40:
                        {
                            PokemonId = input.ReadInt64();
                            break;
                        }
                    case 49:
                        {
                            StartKmWalked = input.ReadDouble();
                            break;
                        }
                    case 57:
                        {
                            TargetKmWalked = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EggIncubator);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ItemId.Length != 0) hash ^= ItemId.GetHashCode();
            if (ItemType != 0) hash ^= ItemType.GetHashCode();
            if (IncubatorType != 0) hash ^= IncubatorType.GetHashCode();
            if (UsesRemaining != 0) hash ^= UsesRemaining.GetHashCode();
            if (PokemonId != 0L) hash ^= PokemonId.GetHashCode();
            if (StartKmWalked != 0D) hash ^= StartKmWalked.GetHashCode();
            if (TargetKmWalked != 0D) hash ^= TargetKmWalked.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PokemonFamily : pb::IMessage<PokemonFamily>
    {
        /// <summary>Field number for the "family_id" field.</summary>
        public const int FamilyIdFieldNumber = 1;

        /// <summary>Field number for the "candy" field.</summary>
        public const int CandyFieldNumber = 2;

        private static readonly pb::MessageParser<PokemonFamily> _parser =
            new pb::MessageParser<PokemonFamily>(() => new PokemonFamily());

        private int candy_;
        private global::AllEnum.PokemonFamilyId familyId_ = 0;

        public PokemonFamily()
        {
            OnConstruction();
        }

        public PokemonFamily(PokemonFamily other) : this()
        {
            familyId_ = other.familyId_;
            candy_ = other.candy_;
        }

        public static pb::MessageParser<PokemonFamily> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[22]; }
        }

        public global::AllEnum.PokemonFamilyId FamilyId
        {
            get { return familyId_; }
            set { familyId_ = value; }
        }

        public int Candy
        {
            get { return candy_; }
            set { candy_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PokemonFamily Clone()
        {
            return new PokemonFamily(this);
        }

        public bool Equals(PokemonFamily other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (FamilyId != other.FamilyId) return false;
            if (Candy != other.Candy) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (FamilyId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)FamilyId);
            }
            if (Candy != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Candy);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (FamilyId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)FamilyId);
            }
            if (Candy != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Candy);
            }
            return size;
        }

        public void MergeFrom(PokemonFamily other)
        {
            if (other == null)
            {
                return;
            }
            if (other.FamilyId != 0)
            {
                FamilyId = other.FamilyId;
            }
            if (other.Candy != 0)
            {
                Candy = other.Candy;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            familyId_ = (global::AllEnum.PokemonFamilyId)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            Candy = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PokemonFamily);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (FamilyId != 0) hash ^= FamilyId.GetHashCode();
            if (Candy != 0) hash ^= Candy.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GetMapObjectsRequest : pb::IMessage<GetMapObjectsRequest>
    {
        /// <summary>Field number for the "cell_id" field.</summary>
        public const int CellIdFieldNumber = 1;

        /// <summary>Field number for the "since_timestamp_ms" field.</summary>
        public const int SinceTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 3;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 4;

        private static readonly pb::MessageParser<GetMapObjectsRequest> _parser =
            new pb::MessageParser<GetMapObjectsRequest>(() => new GetMapObjectsRequest());

        private pb::ByteString cellId_ = pb::ByteString.Empty;
        private double latitude_;
        private double longitude_;
        private pb::ByteString sinceTimestampMs_ = pb::ByteString.Empty;

        public GetMapObjectsRequest()
        {
            OnConstruction();
        }

        public GetMapObjectsRequest(GetMapObjectsRequest other) : this()
        {
            cellId_ = other.cellId_;
            sinceTimestampMs_ = other.sinceTimestampMs_;
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
        }

        public static pb::MessageParser<GetMapObjectsRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[23]; }
        }

        public pb::ByteString CellId
        {
            get { return cellId_; }
            set { cellId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public pb::ByteString SinceTimestampMs
        {
            get { return sinceTimestampMs_; }
            set { sinceTimestampMs_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetMapObjectsRequest Clone()
        {
            return new GetMapObjectsRequest(this);
        }

        public bool Equals(GetMapObjectsRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (CellId != other.CellId) return false;
            if (SinceTimestampMs != other.SinceTimestampMs) return false;
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (CellId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(CellId);
            }
            if (SinceTimestampMs.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteBytes(SinceTimestampMs);
            }
            if (Latitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(Longitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (CellId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(CellId);
            }
            if (SinceTimestampMs.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(SinceTimestampMs);
            }
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(GetMapObjectsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.CellId.Length != 0)
            {
                CellId = other.CellId;
            }
            if (other.SinceTimestampMs.Length != 0)
            {
                SinceTimestampMs = other.SinceTimestampMs;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            CellId = input.ReadBytes();
                            break;
                        }
                    case 18:
                        {
                            SinceTimestampMs = input.ReadBytes();
                            break;
                        }
                    case 25:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 33:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GetMapObjectsRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (CellId.Length != 0) hash ^= CellId.GetHashCode();
            if (SinceTimestampMs.Length != 0) hash ^= SinceTimestampMs.GetHashCode();
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GetMapObjectsResponse : pb::IMessage<GetMapObjectsResponse>
    {
        /// <summary>Field number for the "map_cells" field.</summary>
        public const int MapCellsFieldNumber = 1;

        /// <summary>Field number for the "status" field.</summary>
        public const int StatusFieldNumber = 2;

        private static readonly pb::MessageParser<GetMapObjectsResponse> _parser =
            new pb::MessageParser<GetMapObjectsResponse>(() => new GetMapObjectsResponse());

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.MapCell>
            _repeated_mapCells_codec
                = pb::FieldCodec.ForMessage(10, global::PokeGodar.WebAPI.GeneratedCode.MapCell.Parser);

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.MapCell> mapCells_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.MapCell>();

        private global::AllEnum.MapObjectsStatus status_ = 0;

        public GetMapObjectsResponse()
        {
            OnConstruction();
        }

        public GetMapObjectsResponse(GetMapObjectsResponse other) : this()
        {
            mapCells_ = other.mapCells_.Clone();
            status_ = other.status_;
        }

        public static pb::MessageParser<GetMapObjectsResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[24]; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.MapCell> MapCells
        {
            get { return mapCells_; }
        }

        public global::AllEnum.MapObjectsStatus Status
        {
            get { return status_; }
            set { status_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetMapObjectsResponse Clone()
        {
            return new GetMapObjectsResponse(this);
        }

        public bool Equals(GetMapObjectsResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!mapCells_.Equals(other.mapCells_)) return false;
            if (Status != other.Status) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            mapCells_.WriteTo(output, _repeated_mapCells_codec);
            if (Status != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)Status);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            size += mapCells_.CalculateSize(_repeated_mapCells_codec);
            if (Status != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Status);
            }
            return size;
        }

        public void MergeFrom(GetMapObjectsResponse other)
        {
            if (other == null)
            {
                return;
            }
            mapCells_.Add(other.mapCells_);
            if (other.Status != 0)
            {
                Status = other.Status;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            mapCells_.AddEntriesFrom(input, _repeated_mapCells_codec);
                            break;
                        }
                    case 16:
                        {
                            status_ = (global::AllEnum.MapObjectsStatus)input.ReadEnum();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GetMapObjectsResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= mapCells_.GetHashCode();
            if (Status != 0) hash ^= Status.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class MapCell : pb::IMessage<MapCell>
    {
        /// <summary>Field number for the "s2_cell_id" field.</summary>
        public const int S2CellIdFieldNumber = 1;

        /// <summary>Field number for the "current_timestamp_ms" field.</summary>
        public const int CurrentTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "forts" field.</summary>
        public const int FortsFieldNumber = 3;

        /// <summary>Field number for the "spawn_points" field.</summary>
        public const int SpawnPointsFieldNumber = 4;

        /// <summary>Field number for the "deleted_objects" field.</summary>
        public const int DeletedObjectsFieldNumber = 6;

        /// <summary>Field number for the "is_truncated_list" field.</summary>
        public const int IsTruncatedListFieldNumber = 7;

        /// <summary>Field number for the "fort_summaries" field.</summary>
        public const int FortSummariesFieldNumber = 8;

        /// <summary>Field number for the "decimated_spawn_points" field.</summary>
        public const int DecimatedSpawnPointsFieldNumber = 9;

        /// <summary>Field number for the "wild_pokemons" field.</summary>
        public const int WildPokemonsFieldNumber = 5;

        /// <summary>Field number for the "catchable_pokemons" field.</summary>
        public const int CatchablePokemonsFieldNumber = 10;

        /// <summary>Field number for the "nearby_pokemons" field.</summary>
        public const int NearbyPokemonsFieldNumber = 11;

        private static readonly pb::MessageParser<MapCell> _parser = new pb::MessageParser<MapCell>(() => new MapCell());

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.FortData> _repeated_forts_codec
            = pb::FieldCodec.ForMessage(26, global::PokeGodar.WebAPI.GeneratedCode.FortData.Parser);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint>
            _repeated_spawnPoints_codec
                = pb::FieldCodec.ForMessage(34, global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint.Parser);

        private static readonly pb::FieldCodec<string> _repeated_deletedObjects_codec
            = pb::FieldCodec.ForString(50);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.FortSummary>
            _repeated_fortSummaries_codec
                = pb::FieldCodec.ForMessage(66, global::PokeGodar.WebAPI.GeneratedCode.FortSummary.Parser);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint>
            _repeated_decimatedSpawnPoints_codec
                = pb::FieldCodec.ForMessage(74, global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint.Parser);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon>
            _repeated_wildPokemons_codec
                = pb::FieldCodec.ForMessage(42, global::PokeGodar.WebAPI.GeneratedCode.WildPokemon.Parser);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.MapPokemon>
            _repeated_catchablePokemons_codec
                = pb::FieldCodec.ForMessage(82, global::PokeGodar.WebAPI.GeneratedCode.MapPokemon.Parser);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.NearbyPokemon>
            _repeated_nearbyPokemons_codec
                = pb::FieldCodec.ForMessage(90, global::PokeGodar.WebAPI.GeneratedCode.NearbyPokemon.Parser);

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.MapPokemon> catchablePokemons_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.MapPokemon>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint> decimatedSpawnPoints_
            = new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint>();

        private readonly pbc::RepeatedField<string> deletedObjects_ = new pbc::RepeatedField<string>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortData> forts_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortData>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortSummary> fortSummaries_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortSummary>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.NearbyPokemon> nearbyPokemons_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.NearbyPokemon>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint> spawnPoints_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon> wildPokemons_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon>();

        private long currentTimestampMs_;
        private bool isTruncatedList_;
        private ulong s2CellId_;

        public MapCell()
        {
            OnConstruction();
        }

        public MapCell(MapCell other) : this()
        {
            s2CellId_ = other.s2CellId_;
            currentTimestampMs_ = other.currentTimestampMs_;
            forts_ = other.forts_.Clone();
            spawnPoints_ = other.spawnPoints_.Clone();
            deletedObjects_ = other.deletedObjects_.Clone();
            isTruncatedList_ = other.isTruncatedList_;
            fortSummaries_ = other.fortSummaries_.Clone();
            decimatedSpawnPoints_ = other.decimatedSpawnPoints_.Clone();
            wildPokemons_ = other.wildPokemons_.Clone();
            catchablePokemons_ = other.catchablePokemons_.Clone();
            nearbyPokemons_ = other.nearbyPokemons_.Clone();
        }

        public static pb::MessageParser<MapCell> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[25]; }
        }

        /// <summary>
        ///     S2 geographic area that the cell covers (http://s2map.com/)
        ///     (https://code.google.com/archive/p/s2-geometry-library/)
        /// </summary>
        public ulong S2CellId
        {
            get { return s2CellId_; }
            set { s2CellId_ = value; }
        }

        public long CurrentTimestampMs
        {
            get { return currentTimestampMs_; }
            set { currentTimestampMs_ = value; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortData> Forts
        {
            get { return forts_; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint> SpawnPoints
        {
            get { return spawnPoints_; }
        }

        public pbc::RepeatedField<string> DeletedObjects
        {
            get { return deletedObjects_; }
        }

        public bool IsTruncatedList
        {
            get { return isTruncatedList_; }
            set { isTruncatedList_ = value; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortSummary> FortSummaries
        {
            get { return fortSummaries_; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.SpawnPoint> DecimatedSpawnPoints
        {
            get { return decimatedSpawnPoints_; }
        }

        /// <summary>
        ///     Pokemon within 2 steps or less.
        /// </summary>
        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon> WildPokemons
        {
            get { return wildPokemons_; }
        }

        /// <summary>
        ///     Pokemon within 1 step or none.
        /// </summary>
        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.MapPokemon> CatchablePokemons
        {
            get { return catchablePokemons_; }
        }

        /// <summary>
        ///     Pokemon farther away than 2 steps, but still in the area.
        /// </summary>
        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.NearbyPokemon> NearbyPokemons
        {
            get { return nearbyPokemons_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MapCell Clone()
        {
            return new MapCell(this);
        }

        public bool Equals(MapCell other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (S2CellId != other.S2CellId) return false;
            if (CurrentTimestampMs != other.CurrentTimestampMs) return false;
            if (!forts_.Equals(other.forts_)) return false;
            if (!spawnPoints_.Equals(other.spawnPoints_)) return false;
            if (!deletedObjects_.Equals(other.deletedObjects_)) return false;
            if (IsTruncatedList != other.IsTruncatedList) return false;
            if (!fortSummaries_.Equals(other.fortSummaries_)) return false;
            if (!decimatedSpawnPoints_.Equals(other.decimatedSpawnPoints_)) return false;
            if (!wildPokemons_.Equals(other.wildPokemons_)) return false;
            if (!catchablePokemons_.Equals(other.catchablePokemons_)) return false;
            if (!nearbyPokemons_.Equals(other.nearbyPokemons_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (S2CellId != 0UL)
            {
                output.WriteRawTag(8);
                output.WriteUInt64(S2CellId);
            }
            if (CurrentTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(CurrentTimestampMs);
            }
            forts_.WriteTo(output, _repeated_forts_codec);
            spawnPoints_.WriteTo(output, _repeated_spawnPoints_codec);
            wildPokemons_.WriteTo(output, _repeated_wildPokemons_codec);
            deletedObjects_.WriteTo(output, _repeated_deletedObjects_codec);
            if (IsTruncatedList != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(IsTruncatedList);
            }
            fortSummaries_.WriteTo(output, _repeated_fortSummaries_codec);
            decimatedSpawnPoints_.WriteTo(output, _repeated_decimatedSpawnPoints_codec);
            catchablePokemons_.WriteTo(output, _repeated_catchablePokemons_codec);
            nearbyPokemons_.WriteTo(output, _repeated_nearbyPokemons_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (S2CellId != 0UL)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt64Size(S2CellId);
            }
            if (CurrentTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentTimestampMs);
            }
            size += forts_.CalculateSize(_repeated_forts_codec);
            size += spawnPoints_.CalculateSize(_repeated_spawnPoints_codec);
            size += deletedObjects_.CalculateSize(_repeated_deletedObjects_codec);
            if (IsTruncatedList != false)
            {
                size += 1 + 1;
            }
            size += fortSummaries_.CalculateSize(_repeated_fortSummaries_codec);
            size += decimatedSpawnPoints_.CalculateSize(_repeated_decimatedSpawnPoints_codec);
            size += wildPokemons_.CalculateSize(_repeated_wildPokemons_codec);
            size += catchablePokemons_.CalculateSize(_repeated_catchablePokemons_codec);
            size += nearbyPokemons_.CalculateSize(_repeated_nearbyPokemons_codec);
            return size;
        }

        public void MergeFrom(MapCell other)
        {
            if (other == null)
            {
                return;
            }
            if (other.S2CellId != 0UL)
            {
                S2CellId = other.S2CellId;
            }
            if (other.CurrentTimestampMs != 0L)
            {
                CurrentTimestampMs = other.CurrentTimestampMs;
            }
            forts_.Add(other.forts_);
            spawnPoints_.Add(other.spawnPoints_);
            deletedObjects_.Add(other.deletedObjects_);
            if (other.IsTruncatedList != false)
            {
                IsTruncatedList = other.IsTruncatedList;
            }
            fortSummaries_.Add(other.fortSummaries_);
            decimatedSpawnPoints_.Add(other.decimatedSpawnPoints_);
            wildPokemons_.Add(other.wildPokemons_);
            catchablePokemons_.Add(other.catchablePokemons_);
            nearbyPokemons_.Add(other.nearbyPokemons_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            S2CellId = input.ReadUInt64();
                            break;
                        }
                    case 16:
                        {
                            CurrentTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 26:
                        {
                            forts_.AddEntriesFrom(input, _repeated_forts_codec);
                            break;
                        }
                    case 34:
                        {
                            spawnPoints_.AddEntriesFrom(input, _repeated_spawnPoints_codec);
                            break;
                        }
                    case 42:
                        {
                            wildPokemons_.AddEntriesFrom(input, _repeated_wildPokemons_codec);
                            break;
                        }
                    case 50:
                        {
                            deletedObjects_.AddEntriesFrom(input, _repeated_deletedObjects_codec);
                            break;
                        }
                    case 56:
                        {
                            IsTruncatedList = input.ReadBool();
                            break;
                        }
                    case 66:
                        {
                            fortSummaries_.AddEntriesFrom(input, _repeated_fortSummaries_codec);
                            break;
                        }
                    case 74:
                        {
                            decimatedSpawnPoints_.AddEntriesFrom(input, _repeated_decimatedSpawnPoints_codec);
                            break;
                        }
                    case 82:
                        {
                            catchablePokemons_.AddEntriesFrom(input, _repeated_catchablePokemons_codec);
                            break;
                        }
                    case 90:
                        {
                            nearbyPokemons_.AddEntriesFrom(input, _repeated_nearbyPokemons_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as MapCell);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (S2CellId != 0UL) hash ^= S2CellId.GetHashCode();
            if (CurrentTimestampMs != 0L) hash ^= CurrentTimestampMs.GetHashCode();
            hash ^= forts_.GetHashCode();
            hash ^= spawnPoints_.GetHashCode();
            hash ^= deletedObjects_.GetHashCode();
            if (IsTruncatedList != false) hash ^= IsTruncatedList.GetHashCode();
            hash ^= fortSummaries_.GetHashCode();
            hash ^= decimatedSpawnPoints_.GetHashCode();
            hash ^= wildPokemons_.GetHashCode();
            hash ^= catchablePokemons_.GetHashCode();
            hash ^= nearbyPokemons_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortData : pb::IMessage<FortData>
    {
        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;

        /// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
        public const int LastModifiedTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 3;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 4;

        /// <summary>Field number for the "enabled" field.</summary>
        public const int EnabledFieldNumber = 8;

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 9;

        /// <summary>Field number for the "owned_by_team" field.</summary>
        public const int OwnedByTeamFieldNumber = 5;

        /// <summary>Field number for the "guard_pokemon_id" field.</summary>
        public const int GuardPokemonIdFieldNumber = 6;

        /// <summary>Field number for the "guard_pokemon_cp" field.</summary>
        public const int GuardPokemonCpFieldNumber = 7;

        /// <summary>Field number for the "gym_points" field.</summary>
        public const int GymPointsFieldNumber = 10;

        /// <summary>Field number for the "is_in_battle" field.</summary>
        public const int IsInBattleFieldNumber = 11;

        /// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
        public const int CooldownCompleteTimestampMsFieldNumber = 14;

        /// <summary>Field number for the "sponsor" field.</summary>
        public const int SponsorFieldNumber = 15;

        /// <summary>Field number for the "rendering_type" field.</summary>
        public const int RenderingTypeFieldNumber = 16;

        /// <summary>Field number for the "active_fort_modifier" field.</summary>
        public const int ActiveFortModifierFieldNumber = 12;

        /// <summary>Field number for the "lure_info" field.</summary>
        public const int LureInfoFieldNumber = 13;

        private static readonly pb::MessageParser<FortData> _parser =
            new pb::MessageParser<FortData>(() => new FortData());

        private pb::ByteString activeFortModifier_ = pb::ByteString.Empty;
        private long cooldownCompleteTimestampMs_;
        private bool enabled_;
        private int guardPokemonCp_;
        private global::AllEnum.PokemonId guardPokemonId_ = 0;
        private long gymPoints_;
        private string id_ = "";
        private bool isInBattle_;
        private long lastModifiedTimestampMs_;
        private double latitude_;
        private double longitude_;
        private global::PokeGodar.WebAPI.GeneratedCode.FortLureInfo lureInfo_;
        private global::AllEnum.TeamColor ownedByTeam_ = 0;
        private global::AllEnum.FortRenderingType renderingType_ = 0;
        private global::AllEnum.FortSponsor sponsor_ = 0;
        private global::AllEnum.FortType type_ = 0;

        public FortData()
        {
            OnConstruction();
        }

        public FortData(FortData other) : this()
        {
            id_ = other.id_;
            lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
            enabled_ = other.enabled_;
            type_ = other.type_;
            ownedByTeam_ = other.ownedByTeam_;
            guardPokemonId_ = other.guardPokemonId_;
            guardPokemonCp_ = other.guardPokemonCp_;
            gymPoints_ = other.gymPoints_;
            isInBattle_ = other.isInBattle_;
            cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
            sponsor_ = other.sponsor_;
            renderingType_ = other.renderingType_;
            activeFortModifier_ = other.activeFortModifier_;
            LureInfo = other.lureInfo_ != null ? other.LureInfo.Clone() : null;
        }

        public static pb::MessageParser<FortData> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[26]; }
        }

        public string Id
        {
            get { return id_; }
            set { id_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public long LastModifiedTimestampMs
        {
            get { return lastModifiedTimestampMs_; }
            set { lastModifiedTimestampMs_ = value; }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        public bool Enabled
        {
            get { return enabled_; }
            set { enabled_ = value; }
        }

        public global::AllEnum.FortType Type
        {
            get { return type_; }
            set { type_ = value; }
        }

        /// <summary>
        ///     Team that owns the gym
        /// </summary>
        public global::AllEnum.TeamColor OwnedByTeam
        {
            get { return ownedByTeam_; }
            set { ownedByTeam_ = value; }
        }

        /// <summary>
        ///     Highest CP Pokemon at the gym
        /// </summary>
        public global::AllEnum.PokemonId GuardPokemonId
        {
            get { return guardPokemonId_; }
            set { guardPokemonId_ = value; }
        }

        public int GuardPokemonCp
        {
            get { return guardPokemonCp_; }
            set { guardPokemonCp_ = value; }
        }

        /// <summary>
        ///     Prestigate / experience of the gym
        /// </summary>
        public long GymPoints
        {
            get { return gymPoints_; }
            set { gymPoints_ = value; }
        }

        /// <summary>
        ///     Whether someone is battling at the gym currently
        /// </summary>
        public bool IsInBattle
        {
            get { return isInBattle_; }
            set { isInBattle_ = value; }
        }

        /// <summary>
        ///     Timestamp when the pokestop can be activated again to get items / xp
        /// </summary>
        public long CooldownCompleteTimestampMs
        {
            get { return cooldownCompleteTimestampMs_; }
            set { cooldownCompleteTimestampMs_ = value; }
        }

        public global::AllEnum.FortSponsor Sponsor
        {
            get { return sponsor_; }
            set { sponsor_ = value; }
        }

        public global::AllEnum.FortRenderingType RenderingType
        {
            get { return renderingType_; }
            set { renderingType_ = value; }
        }

        /// <summary>
        ///     Might represent the type of item applied to the pokestop, right now only lures can be applied
        /// </summary>
        public pb::ByteString ActiveFortModifier
        {
            get { return activeFortModifier_; }
            set { activeFortModifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.FortLureInfo LureInfo
        {
            get { return lureInfo_; }
            set { lureInfo_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortData Clone()
        {
            return new FortData(this);
        }

        public bool Equals(FortData other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Id != other.Id) return false;
            if (LastModifiedTimestampMs != other.LastModifiedTimestampMs) return false;
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            if (Enabled != other.Enabled) return false;
            if (Type != other.Type) return false;
            if (OwnedByTeam != other.OwnedByTeam) return false;
            if (GuardPokemonId != other.GuardPokemonId) return false;
            if (GuardPokemonCp != other.GuardPokemonCp) return false;
            if (GymPoints != other.GymPoints) return false;
            if (IsInBattle != other.IsInBattle) return false;
            if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs) return false;
            if (Sponsor != other.Sponsor) return false;
            if (RenderingType != other.RenderingType) return false;
            if (ActiveFortModifier != other.ActiveFortModifier) return false;
            if (!Equals(LureInfo, other.LureInfo)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Id.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Id);
            }
            if (LastModifiedTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(LastModifiedTimestampMs);
            }
            if (Latitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(Longitude);
            }
            if (OwnedByTeam != 0)
            {
                output.WriteRawTag(40);
                output.WriteEnum((int)OwnedByTeam);
            }
            if (GuardPokemonId != 0)
            {
                output.WriteRawTag(48);
                output.WriteEnum((int)GuardPokemonId);
            }
            if (GuardPokemonCp != 0)
            {
                output.WriteRawTag(56);
                output.WriteInt32(GuardPokemonCp);
            }
            if (Enabled != false)
            {
                output.WriteRawTag(64);
                output.WriteBool(Enabled);
            }
            if (Type != 0)
            {
                output.WriteRawTag(72);
                output.WriteEnum((int)Type);
            }
            if (GymPoints != 0L)
            {
                output.WriteRawTag(80);
                output.WriteInt64(GymPoints);
            }
            if (IsInBattle != false)
            {
                output.WriteRawTag(88);
                output.WriteBool(IsInBattle);
            }
            if (ActiveFortModifier.Length != 0)
            {
                output.WriteRawTag(98);
                output.WriteBytes(ActiveFortModifier);
            }
            if (lureInfo_ != null)
            {
                output.WriteRawTag(106);
                output.WriteMessage(LureInfo);
            }
            if (CooldownCompleteTimestampMs != 0L)
            {
                output.WriteRawTag(112);
                output.WriteInt64(CooldownCompleteTimestampMs);
            }
            if (Sponsor != 0)
            {
                output.WriteRawTag(120);
                output.WriteEnum((int)Sponsor);
            }
            if (RenderingType != 0)
            {
                output.WriteRawTag(128, 1);
                output.WriteEnum((int)RenderingType);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Id.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
            }
            if (LastModifiedTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
            }
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            if (Enabled != false)
            {
                size += 1 + 1;
            }
            if (Type != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
            }
            if (OwnedByTeam != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)OwnedByTeam);
            }
            if (GuardPokemonId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)GuardPokemonId);
            }
            if (GuardPokemonCp != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(GuardPokemonCp);
            }
            if (GymPoints != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(GymPoints);
            }
            if (IsInBattle != false)
            {
                size += 1 + 1;
            }
            if (CooldownCompleteTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
            }
            if (Sponsor != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Sponsor);
            }
            if (RenderingType != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeEnumSize((int)RenderingType);
            }
            if (ActiveFortModifier.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(ActiveFortModifier);
            }
            if (lureInfo_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(LureInfo);
            }
            return size;
        }

        public void MergeFrom(FortData other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Id.Length != 0)
            {
                Id = other.Id;
            }
            if (other.LastModifiedTimestampMs != 0L)
            {
                LastModifiedTimestampMs = other.LastModifiedTimestampMs;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
            if (other.Enabled != false)
            {
                Enabled = other.Enabled;
            }
            if (other.Type != 0)
            {
                Type = other.Type;
            }
            if (other.OwnedByTeam != 0)
            {
                OwnedByTeam = other.OwnedByTeam;
            }
            if (other.GuardPokemonId != 0)
            {
                GuardPokemonId = other.GuardPokemonId;
            }
            if (other.GuardPokemonCp != 0)
            {
                GuardPokemonCp = other.GuardPokemonCp;
            }
            if (other.GymPoints != 0L)
            {
                GymPoints = other.GymPoints;
            }
            if (other.IsInBattle != false)
            {
                IsInBattle = other.IsInBattle;
            }
            if (other.CooldownCompleteTimestampMs != 0L)
            {
                CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
            }
            if (other.Sponsor != 0)
            {
                Sponsor = other.Sponsor;
            }
            if (other.RenderingType != 0)
            {
                RenderingType = other.RenderingType;
            }
            if (other.ActiveFortModifier.Length != 0)
            {
                ActiveFortModifier = other.ActiveFortModifier;
            }
            if (other.lureInfo_ != null)
            {
                if (lureInfo_ == null)
                {
                    lureInfo_ = new global::PokeGodar.WebAPI.GeneratedCode.FortLureInfo();
                }
                LureInfo.MergeFrom(other.LureInfo);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            Id = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            LastModifiedTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 25:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 33:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                    case 40:
                        {
                            ownedByTeam_ = (global::AllEnum.TeamColor)input.ReadEnum();
                            break;
                        }
                    case 48:
                        {
                            guardPokemonId_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 56:
                        {
                            GuardPokemonCp = input.ReadInt32();
                            break;
                        }
                    case 64:
                        {
                            Enabled = input.ReadBool();
                            break;
                        }
                    case 72:
                        {
                            type_ = (global::AllEnum.FortType)input.ReadEnum();
                            break;
                        }
                    case 80:
                        {
                            GymPoints = input.ReadInt64();
                            break;
                        }
                    case 88:
                        {
                            IsInBattle = input.ReadBool();
                            break;
                        }
                    case 98:
                        {
                            ActiveFortModifier = input.ReadBytes();
                            break;
                        }
                    case 106:
                        {
                            if (lureInfo_ == null)
                            {
                                lureInfo_ = new global::PokeGodar.WebAPI.GeneratedCode.FortLureInfo();
                            }
                            input.ReadMessage(lureInfo_);
                            break;
                        }
                    case 112:
                        {
                            CooldownCompleteTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 120:
                        {
                            sponsor_ = (global::AllEnum.FortSponsor)input.ReadEnum();
                            break;
                        }
                    case 128:
                        {
                            renderingType_ = (global::AllEnum.FortRenderingType)input.ReadEnum();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortData);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Id.Length != 0) hash ^= Id.GetHashCode();
            if (LastModifiedTimestampMs != 0L) hash ^= LastModifiedTimestampMs.GetHashCode();
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            if (Enabled != false) hash ^= Enabled.GetHashCode();
            if (Type != 0) hash ^= Type.GetHashCode();
            if (OwnedByTeam != 0) hash ^= OwnedByTeam.GetHashCode();
            if (GuardPokemonId != 0) hash ^= GuardPokemonId.GetHashCode();
            if (GuardPokemonCp != 0) hash ^= GuardPokemonCp.GetHashCode();
            if (GymPoints != 0L) hash ^= GymPoints.GetHashCode();
            if (IsInBattle != false) hash ^= IsInBattle.GetHashCode();
            if (CooldownCompleteTimestampMs != 0L) hash ^= CooldownCompleteTimestampMs.GetHashCode();
            if (Sponsor != 0) hash ^= Sponsor.GetHashCode();
            if (RenderingType != 0) hash ^= RenderingType.GetHashCode();
            if (ActiveFortModifier.Length != 0) hash ^= ActiveFortModifier.GetHashCode();
            if (lureInfo_ != null) hash ^= LureInfo.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortLureInfo : pb::IMessage<FortLureInfo>
    {
        /// <summary>Field number for the "fort_id" field.</summary>
        public const int FortIdFieldNumber = 1;

        /// <summary>Field number for the "unknown2" field.</summary>
        public const int Unknown2FieldNumber = 2;

        /// <summary>Field number for the "active_pokemon_id" field.</summary>
        public const int ActivePokemonIdFieldNumber = 3;

        /// <summary>Field number for the "lure_expires_timestamp_ms" field.</summary>
        public const int LureExpiresTimestampMsFieldNumber = 4;

        private static readonly pb::MessageParser<FortLureInfo> _parser =
            new pb::MessageParser<FortLureInfo>(() => new FortLureInfo());

        private global::AllEnum.PokemonId activePokemonId_ = 0;
        private string fortId_ = "";
        private long lureExpiresTimestampMs_;
        private double unknown2_;

        public FortLureInfo()
        {
            OnConstruction();
        }

        public FortLureInfo(FortLureInfo other) : this()
        {
            fortId_ = other.fortId_;
            unknown2_ = other.unknown2_;
            activePokemonId_ = other.activePokemonId_;
            lureExpiresTimestampMs_ = other.lureExpiresTimestampMs_;
        }

        public static pb::MessageParser<FortLureInfo> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[27]; }
        }

        public string FortId
        {
            get { return fortId_; }
            set { fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public double Unknown2
        {
            get { return unknown2_; }
            set { unknown2_ = value; }
        }

        public global::AllEnum.PokemonId ActivePokemonId
        {
            get { return activePokemonId_; }
            set { activePokemonId_ = value; }
        }

        public long LureExpiresTimestampMs
        {
            get { return lureExpiresTimestampMs_; }
            set { lureExpiresTimestampMs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortLureInfo Clone()
        {
            return new FortLureInfo(this);
        }

        public bool Equals(FortLureInfo other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (FortId != other.FortId) return false;
            if (Unknown2 != other.Unknown2) return false;
            if (ActivePokemonId != other.ActivePokemonId) return false;
            if (LureExpiresTimestampMs != other.LureExpiresTimestampMs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (FortId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(FortId);
            }
            if (Unknown2 != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(Unknown2);
            }
            if (ActivePokemonId != 0)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)ActivePokemonId);
            }
            if (LureExpiresTimestampMs != 0L)
            {
                output.WriteRawTag(32);
                output.WriteInt64(LureExpiresTimestampMs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (FortId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
            }
            if (Unknown2 != 0D)
            {
                size += 1 + 8;
            }
            if (ActivePokemonId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ActivePokemonId);
            }
            if (LureExpiresTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(LureExpiresTimestampMs);
            }
            return size;
        }

        public void MergeFrom(FortLureInfo other)
        {
            if (other == null)
            {
                return;
            }
            if (other.FortId.Length != 0)
            {
                FortId = other.FortId;
            }
            if (other.Unknown2 != 0D)
            {
                Unknown2 = other.Unknown2;
            }
            if (other.ActivePokemonId != 0)
            {
                ActivePokemonId = other.ActivePokemonId;
            }
            if (other.LureExpiresTimestampMs != 0L)
            {
                LureExpiresTimestampMs = other.LureExpiresTimestampMs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            FortId = input.ReadString();
                            break;
                        }
                    case 17:
                        {
                            Unknown2 = input.ReadDouble();
                            break;
                        }
                    case 24:
                        {
                            activePokemonId_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 32:
                        {
                            LureExpiresTimestampMs = input.ReadInt64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortLureInfo);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (FortId.Length != 0) hash ^= FortId.GetHashCode();
            if (Unknown2 != 0D) hash ^= Unknown2.GetHashCode();
            if (ActivePokemonId != 0) hash ^= ActivePokemonId.GetHashCode();
            if (LureExpiresTimestampMs != 0L) hash ^= LureExpiresTimestampMs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class SpawnPoint : pb::IMessage<SpawnPoint>
    {
        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 2;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 3;

        private static readonly pb::MessageParser<SpawnPoint> _parser =
            new pb::MessageParser<SpawnPoint>(() => new SpawnPoint());

        private double latitude_;
        private double longitude_;

        public SpawnPoint()
        {
            OnConstruction();
        }

        public SpawnPoint(SpawnPoint other) : this()
        {
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
        }

        public static pb::MessageParser<SpawnPoint> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[28]; }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public SpawnPoint Clone()
        {
            return new SpawnPoint(this);
        }

        public bool Equals(SpawnPoint other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Latitude != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(Longitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(SpawnPoint other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 17:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 25:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as SpawnPoint);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortSummary : pb::IMessage<FortSummary>
    {
        /// <summary>Field number for the "fort_summary_id" field.</summary>
        public const int FortSummaryIdFieldNumber = 1;

        /// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
        public const int LastModifiedTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 3;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 4;

        private static readonly pb::MessageParser<FortSummary> _parser =
            new pb::MessageParser<FortSummary>(() => new FortSummary());

        private int fortSummaryId_;
        private int lastModifiedTimestampMs_;
        private int latitude_;
        private int longitude_;

        public FortSummary()
        {
            OnConstruction();
        }

        public FortSummary(FortSummary other) : this()
        {
            fortSummaryId_ = other.fortSummaryId_;
            lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
        }

        public static pb::MessageParser<FortSummary> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[29]; }
        }

        public int FortSummaryId
        {
            get { return fortSummaryId_; }
            set { fortSummaryId_ = value; }
        }

        public int LastModifiedTimestampMs
        {
            get { return lastModifiedTimestampMs_; }
            set { lastModifiedTimestampMs_ = value; }
        }

        public int Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public int Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortSummary Clone()
        {
            return new FortSummary(this);
        }

        public bool Equals(FortSummary other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (FortSummaryId != other.FortSummaryId) return false;
            if (LastModifiedTimestampMs != other.LastModifiedTimestampMs) return false;
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (FortSummaryId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(FortSummaryId);
            }
            if (LastModifiedTimestampMs != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(LastModifiedTimestampMs);
            }
            if (Latitude != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(Latitude);
            }
            if (Longitude != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(Longitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (FortSummaryId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(FortSummaryId);
            }
            if (LastModifiedTimestampMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(LastModifiedTimestampMs);
            }
            if (Latitude != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Latitude);
            }
            if (Longitude != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Longitude);
            }
            return size;
        }

        public void MergeFrom(FortSummary other)
        {
            if (other == null)
            {
                return;
            }
            if (other.FortSummaryId != 0)
            {
                FortSummaryId = other.FortSummaryId;
            }
            if (other.LastModifiedTimestampMs != 0)
            {
                LastModifiedTimestampMs = other.LastModifiedTimestampMs;
            }
            if (other.Latitude != 0)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0)
            {
                Longitude = other.Longitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            FortSummaryId = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            LastModifiedTimestampMs = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            Latitude = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            Longitude = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortSummary);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (FortSummaryId != 0) hash ^= FortSummaryId.GetHashCode();
            if (LastModifiedTimestampMs != 0) hash ^= LastModifiedTimestampMs.GetHashCode();
            if (Latitude != 0) hash ^= Latitude.GetHashCode();
            if (Longitude != 0) hash ^= Longitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class WildPokemon : pb::IMessage<WildPokemon>
    {
        /// <summary>Field number for the "encounter_id" field.</summary>
        public const int EncounterIdFieldNumber = 1;

        /// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
        public const int LastModifiedTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 3;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 4;

        /// <summary>Field number for the "spawnpoint_id" field.</summary>
        public const int SpawnpointIdFieldNumber = 5;

        /// <summary>Field number for the "pokemon_data" field.</summary>
        public const int PokemonDataFieldNumber = 7;

        /// <summary>Field number for the "time_till_hidden_ms" field.</summary>
        public const int TimeTillHiddenMsFieldNumber = 11;

        private static readonly pb::MessageParser<WildPokemon> _parser =
            new pb::MessageParser<WildPokemon>(() => new WildPokemon());

        private ulong encounterId_;
        private long lastModifiedTimestampMs_;
        private double latitude_;
        private double longitude_;
        private global::PokeGodar.WebAPI.GeneratedCode.PokemonData pokemonData_;
        private string spawnpointId_ = "";
        private int timeTillHiddenMs_;

        public WildPokemon()
        {
            OnConstruction();
        }

        public WildPokemon(WildPokemon other) : this()
        {
            encounterId_ = other.encounterId_;
            lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
            spawnpointId_ = other.spawnpointId_;
            PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
            timeTillHiddenMs_ = other.timeTillHiddenMs_;
        }

        public static pb::MessageParser<WildPokemon> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[30]; }
        }

        public ulong EncounterId
        {
            get { return encounterId_; }
            set { encounterId_ = value; }
        }

        public long LastModifiedTimestampMs
        {
            get { return lastModifiedTimestampMs_; }
            set { lastModifiedTimestampMs_ = value; }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        public string SpawnpointId
        {
            get { return spawnpointId_; }
            set { spawnpointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokemonData PokemonData
        {
            get { return pokemonData_; }
            set { pokemonData_ = value; }
        }

        public int TimeTillHiddenMs
        {
            get { return timeTillHiddenMs_; }
            set { timeTillHiddenMs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public WildPokemon Clone()
        {
            return new WildPokemon(this);
        }

        public bool Equals(WildPokemon other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (EncounterId != other.EncounterId) return false;
            if (LastModifiedTimestampMs != other.LastModifiedTimestampMs) return false;
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            if (SpawnpointId != other.SpawnpointId) return false;
            if (!Equals(PokemonData, other.PokemonData)) return false;
            if (TimeTillHiddenMs != other.TimeTillHiddenMs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (EncounterId != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(EncounterId);
            }
            if (LastModifiedTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(LastModifiedTimestampMs);
            }
            if (Latitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(Longitude);
            }
            if (SpawnpointId.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(SpawnpointId);
            }
            if (pokemonData_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(PokemonData);
            }
            if (TimeTillHiddenMs != 0)
            {
                output.WriteRawTag(88);
                output.WriteInt32(TimeTillHiddenMs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (EncounterId != 0UL)
            {
                size += 1 + 8;
            }
            if (LastModifiedTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
            }
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            if (SpawnpointId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnpointId);
            }
            if (pokemonData_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
            }
            if (TimeTillHiddenMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeTillHiddenMs);
            }
            return size;
        }

        public void MergeFrom(WildPokemon other)
        {
            if (other == null)
            {
                return;
            }
            if (other.EncounterId != 0UL)
            {
                EncounterId = other.EncounterId;
            }
            if (other.LastModifiedTimestampMs != 0L)
            {
                LastModifiedTimestampMs = other.LastModifiedTimestampMs;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
            if (other.SpawnpointId.Length != 0)
            {
                SpawnpointId = other.SpawnpointId;
            }
            if (other.pokemonData_ != null)
            {
                if (pokemonData_ == null)
                {
                    pokemonData_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                }
                PokemonData.MergeFrom(other.PokemonData);
            }
            if (other.TimeTillHiddenMs != 0)
            {
                TimeTillHiddenMs = other.TimeTillHiddenMs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            EncounterId = input.ReadFixed64();
                            break;
                        }
                    case 16:
                        {
                            LastModifiedTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 25:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 33:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                    case 42:
                        {
                            SpawnpointId = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            if (pokemonData_ == null)
                            {
                                pokemonData_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                            }
                            input.ReadMessage(pokemonData_);
                            break;
                        }
                    case 88:
                        {
                            TimeTillHiddenMs = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as WildPokemon);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
            if (LastModifiedTimestampMs != 0L) hash ^= LastModifiedTimestampMs.GetHashCode();
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            if (SpawnpointId.Length != 0) hash ^= SpawnpointId.GetHashCode();
            if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
            if (TimeTillHiddenMs != 0) hash ^= TimeTillHiddenMs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PokemonData : pb::IMessage<PokemonData>
    {
        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;

        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 2;

        /// <summary>Field number for the "cp" field.</summary>
        public const int CpFieldNumber = 3;

        /// <summary>Field number for the "stamina" field.</summary>
        public const int StaminaFieldNumber = 4;

        /// <summary>Field number for the "stamina_max" field.</summary>
        public const int StaminaMaxFieldNumber = 5;

        /// <summary>Field number for the "move_1" field.</summary>
        public const int Move1FieldNumber = 6;

        /// <summary>Field number for the "move_2" field.</summary>
        public const int Move2FieldNumber = 7;

        /// <summary>Field number for the "deployed_fort_id" field.</summary>
        public const int DeployedFortIdFieldNumber = 8;

        /// <summary>Field number for the "owner_name" field.</summary>
        public const int OwnerNameFieldNumber = 9;

        /// <summary>Field number for the "is_egg" field.</summary>
        public const int IsEggFieldNumber = 10;

        /// <summary>Field number for the "egg_km_walked_target" field.</summary>
        public const int EggKmWalkedTargetFieldNumber = 11;

        /// <summary>Field number for the "egg_km_walked_start" field.</summary>
        public const int EggKmWalkedStartFieldNumber = 12;

        /// <summary>Field number for the "origin" field.</summary>
        public const int OriginFieldNumber = 14;

        /// <summary>Field number for the "height_m" field.</summary>
        public const int HeightMFieldNumber = 15;

        /// <summary>Field number for the "weight_kg" field.</summary>
        public const int WeightKgFieldNumber = 16;

        /// <summary>Field number for the "individual_attack" field.</summary>
        public const int IndividualAttackFieldNumber = 17;

        /// <summary>Field number for the "individual_defense" field.</summary>
        public const int IndividualDefenseFieldNumber = 18;

        /// <summary>Field number for the "individual_stamina" field.</summary>
        public const int IndividualStaminaFieldNumber = 19;

        /// <summary>Field number for the "cp_multiplier" field.</summary>
        public const int CpMultiplierFieldNumber = 20;

        /// <summary>Field number for the "pokeball" field.</summary>
        public const int PokeballFieldNumber = 21;

        /// <summary>Field number for the "captured_cell_id" field.</summary>
        public const int CapturedCellIdFieldNumber = 22;

        /// <summary>Field number for the "battles_attacked" field.</summary>
        public const int BattlesAttackedFieldNumber = 23;

        /// <summary>Field number for the "battles_defended" field.</summary>
        public const int BattlesDefendedFieldNumber = 24;

        /// <summary>Field number for the "egg_incubator_id" field.</summary>
        public const int EggIncubatorIdFieldNumber = 25;

        /// <summary>Field number for the "creation_time_ms" field.</summary>
        public const int CreationTimeMsFieldNumber = 26;

        /// <summary>Field number for the "num_upgrades" field.</summary>
        public const int NumUpgradesFieldNumber = 27;

        /// <summary>Field number for the "additional_cp_multiplier" field.</summary>
        public const int AdditionalCpMultiplierFieldNumber = 28;

        /// <summary>Field number for the "favorite" field.</summary>
        public const int FavoriteFieldNumber = 29;

        /// <summary>Field number for the "nickname" field.</summary>
        public const int NicknameFieldNumber = 30;

        /// <summary>Field number for the "from_fort" field.</summary>
        public const int FromFortFieldNumber = 31;

        private static readonly pb::MessageParser<PokemonData> _parser =
            new pb::MessageParser<PokemonData>(() => new PokemonData());

        private int additionalCpMultiplier_;
        private int battlesAttacked_;
        private int battlesDefended_;
        private ulong capturedCellId_;
        private int cp_;
        private int cpMultiplier_;
        private ulong creationTimeMs_;
        private int deployedFortId_;
        private int eggIncubatorId_;
        private int eggKmWalkedStart_;
        private int eggKmWalkedTarget_;
        private int favorite_;
        private int fromFort_;
        private float heightM_;
        private ulong id_;
        private int individualAttack_;
        private int individualDefense_;
        private int individualStamina_;
        private bool isEgg_;
        private global::AllEnum.PokemonMove move1_ = 0;
        private global::AllEnum.PokemonMove move2_ = 0;
        private string nickname_ = "";
        private int numUpgrades_;
        private int origin_;
        private string ownerName_ = "";
        private int pokeball_;
        private global::AllEnum.PokemonId pokemonId_ = 0;
        private int stamina_;
        private int staminaMax_;
        private float weightKg_;

        public PokemonData()
        {
            OnConstruction();
        }

        public PokemonData(PokemonData other) : this()
        {
            id_ = other.id_;
            pokemonId_ = other.pokemonId_;
            cp_ = other.cp_;
            stamina_ = other.stamina_;
            staminaMax_ = other.staminaMax_;
            move1_ = other.move1_;
            move2_ = other.move2_;
            deployedFortId_ = other.deployedFortId_;
            ownerName_ = other.ownerName_;
            isEgg_ = other.isEgg_;
            eggKmWalkedTarget_ = other.eggKmWalkedTarget_;
            eggKmWalkedStart_ = other.eggKmWalkedStart_;
            origin_ = other.origin_;
            heightM_ = other.heightM_;
            weightKg_ = other.weightKg_;
            individualAttack_ = other.individualAttack_;
            individualDefense_ = other.individualDefense_;
            individualStamina_ = other.individualStamina_;
            cpMultiplier_ = other.cpMultiplier_;
            pokeball_ = other.pokeball_;
            capturedCellId_ = other.capturedCellId_;
            battlesAttacked_ = other.battlesAttacked_;
            battlesDefended_ = other.battlesDefended_;
            eggIncubatorId_ = other.eggIncubatorId_;
            creationTimeMs_ = other.creationTimeMs_;
            numUpgrades_ = other.numUpgrades_;
            additionalCpMultiplier_ = other.additionalCpMultiplier_;
            favorite_ = other.favorite_;
            nickname_ = other.nickname_;
            fromFort_ = other.fromFort_;
        }

        public static pb::MessageParser<PokemonData> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[31]; }
        }

        public ulong Id
        {
            get { return id_; }
            set { id_ = value; }
        }

        public global::AllEnum.PokemonId PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        public int Cp
        {
            get { return cp_; }
            set { cp_ = value; }
        }

        public int Stamina
        {
            get { return stamina_; }
            set { stamina_ = value; }
        }

        public int StaminaMax
        {
            get { return staminaMax_; }
            set { staminaMax_ = value; }
        }

        public global::AllEnum.PokemonMove Move1
        {
            get { return move1_; }
            set { move1_ = value; }
        }

        public global::AllEnum.PokemonMove Move2
        {
            get { return move2_; }
            set { move2_ = value; }
        }

        public int DeployedFortId
        {
            get { return deployedFortId_; }
            set { deployedFortId_ = value; }
        }

        public string OwnerName
        {
            get { return ownerName_; }
            set { ownerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public bool IsEgg
        {
            get { return isEgg_; }
            set { isEgg_ = value; }
        }

        public int EggKmWalkedTarget
        {
            get { return eggKmWalkedTarget_; }
            set { eggKmWalkedTarget_ = value; }
        }

        public int EggKmWalkedStart
        {
            get { return eggKmWalkedStart_; }
            set { eggKmWalkedStart_ = value; }
        }

        public int Origin
        {
            get { return origin_; }
            set { origin_ = value; }
        }

        public float HeightM
        {
            get { return heightM_; }
            set { heightM_ = value; }
        }

        public float WeightKg
        {
            get { return weightKg_; }
            set { weightKg_ = value; }
        }

        public int IndividualAttack
        {
            get { return individualAttack_; }
            set { individualAttack_ = value; }
        }

        public int IndividualDefense
        {
            get { return individualDefense_; }
            set { individualDefense_ = value; }
        }

        public int IndividualStamina
        {
            get { return individualStamina_; }
            set { individualStamina_ = value; }
        }

        public int CpMultiplier
        {
            get { return cpMultiplier_; }
            set { cpMultiplier_ = value; }
        }

        public int Pokeball
        {
            get { return pokeball_; }
            set { pokeball_ = value; }
        }

        public ulong CapturedCellId
        {
            get { return capturedCellId_; }
            set { capturedCellId_ = value; }
        }

        public int BattlesAttacked
        {
            get { return battlesAttacked_; }
            set { battlesAttacked_ = value; }
        }

        public int BattlesDefended
        {
            get { return battlesDefended_; }
            set { battlesDefended_ = value; }
        }

        public int EggIncubatorId
        {
            get { return eggIncubatorId_; }
            set { eggIncubatorId_ = value; }
        }

        public ulong CreationTimeMs
        {
            get { return creationTimeMs_; }
            set { creationTimeMs_ = value; }
        }

        public int NumUpgrades
        {
            get { return numUpgrades_; }
            set { numUpgrades_ = value; }
        }

        public int AdditionalCpMultiplier
        {
            get { return additionalCpMultiplier_; }
            set { additionalCpMultiplier_ = value; }
        }

        public int Favorite
        {
            get { return favorite_; }
            set { favorite_ = value; }
        }

        public string Nickname
        {
            get { return nickname_; }
            set { nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public int FromFort
        {
            get { return fromFort_; }
            set { fromFort_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PokemonData Clone()
        {
            return new PokemonData(this);
        }

        public bool Equals(PokemonData other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Id != other.Id) return false;
            if (PokemonId != other.PokemonId) return false;
            if (Cp != other.Cp) return false;
            if (Stamina != other.Stamina) return false;
            if (StaminaMax != other.StaminaMax) return false;
            if (Move1 != other.Move1) return false;
            if (Move2 != other.Move2) return false;
            if (DeployedFortId != other.DeployedFortId) return false;
            if (OwnerName != other.OwnerName) return false;
            if (IsEgg != other.IsEgg) return false;
            if (EggKmWalkedTarget != other.EggKmWalkedTarget) return false;
            if (EggKmWalkedStart != other.EggKmWalkedStart) return false;
            if (Origin != other.Origin) return false;
            if (HeightM != other.HeightM) return false;
            if (WeightKg != other.WeightKg) return false;
            if (IndividualAttack != other.IndividualAttack) return false;
            if (IndividualDefense != other.IndividualDefense) return false;
            if (IndividualStamina != other.IndividualStamina) return false;
            if (CpMultiplier != other.CpMultiplier) return false;
            if (Pokeball != other.Pokeball) return false;
            if (CapturedCellId != other.CapturedCellId) return false;
            if (BattlesAttacked != other.BattlesAttacked) return false;
            if (BattlesDefended != other.BattlesDefended) return false;
            if (EggIncubatorId != other.EggIncubatorId) return false;
            if (CreationTimeMs != other.CreationTimeMs) return false;
            if (NumUpgrades != other.NumUpgrades) return false;
            if (AdditionalCpMultiplier != other.AdditionalCpMultiplier) return false;
            if (Favorite != other.Favorite) return false;
            if (Nickname != other.Nickname) return false;
            if (FromFort != other.FromFort) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Id != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(Id);
            }
            if (PokemonId != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)PokemonId);
            }
            if (Cp != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(Cp);
            }
            if (Stamina != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(Stamina);
            }
            if (StaminaMax != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(StaminaMax);
            }
            if (Move1 != 0)
            {
                output.WriteRawTag(48);
                output.WriteEnum((int)Move1);
            }
            if (Move2 != 0)
            {
                output.WriteRawTag(56);
                output.WriteEnum((int)Move2);
            }
            if (DeployedFortId != 0)
            {
                output.WriteRawTag(64);
                output.WriteInt32(DeployedFortId);
            }
            if (OwnerName.Length != 0)
            {
                output.WriteRawTag(74);
                output.WriteString(OwnerName);
            }
            if (IsEgg != false)
            {
                output.WriteRawTag(80);
                output.WriteBool(IsEgg);
            }
            if (EggKmWalkedTarget != 0)
            {
                output.WriteRawTag(88);
                output.WriteInt32(EggKmWalkedTarget);
            }
            if (EggKmWalkedStart != 0)
            {
                output.WriteRawTag(96);
                output.WriteInt32(EggKmWalkedStart);
            }
            if (Origin != 0)
            {
                output.WriteRawTag(112);
                output.WriteInt32(Origin);
            }
            if (HeightM != 0F)
            {
                output.WriteRawTag(125);
                output.WriteFloat(HeightM);
            }
            if (WeightKg != 0F)
            {
                output.WriteRawTag(133, 1);
                output.WriteFloat(WeightKg);
            }
            if (IndividualAttack != 0)
            {
                output.WriteRawTag(136, 1);
                output.WriteInt32(IndividualAttack);
            }
            if (IndividualDefense != 0)
            {
                output.WriteRawTag(144, 1);
                output.WriteInt32(IndividualDefense);
            }
            if (IndividualStamina != 0)
            {
                output.WriteRawTag(152, 1);
                output.WriteInt32(IndividualStamina);
            }
            if (CpMultiplier != 0)
            {
                output.WriteRawTag(160, 1);
                output.WriteInt32(CpMultiplier);
            }
            if (Pokeball != 0)
            {
                output.WriteRawTag(168, 1);
                output.WriteInt32(Pokeball);
            }
            if (CapturedCellId != 0UL)
            {
                output.WriteRawTag(176, 1);
                output.WriteUInt64(CapturedCellId);
            }
            if (BattlesAttacked != 0)
            {
                output.WriteRawTag(184, 1);
                output.WriteInt32(BattlesAttacked);
            }
            if (BattlesDefended != 0)
            {
                output.WriteRawTag(192, 1);
                output.WriteInt32(BattlesDefended);
            }
            if (EggIncubatorId != 0)
            {
                output.WriteRawTag(200, 1);
                output.WriteInt32(EggIncubatorId);
            }
            if (CreationTimeMs != 0UL)
            {
                output.WriteRawTag(208, 1);
                output.WriteUInt64(CreationTimeMs);
            }
            if (NumUpgrades != 0)
            {
                output.WriteRawTag(216, 1);
                output.WriteInt32(NumUpgrades);
            }
            if (AdditionalCpMultiplier != 0)
            {
                output.WriteRawTag(224, 1);
                output.WriteInt32(AdditionalCpMultiplier);
            }
            if (Favorite != 0)
            {
                output.WriteRawTag(232, 1);
                output.WriteInt32(Favorite);
            }
            if (Nickname.Length != 0)
            {
                output.WriteRawTag(242, 1);
                output.WriteString(Nickname);
            }
            if (FromFort != 0)
            {
                output.WriteRawTag(248, 1);
                output.WriteInt32(FromFort);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Id != 0UL)
            {
                size += 1 + 8;
            }
            if (PokemonId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
            }
            if (Cp != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Cp);
            }
            if (Stamina != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
            }
            if (StaminaMax != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(StaminaMax);
            }
            if (Move1 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Move1);
            }
            if (Move2 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Move2);
            }
            if (DeployedFortId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DeployedFortId);
            }
            if (OwnerName.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerName);
            }
            if (IsEgg != false)
            {
                size += 1 + 1;
            }
            if (EggKmWalkedTarget != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggKmWalkedTarget);
            }
            if (EggKmWalkedStart != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggKmWalkedStart);
            }
            if (Origin != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Origin);
            }
            if (HeightM != 0F)
            {
                size += 1 + 4;
            }
            if (WeightKg != 0F)
            {
                size += 2 + 4;
            }
            if (IndividualAttack != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualAttack);
            }
            if (IndividualDefense != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualDefense);
            }
            if (IndividualStamina != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualStamina);
            }
            if (CpMultiplier != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(CpMultiplier);
            }
            if (Pokeball != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(Pokeball);
            }
            if (CapturedCellId != 0UL)
            {
                size += 2 + pb::CodedOutputStream.ComputeUInt64Size(CapturedCellId);
            }
            if (BattlesAttacked != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattlesAttacked);
            }
            if (BattlesDefended != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattlesDefended);
            }
            if (EggIncubatorId != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(EggIncubatorId);
            }
            if (CreationTimeMs != 0UL)
            {
                size += 2 + pb::CodedOutputStream.ComputeUInt64Size(CreationTimeMs);
            }
            if (NumUpgrades != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(NumUpgrades);
            }
            if (AdditionalCpMultiplier != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(AdditionalCpMultiplier);
            }
            if (Favorite != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(Favorite);
            }
            if (Nickname.Length != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeStringSize(Nickname);
            }
            if (FromFort != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(FromFort);
            }
            return size;
        }

        public void MergeFrom(PokemonData other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Id != 0UL)
            {
                Id = other.Id;
            }
            if (other.PokemonId != 0)
            {
                PokemonId = other.PokemonId;
            }
            if (other.Cp != 0)
            {
                Cp = other.Cp;
            }
            if (other.Stamina != 0)
            {
                Stamina = other.Stamina;
            }
            if (other.StaminaMax != 0)
            {
                StaminaMax = other.StaminaMax;
            }
            if (other.Move1 != 0)
            {
                Move1 = other.Move1;
            }
            if (other.Move2 != 0)
            {
                Move2 = other.Move2;
            }
            if (other.DeployedFortId != 0)
            {
                DeployedFortId = other.DeployedFortId;
            }
            if (other.OwnerName.Length != 0)
            {
                OwnerName = other.OwnerName;
            }
            if (other.IsEgg != false)
            {
                IsEgg = other.IsEgg;
            }
            if (other.EggKmWalkedTarget != 0)
            {
                EggKmWalkedTarget = other.EggKmWalkedTarget;
            }
            if (other.EggKmWalkedStart != 0)
            {
                EggKmWalkedStart = other.EggKmWalkedStart;
            }
            if (other.Origin != 0)
            {
                Origin = other.Origin;
            }
            if (other.HeightM != 0F)
            {
                HeightM = other.HeightM;
            }
            if (other.WeightKg != 0F)
            {
                WeightKg = other.WeightKg;
            }
            if (other.IndividualAttack != 0)
            {
                IndividualAttack = other.IndividualAttack;
            }
            if (other.IndividualDefense != 0)
            {
                IndividualDefense = other.IndividualDefense;
            }
            if (other.IndividualStamina != 0)
            {
                IndividualStamina = other.IndividualStamina;
            }
            if (other.CpMultiplier != 0)
            {
                CpMultiplier = other.CpMultiplier;
            }
            if (other.Pokeball != 0)
            {
                Pokeball = other.Pokeball;
            }
            if (other.CapturedCellId != 0UL)
            {
                CapturedCellId = other.CapturedCellId;
            }
            if (other.BattlesAttacked != 0)
            {
                BattlesAttacked = other.BattlesAttacked;
            }
            if (other.BattlesDefended != 0)
            {
                BattlesDefended = other.BattlesDefended;
            }
            if (other.EggIncubatorId != 0)
            {
                EggIncubatorId = other.EggIncubatorId;
            }
            if (other.CreationTimeMs != 0UL)
            {
                CreationTimeMs = other.CreationTimeMs;
            }
            if (other.NumUpgrades != 0)
            {
                NumUpgrades = other.NumUpgrades;
            }
            if (other.AdditionalCpMultiplier != 0)
            {
                AdditionalCpMultiplier = other.AdditionalCpMultiplier;
            }
            if (other.Favorite != 0)
            {
                Favorite = other.Favorite;
            }
            if (other.Nickname.Length != 0)
            {
                Nickname = other.Nickname;
            }
            if (other.FromFort != 0)
            {
                FromFort = other.FromFort;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            Id = input.ReadFixed64();
                            break;
                        }
                    case 16:
                        {
                            pokemonId_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            Cp = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            Stamina = input.ReadInt32();
                            break;
                        }
                    case 40:
                        {
                            StaminaMax = input.ReadInt32();
                            break;
                        }
                    case 48:
                        {
                            move1_ = (global::AllEnum.PokemonMove)input.ReadEnum();
                            break;
                        }
                    case 56:
                        {
                            move2_ = (global::AllEnum.PokemonMove)input.ReadEnum();
                            break;
                        }
                    case 64:
                        {
                            DeployedFortId = input.ReadInt32();
                            break;
                        }
                    case 74:
                        {
                            OwnerName = input.ReadString();
                            break;
                        }
                    case 80:
                        {
                            IsEgg = input.ReadBool();
                            break;
                        }
                    case 88:
                        {
                            EggKmWalkedTarget = input.ReadInt32();
                            break;
                        }
                    case 96:
                        {
                            EggKmWalkedStart = input.ReadInt32();
                            break;
                        }
                    case 112:
                        {
                            Origin = input.ReadInt32();
                            break;
                        }
                    case 125:
                        {
                            HeightM = input.ReadFloat();
                            break;
                        }
                    case 133:
                        {
                            WeightKg = input.ReadFloat();
                            break;
                        }
                    case 136:
                        {
                            IndividualAttack = input.ReadInt32();
                            break;
                        }
                    case 144:
                        {
                            IndividualDefense = input.ReadInt32();
                            break;
                        }
                    case 152:
                        {
                            IndividualStamina = input.ReadInt32();
                            break;
                        }
                    case 160:
                        {
                            CpMultiplier = input.ReadInt32();
                            break;
                        }
                    case 168:
                        {
                            Pokeball = input.ReadInt32();
                            break;
                        }
                    case 176:
                        {
                            CapturedCellId = input.ReadUInt64();
                            break;
                        }
                    case 184:
                        {
                            BattlesAttacked = input.ReadInt32();
                            break;
                        }
                    case 192:
                        {
                            BattlesDefended = input.ReadInt32();
                            break;
                        }
                    case 200:
                        {
                            EggIncubatorId = input.ReadInt32();
                            break;
                        }
                    case 208:
                        {
                            CreationTimeMs = input.ReadUInt64();
                            break;
                        }
                    case 216:
                        {
                            NumUpgrades = input.ReadInt32();
                            break;
                        }
                    case 224:
                        {
                            AdditionalCpMultiplier = input.ReadInt32();
                            break;
                        }
                    case 232:
                        {
                            Favorite = input.ReadInt32();
                            break;
                        }
                    case 242:
                        {
                            Nickname = input.ReadString();
                            break;
                        }
                    case 248:
                        {
                            FromFort = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PokemonData);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Id != 0UL) hash ^= Id.GetHashCode();
            if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
            if (Cp != 0) hash ^= Cp.GetHashCode();
            if (Stamina != 0) hash ^= Stamina.GetHashCode();
            if (StaminaMax != 0) hash ^= StaminaMax.GetHashCode();
            if (Move1 != 0) hash ^= Move1.GetHashCode();
            if (Move2 != 0) hash ^= Move2.GetHashCode();
            if (DeployedFortId != 0) hash ^= DeployedFortId.GetHashCode();
            if (OwnerName.Length != 0) hash ^= OwnerName.GetHashCode();
            if (IsEgg != false) hash ^= IsEgg.GetHashCode();
            if (EggKmWalkedTarget != 0) hash ^= EggKmWalkedTarget.GetHashCode();
            if (EggKmWalkedStart != 0) hash ^= EggKmWalkedStart.GetHashCode();
            if (Origin != 0) hash ^= Origin.GetHashCode();
            if (HeightM != 0F) hash ^= HeightM.GetHashCode();
            if (WeightKg != 0F) hash ^= WeightKg.GetHashCode();
            if (IndividualAttack != 0) hash ^= IndividualAttack.GetHashCode();
            if (IndividualDefense != 0) hash ^= IndividualDefense.GetHashCode();
            if (IndividualStamina != 0) hash ^= IndividualStamina.GetHashCode();
            if (CpMultiplier != 0) hash ^= CpMultiplier.GetHashCode();
            if (Pokeball != 0) hash ^= Pokeball.GetHashCode();
            if (CapturedCellId != 0UL) hash ^= CapturedCellId.GetHashCode();
            if (BattlesAttacked != 0) hash ^= BattlesAttacked.GetHashCode();
            if (BattlesDefended != 0) hash ^= BattlesDefended.GetHashCode();
            if (EggIncubatorId != 0) hash ^= EggIncubatorId.GetHashCode();
            if (CreationTimeMs != 0UL) hash ^= CreationTimeMs.GetHashCode();
            if (NumUpgrades != 0) hash ^= NumUpgrades.GetHashCode();
            if (AdditionalCpMultiplier != 0) hash ^= AdditionalCpMultiplier.GetHashCode();
            if (Favorite != 0) hash ^= Favorite.GetHashCode();
            if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
            if (FromFort != 0) hash ^= FromFort.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class MapPokemon : pb::IMessage<MapPokemon>
    {
        /// <summary>Field number for the "spawnpoint_id" field.</summary>
        public const int SpawnpointIdFieldNumber = 1;

        /// <summary>Field number for the "encounter_id" field.</summary>
        public const int EncounterIdFieldNumber = 2;

        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 3;

        /// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
        public const int ExpirationTimestampMsFieldNumber = 4;

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 5;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 6;

        private static readonly pb::MessageParser<MapPokemon> _parser =
            new pb::MessageParser<MapPokemon>(() => new MapPokemon());

        private ulong encounterId_;
        private long expirationTimestampMs_;
        private double latitude_;
        private double longitude_;
        private global::AllEnum.PokemonId pokemonId_ = 0;
        private string spawnpointId_ = "";

        public MapPokemon()
        {
            OnConstruction();
        }

        public MapPokemon(MapPokemon other) : this()
        {
            spawnpointId_ = other.spawnpointId_;
            encounterId_ = other.encounterId_;
            pokemonId_ = other.pokemonId_;
            expirationTimestampMs_ = other.expirationTimestampMs_;
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
        }

        public static pb::MessageParser<MapPokemon> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[32]; }
        }

        public string SpawnpointId
        {
            get { return spawnpointId_; }
            set { spawnpointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public ulong EncounterId
        {
            get { return encounterId_; }
            set { encounterId_ = value; }
        }

        public global::AllEnum.PokemonId PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        /// <summary>
        ///     After this timestamp, the pokemon will be gone.
        /// </summary>
        public long ExpirationTimestampMs
        {
            get { return expirationTimestampMs_; }
            set { expirationTimestampMs_ = value; }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MapPokemon Clone()
        {
            return new MapPokemon(this);
        }

        public bool Equals(MapPokemon other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (SpawnpointId != other.SpawnpointId) return false;
            if (EncounterId != other.EncounterId) return false;
            if (PokemonId != other.PokemonId) return false;
            if (ExpirationTimestampMs != other.ExpirationTimestampMs) return false;
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (SpawnpointId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(SpawnpointId);
            }
            if (EncounterId != 0UL)
            {
                output.WriteRawTag(17);
                output.WriteFixed64(EncounterId);
            }
            if (PokemonId != 0)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)PokemonId);
            }
            if (ExpirationTimestampMs != 0L)
            {
                output.WriteRawTag(32);
                output.WriteInt64(ExpirationTimestampMs);
            }
            if (Latitude != 0D)
            {
                output.WriteRawTag(41);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(49);
                output.WriteDouble(Longitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (SpawnpointId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnpointId);
            }
            if (EncounterId != 0UL)
            {
                size += 1 + 8;
            }
            if (PokemonId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
            }
            if (ExpirationTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
            }
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(MapPokemon other)
        {
            if (other == null)
            {
                return;
            }
            if (other.SpawnpointId.Length != 0)
            {
                SpawnpointId = other.SpawnpointId;
            }
            if (other.EncounterId != 0UL)
            {
                EncounterId = other.EncounterId;
            }
            if (other.PokemonId != 0)
            {
                PokemonId = other.PokemonId;
            }
            if (other.ExpirationTimestampMs != 0L)
            {
                ExpirationTimestampMs = other.ExpirationTimestampMs;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            SpawnpointId = input.ReadString();
                            break;
                        }
                    case 17:
                        {
                            EncounterId = input.ReadFixed64();
                            break;
                        }
                    case 24:
                        {
                            pokemonId_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 32:
                        {
                            ExpirationTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 41:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 49:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as MapPokemon);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (SpawnpointId.Length != 0) hash ^= SpawnpointId.GetHashCode();
            if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
            if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
            if (ExpirationTimestampMs != 0L) hash ^= ExpirationTimestampMs.GetHashCode();
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class NearbyPokemon : pb::IMessage<NearbyPokemon>
    {
        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 1;

        /// <summary>Field number for the "distance_in_meters" field.</summary>
        public const int DistanceInMetersFieldNumber = 2;

        /// <summary>Field number for the "encounter_id" field.</summary>
        public const int EncounterIdFieldNumber = 3;

        private static readonly pb::MessageParser<NearbyPokemon> _parser =
            new pb::MessageParser<NearbyPokemon>(() => new NearbyPokemon());

        private float distanceInMeters_;
        private ulong encounterId_;
        private global::AllEnum.PokemonId pokemonId_ = 0;

        public NearbyPokemon()
        {
            OnConstruction();
        }

        public NearbyPokemon(NearbyPokemon other) : this()
        {
            pokemonId_ = other.pokemonId_;
            distanceInMeters_ = other.distanceInMeters_;
            encounterId_ = other.encounterId_;
        }

        public static pb::MessageParser<NearbyPokemon> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[33]; }
        }

        public global::AllEnum.PokemonId PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        public float DistanceInMeters
        {
            get { return distanceInMeters_; }
            set { distanceInMeters_ = value; }
        }

        public ulong EncounterId
        {
            get { return encounterId_; }
            set { encounterId_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public NearbyPokemon Clone()
        {
            return new NearbyPokemon(this);
        }

        public bool Equals(NearbyPokemon other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PokemonId != other.PokemonId) return false;
            if (DistanceInMeters != other.DistanceInMeters) return false;
            if (EncounterId != other.EncounterId) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (PokemonId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)PokemonId);
            }
            if (DistanceInMeters != 0F)
            {
                output.WriteRawTag(21);
                output.WriteFloat(DistanceInMeters);
            }
            if (EncounterId != 0UL)
            {
                output.WriteRawTag(25);
                output.WriteFixed64(EncounterId);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (PokemonId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
            }
            if (DistanceInMeters != 0F)
            {
                size += 1 + 4;
            }
            if (EncounterId != 0UL)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(NearbyPokemon other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PokemonId != 0)
            {
                PokemonId = other.PokemonId;
            }
            if (other.DistanceInMeters != 0F)
            {
                DistanceInMeters = other.DistanceInMeters;
            }
            if (other.EncounterId != 0UL)
            {
                EncounterId = other.EncounterId;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            pokemonId_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 21:
                        {
                            DistanceInMeters = input.ReadFloat();
                            break;
                        }
                    case 25:
                        {
                            EncounterId = input.ReadFixed64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as NearbyPokemon);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
            if (DistanceInMeters != 0F) hash ^= DistanceInMeters.GetHashCode();
            if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class DownloadSettingsResponse : pb::IMessage<DownloadSettingsResponse>
    {
        /// <summary>Field number for the "error" field.</summary>
        public const int ErrorFieldNumber = 1;

        /// <summary>Field number for the "hash" field.</summary>
        public const int HashFieldNumber = 2;

        /// <summary>Field number for the "settings" field.</summary>
        public const int SettingsFieldNumber = 3;

        private static readonly pb::MessageParser<DownloadSettingsResponse> _parser =
            new pb::MessageParser<DownloadSettingsResponse>(() => new DownloadSettingsResponse());

        private string error_ = "";
        private string hash_ = "";
        private global::PokeGodar.WebAPI.GeneratedCode.GlobalSettings settings_;

        public DownloadSettingsResponse()
        {
            OnConstruction();
        }

        public DownloadSettingsResponse(DownloadSettingsResponse other) : this()
        {
            error_ = other.error_;
            hash_ = other.hash_;
            Settings = other.settings_ != null ? other.Settings.Clone() : null;
        }

        public static pb::MessageParser<DownloadSettingsResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[34]; }
        }

        public string Error
        {
            get { return error_; }
            set { error_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public string Hash
        {
            get { return hash_; }
            set { hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.GlobalSettings Settings
        {
            get { return settings_; }
            set { settings_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DownloadSettingsResponse Clone()
        {
            return new DownloadSettingsResponse(this);
        }

        public bool Equals(DownloadSettingsResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Error != other.Error) return false;
            if (Hash != other.Hash) return false;
            if (!Equals(Settings, other.Settings)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Error.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Error);
            }
            if (Hash.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Hash);
            }
            if (settings_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Settings);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Error.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
            }
            if (Hash.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
            }
            if (settings_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
            }
            return size;
        }

        public void MergeFrom(DownloadSettingsResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Error.Length != 0)
            {
                Error = other.Error;
            }
            if (other.Hash.Length != 0)
            {
                Hash = other.Hash;
            }
            if (other.settings_ != null)
            {
                if (settings_ == null)
                {
                    settings_ = new global::PokeGodar.WebAPI.GeneratedCode.GlobalSettings();
                }
                Settings.MergeFrom(other.Settings);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            Error = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Hash = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (settings_ == null)
                            {
                                settings_ = new global::PokeGodar.WebAPI.GeneratedCode.GlobalSettings();
                            }
                            input.ReadMessage(settings_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as DownloadSettingsResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Error.Length != 0) hash ^= Error.GetHashCode();
            if (Hash.Length != 0) hash ^= Hash.GetHashCode();
            if (settings_ != null) hash ^= Settings.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GlobalSettings : pb::IMessage<GlobalSettings>
    {
        /// <summary>Field number for the "fort_settings" field.</summary>
        public const int FortSettingsFieldNumber = 2;

        /// <summary>Field number for the "map_settings" field.</summary>
        public const int MapSettingsFieldNumber = 3;

        /// <summary>Field number for the "level_settings" field.</summary>
        public const int LevelSettingsFieldNumber = 4;

        /// <summary>Field number for the "inventory_settings" field.</summary>
        public const int InventorySettingsFieldNumber = 5;

        /// <summary>Field number for the "minimum_client_version" field.</summary>
        public const int MinimumClientVersionFieldNumber = 6;

        private static readonly pb::MessageParser<GlobalSettings> _parser =
            new pb::MessageParser<GlobalSettings>(() => new GlobalSettings());

        private global::PokeGodar.WebAPI.GeneratedCode.FortSettings fortSettings_;
        private global::PokeGodar.WebAPI.GeneratedCode.InventorySettings inventorySettings_;
        private global::PokeGodar.WebAPI.GeneratedCode.LevelSettings levelSettings_;
        private global::PokeGodar.WebAPI.GeneratedCode.MapSettings mapSettings_;
        private string minimumClientVersion_ = "";

        public GlobalSettings()
        {
            OnConstruction();
        }

        public GlobalSettings(GlobalSettings other) : this()
        {
            FortSettings = other.fortSettings_ != null ? other.FortSettings.Clone() : null;
            MapSettings = other.mapSettings_ != null ? other.MapSettings.Clone() : null;
            LevelSettings = other.levelSettings_ != null ? other.LevelSettings.Clone() : null;
            InventorySettings = other.inventorySettings_ != null ? other.InventorySettings.Clone() : null;
            minimumClientVersion_ = other.minimumClientVersion_;
        }

        public static pb::MessageParser<GlobalSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[35]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.FortSettings FortSettings
        {
            get { return fortSettings_; }
            set { fortSettings_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.MapSettings MapSettings
        {
            get { return mapSettings_; }
            set { mapSettings_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.LevelSettings LevelSettings
        {
            get { return levelSettings_; }
            set { levelSettings_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.InventorySettings InventorySettings
        {
            get { return inventorySettings_; }
            set { inventorySettings_ = value; }
        }

        public string MinimumClientVersion
        {
            get { return minimumClientVersion_; }
            set { minimumClientVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GlobalSettings Clone()
        {
            return new GlobalSettings(this);
        }

        public bool Equals(GlobalSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(FortSettings, other.FortSettings)) return false;
            if (!Equals(MapSettings, other.MapSettings)) return false;
            if (!Equals(LevelSettings, other.LevelSettings)) return false;
            if (!Equals(InventorySettings, other.InventorySettings)) return false;
            if (MinimumClientVersion != other.MinimumClientVersion) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (fortSettings_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(FortSettings);
            }
            if (mapSettings_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(MapSettings);
            }
            if (levelSettings_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(LevelSettings);
            }
            if (inventorySettings_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(InventorySettings);
            }
            if (MinimumClientVersion.Length != 0)
            {
                output.WriteRawTag(50);
                output.WriteString(MinimumClientVersion);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (fortSettings_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortSettings);
            }
            if (mapSettings_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapSettings);
            }
            if (levelSettings_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(LevelSettings);
            }
            if (inventorySettings_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventorySettings);
            }
            if (MinimumClientVersion.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(MinimumClientVersion);
            }
            return size;
        }

        public void MergeFrom(GlobalSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.fortSettings_ != null)
            {
                if (fortSettings_ == null)
                {
                    fortSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.FortSettings();
                }
                FortSettings.MergeFrom(other.FortSettings);
            }
            if (other.mapSettings_ != null)
            {
                if (mapSettings_ == null)
                {
                    mapSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.MapSettings();
                }
                MapSettings.MergeFrom(other.MapSettings);
            }
            if (other.levelSettings_ != null)
            {
                if (levelSettings_ == null)
                {
                    levelSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.LevelSettings();
                }
                LevelSettings.MergeFrom(other.LevelSettings);
            }
            if (other.inventorySettings_ != null)
            {
                if (inventorySettings_ == null)
                {
                    inventorySettings_ = new global::PokeGodar.WebAPI.GeneratedCode.InventorySettings();
                }
                InventorySettings.MergeFrom(other.InventorySettings);
            }
            if (other.MinimumClientVersion.Length != 0)
            {
                MinimumClientVersion = other.MinimumClientVersion;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 18:
                        {
                            if (fortSettings_ == null)
                            {
                                fortSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.FortSettings();
                            }
                            input.ReadMessage(fortSettings_);
                            break;
                        }
                    case 26:
                        {
                            if (mapSettings_ == null)
                            {
                                mapSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.MapSettings();
                            }
                            input.ReadMessage(mapSettings_);
                            break;
                        }
                    case 34:
                        {
                            if (levelSettings_ == null)
                            {
                                levelSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.LevelSettings();
                            }
                            input.ReadMessage(levelSettings_);
                            break;
                        }
                    case 42:
                        {
                            if (inventorySettings_ == null)
                            {
                                inventorySettings_ = new global::PokeGodar.WebAPI.GeneratedCode.InventorySettings();
                            }
                            input.ReadMessage(inventorySettings_);
                            break;
                        }
                    case 50:
                        {
                            MinimumClientVersion = input.ReadString();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GlobalSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (fortSettings_ != null) hash ^= FortSettings.GetHashCode();
            if (mapSettings_ != null) hash ^= MapSettings.GetHashCode();
            if (levelSettings_ != null) hash ^= LevelSettings.GetHashCode();
            if (inventorySettings_ != null) hash ^= InventorySettings.GetHashCode();
            if (MinimumClientVersion.Length != 0) hash ^= MinimumClientVersion.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortSettings : pb::IMessage<FortSettings>
    {
        /// <summary>Field number for the "interaction_range_meters" field.</summary>
        public const int InteractionRangeMetersFieldNumber = 1;

        /// <summary>Field number for the "max_total_deployed_pokemon" field.</summary>
        public const int MaxTotalDeployedPokemonFieldNumber = 2;

        /// <summary>Field number for the "max_player_deployed_pokemon" field.</summary>
        public const int MaxPlayerDeployedPokemonFieldNumber = 3;

        /// <summary>Field number for the "deploy_stamina_multiplier" field.</summary>
        public const int DeployStaminaMultiplierFieldNumber = 4;

        /// <summary>Field number for the "deploy_attack_multiplier" field.</summary>
        public const int DeployAttackMultiplierFieldNumber = 5;

        /// <summary>Field number for the "far_interaction_range_meters" field.</summary>
        public const int FarInteractionRangeMetersFieldNumber = 6;

        private static readonly pb::MessageParser<FortSettings> _parser =
            new pb::MessageParser<FortSettings>(() => new FortSettings());

        private double deployAttackMultiplier_;
        private double deployStaminaMultiplier_;
        private double farInteractionRangeMeters_;
        private double interactionRangeMeters_;
        private int maxPlayerDeployedPokemon_;
        private int maxTotalDeployedPokemon_;

        public FortSettings()
        {
            OnConstruction();
        }

        public FortSettings(FortSettings other) : this()
        {
            interactionRangeMeters_ = other.interactionRangeMeters_;
            maxTotalDeployedPokemon_ = other.maxTotalDeployedPokemon_;
            maxPlayerDeployedPokemon_ = other.maxPlayerDeployedPokemon_;
            deployStaminaMultiplier_ = other.deployStaminaMultiplier_;
            deployAttackMultiplier_ = other.deployAttackMultiplier_;
            farInteractionRangeMeters_ = other.farInteractionRangeMeters_;
        }

        public static pb::MessageParser<FortSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[36]; }
        }

        public double InteractionRangeMeters
        {
            get { return interactionRangeMeters_; }
            set { interactionRangeMeters_ = value; }
        }

        public int MaxTotalDeployedPokemon
        {
            get { return maxTotalDeployedPokemon_; }
            set { maxTotalDeployedPokemon_ = value; }
        }

        public int MaxPlayerDeployedPokemon
        {
            get { return maxPlayerDeployedPokemon_; }
            set { maxPlayerDeployedPokemon_ = value; }
        }

        public double DeployStaminaMultiplier
        {
            get { return deployStaminaMultiplier_; }
            set { deployStaminaMultiplier_ = value; }
        }

        public double DeployAttackMultiplier
        {
            get { return deployAttackMultiplier_; }
            set { deployAttackMultiplier_ = value; }
        }

        public double FarInteractionRangeMeters
        {
            get { return farInteractionRangeMeters_; }
            set { farInteractionRangeMeters_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortSettings Clone()
        {
            return new FortSettings(this);
        }

        public bool Equals(FortSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (InteractionRangeMeters != other.InteractionRangeMeters) return false;
            if (MaxTotalDeployedPokemon != other.MaxTotalDeployedPokemon) return false;
            if (MaxPlayerDeployedPokemon != other.MaxPlayerDeployedPokemon) return false;
            if (DeployStaminaMultiplier != other.DeployStaminaMultiplier) return false;
            if (DeployAttackMultiplier != other.DeployAttackMultiplier) return false;
            if (FarInteractionRangeMeters != other.FarInteractionRangeMeters) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (InteractionRangeMeters != 0D)
            {
                output.WriteRawTag(9);
                output.WriteDouble(InteractionRangeMeters);
            }
            if (MaxTotalDeployedPokemon != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(MaxTotalDeployedPokemon);
            }
            if (MaxPlayerDeployedPokemon != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(MaxPlayerDeployedPokemon);
            }
            if (DeployStaminaMultiplier != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(DeployStaminaMultiplier);
            }
            if (DeployAttackMultiplier != 0D)
            {
                output.WriteRawTag(41);
                output.WriteDouble(DeployAttackMultiplier);
            }
            if (FarInteractionRangeMeters != 0D)
            {
                output.WriteRawTag(49);
                output.WriteDouble(FarInteractionRangeMeters);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (InteractionRangeMeters != 0D)
            {
                size += 1 + 8;
            }
            if (MaxTotalDeployedPokemon != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxTotalDeployedPokemon);
            }
            if (MaxPlayerDeployedPokemon != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPlayerDeployedPokemon);
            }
            if (DeployStaminaMultiplier != 0D)
            {
                size += 1 + 8;
            }
            if (DeployAttackMultiplier != 0D)
            {
                size += 1 + 8;
            }
            if (FarInteractionRangeMeters != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(FortSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.InteractionRangeMeters != 0D)
            {
                InteractionRangeMeters = other.InteractionRangeMeters;
            }
            if (other.MaxTotalDeployedPokemon != 0)
            {
                MaxTotalDeployedPokemon = other.MaxTotalDeployedPokemon;
            }
            if (other.MaxPlayerDeployedPokemon != 0)
            {
                MaxPlayerDeployedPokemon = other.MaxPlayerDeployedPokemon;
            }
            if (other.DeployStaminaMultiplier != 0D)
            {
                DeployStaminaMultiplier = other.DeployStaminaMultiplier;
            }
            if (other.DeployAttackMultiplier != 0D)
            {
                DeployAttackMultiplier = other.DeployAttackMultiplier;
            }
            if (other.FarInteractionRangeMeters != 0D)
            {
                FarInteractionRangeMeters = other.FarInteractionRangeMeters;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            InteractionRangeMeters = input.ReadDouble();
                            break;
                        }
                    case 16:
                        {
                            MaxTotalDeployedPokemon = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            MaxPlayerDeployedPokemon = input.ReadInt32();
                            break;
                        }
                    case 33:
                        {
                            DeployStaminaMultiplier = input.ReadDouble();
                            break;
                        }
                    case 41:
                        {
                            DeployAttackMultiplier = input.ReadDouble();
                            break;
                        }
                    case 49:
                        {
                            FarInteractionRangeMeters = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (InteractionRangeMeters != 0D) hash ^= InteractionRangeMeters.GetHashCode();
            if (MaxTotalDeployedPokemon != 0) hash ^= MaxTotalDeployedPokemon.GetHashCode();
            if (MaxPlayerDeployedPokemon != 0) hash ^= MaxPlayerDeployedPokemon.GetHashCode();
            if (DeployStaminaMultiplier != 0D) hash ^= DeployStaminaMultiplier.GetHashCode();
            if (DeployAttackMultiplier != 0D) hash ^= DeployAttackMultiplier.GetHashCode();
            if (FarInteractionRangeMeters != 0D) hash ^= FarInteractionRangeMeters.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class MapSettings : pb::IMessage<MapSettings>
    {
        /// <summary>Field number for the "pokemon_visible_range" field.</summary>
        public const int PokemonVisibleRangeFieldNumber = 1;

        /// <summary>Field number for the "poke_nav_range_meters" field.</summary>
        public const int PokeNavRangeMetersFieldNumber = 2;

        /// <summary>Field number for the "encounter_range_meters" field.</summary>
        public const int EncounterRangeMetersFieldNumber = 3;

        /// <summary>Field number for the "get_map_objects_min_refresh_seconds" field.</summary>
        public const int GetMapObjectsMinRefreshSecondsFieldNumber = 4;

        /// <summary>Field number for the "get_map_objects_max_refresh_seconds" field.</summary>
        public const int GetMapObjectsMaxRefreshSecondsFieldNumber = 5;

        /// <summary>Field number for the "get_map_objects_min_distance_meters" field.</summary>
        public const int GetMapObjectsMinDistanceMetersFieldNumber = 6;

        /// <summary>Field number for the "google_maps_api_key" field.</summary>
        public const int GoogleMapsApiKeyFieldNumber = 7;

        private static readonly pb::MessageParser<MapSettings> _parser =
            new pb::MessageParser<MapSettings>(() => new MapSettings());

        private double encounterRangeMeters_;
        private float getMapObjectsMaxRefreshSeconds_;
        private float getMapObjectsMinDistanceMeters_;
        private float getMapObjectsMinRefreshSeconds_;
        private string googleMapsApiKey_ = "";
        private double pokemonVisibleRange_;
        private double pokeNavRangeMeters_;

        public MapSettings()
        {
            OnConstruction();
        }

        public MapSettings(MapSettings other) : this()
        {
            pokemonVisibleRange_ = other.pokemonVisibleRange_;
            pokeNavRangeMeters_ = other.pokeNavRangeMeters_;
            encounterRangeMeters_ = other.encounterRangeMeters_;
            getMapObjectsMinRefreshSeconds_ = other.getMapObjectsMinRefreshSeconds_;
            getMapObjectsMaxRefreshSeconds_ = other.getMapObjectsMaxRefreshSeconds_;
            getMapObjectsMinDistanceMeters_ = other.getMapObjectsMinDistanceMeters_;
            googleMapsApiKey_ = other.googleMapsApiKey_;
        }

        public static pb::MessageParser<MapSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[37]; }
        }

        public double PokemonVisibleRange
        {
            get { return pokemonVisibleRange_; }
            set { pokemonVisibleRange_ = value; }
        }

        public double PokeNavRangeMeters
        {
            get { return pokeNavRangeMeters_; }
            set { pokeNavRangeMeters_ = value; }
        }

        public double EncounterRangeMeters
        {
            get { return encounterRangeMeters_; }
            set { encounterRangeMeters_ = value; }
        }

        public float GetMapObjectsMinRefreshSeconds
        {
            get { return getMapObjectsMinRefreshSeconds_; }
            set { getMapObjectsMinRefreshSeconds_ = value; }
        }

        public float GetMapObjectsMaxRefreshSeconds
        {
            get { return getMapObjectsMaxRefreshSeconds_; }
            set { getMapObjectsMaxRefreshSeconds_ = value; }
        }

        public float GetMapObjectsMinDistanceMeters
        {
            get { return getMapObjectsMinDistanceMeters_; }
            set { getMapObjectsMinDistanceMeters_ = value; }
        }

        public string GoogleMapsApiKey
        {
            get { return googleMapsApiKey_; }
            set { googleMapsApiKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MapSettings Clone()
        {
            return new MapSettings(this);
        }

        public bool Equals(MapSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PokemonVisibleRange != other.PokemonVisibleRange) return false;
            if (PokeNavRangeMeters != other.PokeNavRangeMeters) return false;
            if (EncounterRangeMeters != other.EncounterRangeMeters) return false;
            if (GetMapObjectsMinRefreshSeconds != other.GetMapObjectsMinRefreshSeconds) return false;
            if (GetMapObjectsMaxRefreshSeconds != other.GetMapObjectsMaxRefreshSeconds) return false;
            if (GetMapObjectsMinDistanceMeters != other.GetMapObjectsMinDistanceMeters) return false;
            if (GoogleMapsApiKey != other.GoogleMapsApiKey) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (PokemonVisibleRange != 0D)
            {
                output.WriteRawTag(9);
                output.WriteDouble(PokemonVisibleRange);
            }
            if (PokeNavRangeMeters != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(PokeNavRangeMeters);
            }
            if (EncounterRangeMeters != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(EncounterRangeMeters);
            }
            if (GetMapObjectsMinRefreshSeconds != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(GetMapObjectsMinRefreshSeconds);
            }
            if (GetMapObjectsMaxRefreshSeconds != 0F)
            {
                output.WriteRawTag(45);
                output.WriteFloat(GetMapObjectsMaxRefreshSeconds);
            }
            if (GetMapObjectsMinDistanceMeters != 0F)
            {
                output.WriteRawTag(53);
                output.WriteFloat(GetMapObjectsMinDistanceMeters);
            }
            if (GoogleMapsApiKey.Length != 0)
            {
                output.WriteRawTag(58);
                output.WriteString(GoogleMapsApiKey);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (PokemonVisibleRange != 0D)
            {
                size += 1 + 8;
            }
            if (PokeNavRangeMeters != 0D)
            {
                size += 1 + 8;
            }
            if (EncounterRangeMeters != 0D)
            {
                size += 1 + 8;
            }
            if (GetMapObjectsMinRefreshSeconds != 0F)
            {
                size += 1 + 4;
            }
            if (GetMapObjectsMaxRefreshSeconds != 0F)
            {
                size += 1 + 4;
            }
            if (GetMapObjectsMinDistanceMeters != 0F)
            {
                size += 1 + 4;
            }
            if (GoogleMapsApiKey.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(GoogleMapsApiKey);
            }
            return size;
        }

        public void MergeFrom(MapSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PokemonVisibleRange != 0D)
            {
                PokemonVisibleRange = other.PokemonVisibleRange;
            }
            if (other.PokeNavRangeMeters != 0D)
            {
                PokeNavRangeMeters = other.PokeNavRangeMeters;
            }
            if (other.EncounterRangeMeters != 0D)
            {
                EncounterRangeMeters = other.EncounterRangeMeters;
            }
            if (other.GetMapObjectsMinRefreshSeconds != 0F)
            {
                GetMapObjectsMinRefreshSeconds = other.GetMapObjectsMinRefreshSeconds;
            }
            if (other.GetMapObjectsMaxRefreshSeconds != 0F)
            {
                GetMapObjectsMaxRefreshSeconds = other.GetMapObjectsMaxRefreshSeconds;
            }
            if (other.GetMapObjectsMinDistanceMeters != 0F)
            {
                GetMapObjectsMinDistanceMeters = other.GetMapObjectsMinDistanceMeters;
            }
            if (other.GoogleMapsApiKey.Length != 0)
            {
                GoogleMapsApiKey = other.GoogleMapsApiKey;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            PokemonVisibleRange = input.ReadDouble();
                            break;
                        }
                    case 17:
                        {
                            PokeNavRangeMeters = input.ReadDouble();
                            break;
                        }
                    case 25:
                        {
                            EncounterRangeMeters = input.ReadDouble();
                            break;
                        }
                    case 37:
                        {
                            GetMapObjectsMinRefreshSeconds = input.ReadFloat();
                            break;
                        }
                    case 45:
                        {
                            GetMapObjectsMaxRefreshSeconds = input.ReadFloat();
                            break;
                        }
                    case 53:
                        {
                            GetMapObjectsMinDistanceMeters = input.ReadFloat();
                            break;
                        }
                    case 58:
                        {
                            GoogleMapsApiKey = input.ReadString();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as MapSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (PokemonVisibleRange != 0D) hash ^= PokemonVisibleRange.GetHashCode();
            if (PokeNavRangeMeters != 0D) hash ^= PokeNavRangeMeters.GetHashCode();
            if (EncounterRangeMeters != 0D) hash ^= EncounterRangeMeters.GetHashCode();
            if (GetMapObjectsMinRefreshSeconds != 0F) hash ^= GetMapObjectsMinRefreshSeconds.GetHashCode();
            if (GetMapObjectsMaxRefreshSeconds != 0F) hash ^= GetMapObjectsMaxRefreshSeconds.GetHashCode();
            if (GetMapObjectsMinDistanceMeters != 0F) hash ^= GetMapObjectsMinDistanceMeters.GetHashCode();
            if (GoogleMapsApiKey.Length != 0) hash ^= GoogleMapsApiKey.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class LevelSettings : pb::IMessage<LevelSettings>
    {
        /// <summary>Field number for the "trainer_cp_modifier" field.</summary>
        public const int TrainerCpModifierFieldNumber = 2;

        /// <summary>Field number for the "trainer_difficulty_modifier" field.</summary>
        public const int TrainerDifficultyModifierFieldNumber = 3;

        private static readonly pb::MessageParser<LevelSettings> _parser =
            new pb::MessageParser<LevelSettings>(() => new LevelSettings());

        private double trainerCpModifier_;
        private double trainerDifficultyModifier_;

        public LevelSettings()
        {
            OnConstruction();
        }

        public LevelSettings(LevelSettings other) : this()
        {
            trainerCpModifier_ = other.trainerCpModifier_;
            trainerDifficultyModifier_ = other.trainerDifficultyModifier_;
        }

        public static pb::MessageParser<LevelSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[38]; }
        }

        public double TrainerCpModifier
        {
            get { return trainerCpModifier_; }
            set { trainerCpModifier_ = value; }
        }

        public double TrainerDifficultyModifier
        {
            get { return trainerDifficultyModifier_; }
            set { trainerDifficultyModifier_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public LevelSettings Clone()
        {
            return new LevelSettings(this);
        }

        public bool Equals(LevelSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (TrainerCpModifier != other.TrainerCpModifier) return false;
            if (TrainerDifficultyModifier != other.TrainerDifficultyModifier) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (TrainerCpModifier != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(TrainerCpModifier);
            }
            if (TrainerDifficultyModifier != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(TrainerDifficultyModifier);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (TrainerCpModifier != 0D)
            {
                size += 1 + 8;
            }
            if (TrainerDifficultyModifier != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(LevelSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.TrainerCpModifier != 0D)
            {
                TrainerCpModifier = other.TrainerCpModifier;
            }
            if (other.TrainerDifficultyModifier != 0D)
            {
                TrainerDifficultyModifier = other.TrainerDifficultyModifier;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 17:
                        {
                            TrainerCpModifier = input.ReadDouble();
                            break;
                        }
                    case 25:
                        {
                            TrainerDifficultyModifier = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as LevelSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (TrainerCpModifier != 0D) hash ^= TrainerCpModifier.GetHashCode();
            if (TrainerDifficultyModifier != 0D) hash ^= TrainerDifficultyModifier.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class InventorySettings : pb::IMessage<InventorySettings>
    {
        /// <summary>Field number for the "max_pokemon" field.</summary>
        public const int MaxPokemonFieldNumber = 1;

        /// <summary>Field number for the "max_bag_items" field.</summary>
        public const int MaxBagItemsFieldNumber = 2;

        /// <summary>Field number for the "base_pokemon" field.</summary>
        public const int BasePokemonFieldNumber = 3;

        /// <summary>Field number for the "base_bag_items" field.</summary>
        public const int BaseBagItemsFieldNumber = 4;

        /// <summary>Field number for the "base_eggs" field.</summary>
        public const int BaseEggsFieldNumber = 5;

        private static readonly pb::MessageParser<InventorySettings> _parser =
            new pb::MessageParser<InventorySettings>(() => new InventorySettings());

        private int baseBagItems_;
        private int baseEggs_;
        private int basePokemon_;
        private int maxBagItems_;
        private int maxPokemon_;

        public InventorySettings()
        {
            OnConstruction();
        }

        public InventorySettings(InventorySettings other) : this()
        {
            maxPokemon_ = other.maxPokemon_;
            maxBagItems_ = other.maxBagItems_;
            basePokemon_ = other.basePokemon_;
            baseBagItems_ = other.baseBagItems_;
            baseEggs_ = other.baseEggs_;
        }

        public static pb::MessageParser<InventorySettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[39]; }
        }

        public int MaxPokemon
        {
            get { return maxPokemon_; }
            set { maxPokemon_ = value; }
        }

        public int MaxBagItems
        {
            get { return maxBagItems_; }
            set { maxBagItems_ = value; }
        }

        public int BasePokemon
        {
            get { return basePokemon_; }
            set { basePokemon_ = value; }
        }

        public int BaseBagItems
        {
            get { return baseBagItems_; }
            set { baseBagItems_ = value; }
        }

        public int BaseEggs
        {
            get { return baseEggs_; }
            set { baseEggs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InventorySettings Clone()
        {
            return new InventorySettings(this);
        }

        public bool Equals(InventorySettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (MaxPokemon != other.MaxPokemon) return false;
            if (MaxBagItems != other.MaxBagItems) return false;
            if (BasePokemon != other.BasePokemon) return false;
            if (BaseBagItems != other.BaseBagItems) return false;
            if (BaseEggs != other.BaseEggs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (MaxPokemon != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(MaxPokemon);
            }
            if (MaxBagItems != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(MaxBagItems);
            }
            if (BasePokemon != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(BasePokemon);
            }
            if (BaseBagItems != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(BaseBagItems);
            }
            if (BaseEggs != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(BaseEggs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (MaxPokemon != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPokemon);
            }
            if (MaxBagItems != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxBagItems);
            }
            if (BasePokemon != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BasePokemon);
            }
            if (BaseBagItems != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseBagItems);
            }
            if (BaseEggs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseEggs);
            }
            return size;
        }

        public void MergeFrom(InventorySettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.MaxPokemon != 0)
            {
                MaxPokemon = other.MaxPokemon;
            }
            if (other.MaxBagItems != 0)
            {
                MaxBagItems = other.MaxBagItems;
            }
            if (other.BasePokemon != 0)
            {
                BasePokemon = other.BasePokemon;
            }
            if (other.BaseBagItems != 0)
            {
                BaseBagItems = other.BaseBagItems;
            }
            if (other.BaseEggs != 0)
            {
                BaseEggs = other.BaseEggs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            MaxPokemon = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            MaxBagItems = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            BasePokemon = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            BaseBagItems = input.ReadInt32();
                            break;
                        }
                    case 40:
                        {
                            BaseEggs = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as InventorySettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (MaxPokemon != 0) hash ^= MaxPokemon.GetHashCode();
            if (MaxBagItems != 0) hash ^= MaxBagItems.GetHashCode();
            if (BasePokemon != 0) hash ^= BasePokemon.GetHashCode();
            if (BaseBagItems != 0) hash ^= BaseBagItems.GetHashCode();
            if (BaseEggs != 0) hash ^= BaseEggs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PlayerUpdateRequest : pb::IMessage<PlayerUpdateRequest>
    {
        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 1;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 2;

        private static readonly pb::MessageParser<PlayerUpdateRequest> _parser =
            new pb::MessageParser<PlayerUpdateRequest>(() => new PlayerUpdateRequest());

        private double latitude_;
        private double longitude_;

        public PlayerUpdateRequest()
        {
            OnConstruction();
        }

        public PlayerUpdateRequest(PlayerUpdateRequest other) : this()
        {
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
        }

        public static pb::MessageParser<PlayerUpdateRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[40]; }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PlayerUpdateRequest Clone()
        {
            return new PlayerUpdateRequest(this);
        }

        public bool Equals(PlayerUpdateRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Latitude != 0D)
            {
                output.WriteRawTag(9);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(Longitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(PlayerUpdateRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 17:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PlayerUpdateRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PlayerUpdateResponse : pb::IMessage<PlayerUpdateResponse>
    {
        /// <summary>Field number for the "wild_pokemons" field.</summary>
        public const int WildPokemonsFieldNumber = 1;

        /// <summary>Field number for the "forts" field.</summary>
        public const int FortsFieldNumber = 2;

        /// <summary>Field number for the "forts_nearby" field.</summary>
        public const int FortsNearbyFieldNumber = 3;

        private static readonly pb::MessageParser<PlayerUpdateResponse> _parser =
            new pb::MessageParser<PlayerUpdateResponse>(() => new PlayerUpdateResponse());

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon>
            _repeated_wildPokemons_codec
                = pb::FieldCodec.ForMessage(10, global::PokeGodar.WebAPI.GeneratedCode.WildPokemon.Parser);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.FortData> _repeated_forts_codec
            = pb::FieldCodec.ForMessage(18, global::PokeGodar.WebAPI.GeneratedCode.FortData.Parser);

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortData> forts_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortData>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon> wildPokemons_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon>();

        private int fortsNearby_;

        public PlayerUpdateResponse()
        {
            OnConstruction();
        }

        public PlayerUpdateResponse(PlayerUpdateResponse other) : this()
        {
            wildPokemons_ = other.wildPokemons_.Clone();
            forts_ = other.forts_.Clone();
            fortsNearby_ = other.fortsNearby_;
        }

        public static pb::MessageParser<PlayerUpdateResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[41]; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.WildPokemon> WildPokemons
        {
            get { return wildPokemons_; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortData> Forts
        {
            get { return forts_; }
        }

        public int FortsNearby
        {
            get { return fortsNearby_; }
            set { fortsNearby_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PlayerUpdateResponse Clone()
        {
            return new PlayerUpdateResponse(this);
        }

        public bool Equals(PlayerUpdateResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!wildPokemons_.Equals(other.wildPokemons_)) return false;
            if (!forts_.Equals(other.forts_)) return false;
            if (FortsNearby != other.FortsNearby) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            wildPokemons_.WriteTo(output, _repeated_wildPokemons_codec);
            forts_.WriteTo(output, _repeated_forts_codec);
            if (FortsNearby != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(FortsNearby);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            size += wildPokemons_.CalculateSize(_repeated_wildPokemons_codec);
            size += forts_.CalculateSize(_repeated_forts_codec);
            if (FortsNearby != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(FortsNearby);
            }
            return size;
        }

        public void MergeFrom(PlayerUpdateResponse other)
        {
            if (other == null)
            {
                return;
            }
            wildPokemons_.Add(other.wildPokemons_);
            forts_.Add(other.forts_);
            if (other.FortsNearby != 0)
            {
                FortsNearby = other.FortsNearby;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            wildPokemons_.AddEntriesFrom(input, _repeated_wildPokemons_codec);
                            break;
                        }
                    case 18:
                        {
                            forts_.AddEntriesFrom(input, _repeated_forts_codec);
                            break;
                        }
                    case 24:
                        {
                            FortsNearby = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PlayerUpdateResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= wildPokemons_.GetHashCode();
            hash ^= forts_.GetHashCode();
            if (FortsNearby != 0) hash ^= FortsNearby.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     No message needed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class DownloadItemTemplatesRequest : pb::IMessage<DownloadItemTemplatesRequest>
    {
        private static readonly pb::MessageParser<DownloadItemTemplatesRequest> _parser =
            new pb::MessageParser<DownloadItemTemplatesRequest>(() => new DownloadItemTemplatesRequest());

        public DownloadItemTemplatesRequest()
        {
            OnConstruction();
        }

        public DownloadItemTemplatesRequest(DownloadItemTemplatesRequest other) : this()
        {
        }

        public static pb::MessageParser<DownloadItemTemplatesRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[42]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DownloadItemTemplatesRequest Clone()
        {
            return new DownloadItemTemplatesRequest(this);
        }

        public bool Equals(DownloadItemTemplatesRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
        }

        public int CalculateSize()
        {
            var size = 0;
            return size;
        }

        public void MergeFrom(DownloadItemTemplatesRequest other)
        {
            if (other == null)
            {
                return;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as DownloadItemTemplatesRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class DownloadItemTemplatesResponse : pb::IMessage<DownloadItemTemplatesResponse>
    {
        /// <summary>Field number for the "success" field.</summary>
        public const int SuccessFieldNumber = 1;

        /// <summary>Field number for the "item_templates" field.</summary>
        public const int ItemTemplatesFieldNumber = 2;

        /// <summary>Field number for the "timestamp_ms" field.</summary>
        public const int TimestampMsFieldNumber = 3;

        private static readonly pb::MessageParser<DownloadItemTemplatesResponse> _parser =
            new pb::MessageParser<DownloadItemTemplatesResponse>(() => new DownloadItemTemplatesResponse());

        private static readonly
            pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Types.ItemTemplate>
            _repeated_itemTemplates_codec
                = pb::FieldCodec.ForMessage(18,
                    global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Types.ItemTemplate.Parser);

        private readonly
            pbc::RepeatedField
                <global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Types.ItemTemplate>
            itemTemplates_ =
                new pbc::RepeatedField
                    <global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Types.ItemTemplate>();

        private bool success_;
        private ulong timestampMs_;

        public DownloadItemTemplatesResponse()
        {
            OnConstruction();
        }

        public DownloadItemTemplatesResponse(DownloadItemTemplatesResponse other) : this()
        {
            success_ = other.success_;
            itemTemplates_ = other.itemTemplates_.Clone();
            timestampMs_ = other.timestampMs_;
        }

        public static pb::MessageParser<DownloadItemTemplatesResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[43]; }
        }

        public bool Success
        {
            get { return success_; }
            set { success_ = value; }
        }

        public
            pbc::RepeatedField
                <global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Types.ItemTemplate>
            ItemTemplates
        {
            get { return itemTemplates_; }
        }

        public ulong TimestampMs
        {
            get { return timestampMs_; }
            set { timestampMs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DownloadItemTemplatesResponse Clone()
        {
            return new DownloadItemTemplatesResponse(this);
        }

        public bool Equals(DownloadItemTemplatesResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Success != other.Success) return false;
            if (!itemTemplates_.Equals(other.itemTemplates_)) return false;
            if (TimestampMs != other.TimestampMs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Success != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(Success);
            }
            itemTemplates_.WriteTo(output, _repeated_itemTemplates_codec);
            if (TimestampMs != 0UL)
            {
                output.WriteRawTag(24);
                output.WriteUInt64(TimestampMs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Success != false)
            {
                size += 1 + 1;
            }
            size += itemTemplates_.CalculateSize(_repeated_itemTemplates_codec);
            if (TimestampMs != 0UL)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimestampMs);
            }
            return size;
        }

        public void MergeFrom(DownloadItemTemplatesResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Success != false)
            {
                Success = other.Success;
            }
            itemTemplates_.Add(other.itemTemplates_);
            if (other.TimestampMs != 0UL)
            {
                TimestampMs = other.TimestampMs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Success = input.ReadBool();
                            break;
                        }
                    case 18:
                        {
                            itemTemplates_.AddEntriesFrom(input, _repeated_itemTemplates_codec);
                            break;
                        }
                    case 24:
                        {
                            TimestampMs = input.ReadUInt64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as DownloadItemTemplatesResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Success != false) hash ^= Success.GetHashCode();
            hash ^= itemTemplates_.GetHashCode();
            if (TimestampMs != 0UL) hash ^= TimestampMs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        #region Nested types

        /// <summary>Container for nested types declared in the DownloadItemTemplatesResponse message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types
        {
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed partial class ItemTemplate : pb::IMessage<ItemTemplate>
            {
                /// <summary>Field number for the "template_id" field.</summary>
                public const int TemplateIdFieldNumber = 1;

                /// <summary>Field number for the "pokemon_settings" field.</summary>
                public const int PokemonSettingsFieldNumber = 2;

                /// <summary>Field number for the "item_settings" field.</summary>
                public const int ItemSettingsFieldNumber = 3;

                /// <summary>Field number for the "move_settings" field.</summary>
                public const int MoveSettingsFieldNumber = 4;

                /// <summary>Field number for the "move_sequence_settings" field.</summary>
                public const int MoveSequenceSettingsFieldNumber = 5;

                /// <summary>Field number for the "type_effective" field.</summary>
                public const int TypeEffectiveFieldNumber = 8;

                /// <summary>Field number for the "badge_settings" field.</summary>
                public const int BadgeSettingsFieldNumber = 10;

                /// <summary>Field number for the "camera" field.</summary>
                public const int CameraFieldNumber = 11;

                /// <summary>Field number for the "player_level" field.</summary>
                public const int PlayerLevelFieldNumber = 12;

                /// <summary>Field number for the "gym_level" field.</summary>
                public const int GymLevelFieldNumber = 13;

                /// <summary>Field number for the "battle_settings" field.</summary>
                public const int BattleSettingsFieldNumber = 14;

                /// <summary>Field number for the "encounter_settings" field.</summary>
                public const int EncounterSettingsFieldNumber = 15;

                /// <summary>Field number for the "iap_item_display" field.</summary>
                public const int IapItemDisplayFieldNumber = 16;

                /// <summary>Field number for the "iap_settings" field.</summary>
                public const int IapSettingsFieldNumber = 17;

                /// <summary>Field number for the "pokemon_upgrades" field.</summary>
                public const int PokemonUpgradesFieldNumber = 18;

                /// <summary>Field number for the "equipped_badges" field.</summary>
                public const int EquippedBadgesFieldNumber = 19;

                private static readonly pb::MessageParser<ItemTemplate> _parser =
                    new pb::MessageParser<ItemTemplate>(() => new ItemTemplate());

                private global::PokeGodar.WebAPI.GeneratedCode.BadgeSettings badgeSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.GymBattleSettings battleSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.CameraSettings camera_;
                private global::PokeGodar.WebAPI.GeneratedCode.EncounterSettings encounterSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.EquippedBadgeSettings equippedBadges_;
                private global::PokeGodar.WebAPI.GeneratedCode.GymLevelSettings gymLevel_;
                private global::PokeGodar.WebAPI.GeneratedCode.IapItemDisplay iapItemDisplay_;
                private global::PokeGodar.WebAPI.GeneratedCode.IapSettings iapSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.ItemSettings itemSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.MoveSequenceSettings moveSequenceSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.MoveSettings moveSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.PlayerLevelSettings playerLevel_;
                private global::PokeGodar.WebAPI.GeneratedCode.PokemonSettings pokemonSettings_;
                private global::PokeGodar.WebAPI.GeneratedCode.PokemonUpgradeSettings pokemonUpgrades_;
                private string templateId_ = "";
                private global::PokeGodar.WebAPI.GeneratedCode.TypeEffectiveSettings typeEffective_;

                public ItemTemplate()
                {
                    OnConstruction();
                }

                public ItemTemplate(ItemTemplate other) : this()
                {
                    templateId_ = other.templateId_;
                    PokemonSettings = other.pokemonSettings_ != null ? other.PokemonSettings.Clone() : null;
                    ItemSettings = other.itemSettings_ != null ? other.ItemSettings.Clone() : null;
                    MoveSettings = other.moveSettings_ != null ? other.MoveSettings.Clone() : null;
                    MoveSequenceSettings = other.moveSequenceSettings_ != null
                        ? other.MoveSequenceSettings.Clone()
                        : null;
                    TypeEffective = other.typeEffective_ != null ? other.TypeEffective.Clone() : null;
                    BadgeSettings = other.badgeSettings_ != null ? other.BadgeSettings.Clone() : null;
                    Camera = other.camera_ != null ? other.Camera.Clone() : null;
                    PlayerLevel = other.playerLevel_ != null ? other.PlayerLevel.Clone() : null;
                    GymLevel = other.gymLevel_ != null ? other.GymLevel.Clone() : null;
                    BattleSettings = other.battleSettings_ != null ? other.BattleSettings.Clone() : null;
                    EncounterSettings = other.encounterSettings_ != null ? other.EncounterSettings.Clone() : null;
                    IapItemDisplay = other.iapItemDisplay_ != null ? other.IapItemDisplay.Clone() : null;
                    IapSettings = other.iapSettings_ != null ? other.IapSettings.Clone() : null;
                    PokemonUpgrades = other.pokemonUpgrades_ != null ? other.PokemonUpgrades.Clone() : null;
                    EquippedBadges = other.equippedBadges_ != null ? other.EquippedBadges.Clone() : null;
                }

                public static pb::MessageParser<ItemTemplate> Parser
                {
                    get { return _parser; }
                }

                public static pbr::MessageDescriptor Descriptor
                {
                    get
                    {
                        return
                            global::PokeGodar.WebAPI.GeneratedCode.DownloadItemTemplatesResponse.Descriptor
                                .NestedTypes[0];
                    }
                }

                public string TemplateId
                {
                    get { return templateId_; }
                    set { templateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.PokemonSettings PokemonSettings
                {
                    get { return pokemonSettings_; }
                    set { pokemonSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.ItemSettings ItemSettings
                {
                    get { return itemSettings_; }
                    set { itemSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.MoveSettings MoveSettings
                {
                    get { return moveSettings_; }
                    set { moveSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.MoveSequenceSettings MoveSequenceSettings
                {
                    get { return moveSequenceSettings_; }
                    set { moveSequenceSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.TypeEffectiveSettings TypeEffective
                {
                    get { return typeEffective_; }
                    set { typeEffective_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.BadgeSettings BadgeSettings
                {
                    get { return badgeSettings_; }
                    set { badgeSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.CameraSettings Camera
                {
                    get { return camera_; }
                    set { camera_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.PlayerLevelSettings PlayerLevel
                {
                    get { return playerLevel_; }
                    set { playerLevel_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.GymLevelSettings GymLevel
                {
                    get { return gymLevel_; }
                    set { gymLevel_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.GymBattleSettings BattleSettings
                {
                    get { return battleSettings_; }
                    set { battleSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.EncounterSettings EncounterSettings
                {
                    get { return encounterSettings_; }
                    set { encounterSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.IapItemDisplay IapItemDisplay
                {
                    get { return iapItemDisplay_; }
                    set { iapItemDisplay_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.IapSettings IapSettings
                {
                    get { return iapSettings_; }
                    set { iapSettings_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.PokemonUpgradeSettings PokemonUpgrades
                {
                    get { return pokemonUpgrades_; }
                    set { pokemonUpgrades_ = value; }
                }

                public global::PokeGodar.WebAPI.GeneratedCode.EquippedBadgeSettings EquippedBadges
                {
                    get { return equippedBadges_; }
                    set { equippedBadges_ = value; }
                }

                pbr::MessageDescriptor pb::IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public ItemTemplate Clone()
                {
                    return new ItemTemplate(this);
                }

                public bool Equals(ItemTemplate other)
                {
                    if (ReferenceEquals(other, null))
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (TemplateId != other.TemplateId) return false;
                    if (!Equals(PokemonSettings, other.PokemonSettings)) return false;
                    if (!Equals(ItemSettings, other.ItemSettings)) return false;
                    if (!Equals(MoveSettings, other.MoveSettings)) return false;
                    if (!Equals(MoveSequenceSettings, other.MoveSequenceSettings)) return false;
                    if (!Equals(TypeEffective, other.TypeEffective)) return false;
                    if (!Equals(BadgeSettings, other.BadgeSettings)) return false;
                    if (!Equals(Camera, other.Camera)) return false;
                    if (!Equals(PlayerLevel, other.PlayerLevel)) return false;
                    if (!Equals(GymLevel, other.GymLevel)) return false;
                    if (!Equals(BattleSettings, other.BattleSettings)) return false;
                    if (!Equals(EncounterSettings, other.EncounterSettings)) return false;
                    if (!Equals(IapItemDisplay, other.IapItemDisplay)) return false;
                    if (!Equals(IapSettings, other.IapSettings)) return false;
                    if (!Equals(PokemonUpgrades, other.PokemonUpgrades)) return false;
                    if (!Equals(EquippedBadges, other.EquippedBadges)) return false;
                    return true;
                }

                public void WriteTo(pb::CodedOutputStream output)
                {
                    if (TemplateId.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(TemplateId);
                    }
                    if (pokemonSettings_ != null)
                    {
                        output.WriteRawTag(18);
                        output.WriteMessage(PokemonSettings);
                    }
                    if (itemSettings_ != null)
                    {
                        output.WriteRawTag(26);
                        output.WriteMessage(ItemSettings);
                    }
                    if (moveSettings_ != null)
                    {
                        output.WriteRawTag(34);
                        output.WriteMessage(MoveSettings);
                    }
                    if (moveSequenceSettings_ != null)
                    {
                        output.WriteRawTag(42);
                        output.WriteMessage(MoveSequenceSettings);
                    }
                    if (typeEffective_ != null)
                    {
                        output.WriteRawTag(66);
                        output.WriteMessage(TypeEffective);
                    }
                    if (badgeSettings_ != null)
                    {
                        output.WriteRawTag(82);
                        output.WriteMessage(BadgeSettings);
                    }
                    if (camera_ != null)
                    {
                        output.WriteRawTag(90);
                        output.WriteMessage(Camera);
                    }
                    if (playerLevel_ != null)
                    {
                        output.WriteRawTag(98);
                        output.WriteMessage(PlayerLevel);
                    }
                    if (gymLevel_ != null)
                    {
                        output.WriteRawTag(106);
                        output.WriteMessage(GymLevel);
                    }
                    if (battleSettings_ != null)
                    {
                        output.WriteRawTag(114);
                        output.WriteMessage(BattleSettings);
                    }
                    if (encounterSettings_ != null)
                    {
                        output.WriteRawTag(122);
                        output.WriteMessage(EncounterSettings);
                    }
                    if (iapItemDisplay_ != null)
                    {
                        output.WriteRawTag(130, 1);
                        output.WriteMessage(IapItemDisplay);
                    }
                    if (iapSettings_ != null)
                    {
                        output.WriteRawTag(138, 1);
                        output.WriteMessage(IapSettings);
                    }
                    if (pokemonUpgrades_ != null)
                    {
                        output.WriteRawTag(146, 1);
                        output.WriteMessage(PokemonUpgrades);
                    }
                    if (equippedBadges_ != null)
                    {
                        output.WriteRawTag(154, 1);
                        output.WriteMessage(EquippedBadges);
                    }
                }

                public int CalculateSize()
                {
                    var size = 0;
                    if (TemplateId.Length != 0)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeStringSize(TemplateId);
                    }
                    if (pokemonSettings_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonSettings);
                    }
                    if (itemSettings_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemSettings);
                    }
                    if (moveSettings_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveSettings);
                    }
                    if (moveSequenceSettings_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveSequenceSettings);
                    }
                    if (typeEffective_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeEffective);
                    }
                    if (badgeSettings_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BadgeSettings);
                    }
                    if (camera_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Camera);
                    }
                    if (playerLevel_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerLevel);
                    }
                    if (gymLevel_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymLevel);
                    }
                    if (battleSettings_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleSettings);
                    }
                    if (encounterSettings_ != null)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EncounterSettings);
                    }
                    if (iapItemDisplay_ != null)
                    {
                        size += 2 + pb::CodedOutputStream.ComputeMessageSize(IapItemDisplay);
                    }
                    if (iapSettings_ != null)
                    {
                        size += 2 + pb::CodedOutputStream.ComputeMessageSize(IapSettings);
                    }
                    if (pokemonUpgrades_ != null)
                    {
                        size += 2 + pb::CodedOutputStream.ComputeMessageSize(PokemonUpgrades);
                    }
                    if (equippedBadges_ != null)
                    {
                        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EquippedBadges);
                    }
                    return size;
                }

                public void MergeFrom(ItemTemplate other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.TemplateId.Length != 0)
                    {
                        TemplateId = other.TemplateId;
                    }
                    if (other.pokemonSettings_ != null)
                    {
                        if (pokemonSettings_ == null)
                        {
                            pokemonSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonSettings();
                        }
                        PokemonSettings.MergeFrom(other.PokemonSettings);
                    }
                    if (other.itemSettings_ != null)
                    {
                        if (itemSettings_ == null)
                        {
                            itemSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.ItemSettings();
                        }
                        ItemSettings.MergeFrom(other.ItemSettings);
                    }
                    if (other.moveSettings_ != null)
                    {
                        if (moveSettings_ == null)
                        {
                            moveSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.MoveSettings();
                        }
                        MoveSettings.MergeFrom(other.MoveSettings);
                    }
                    if (other.moveSequenceSettings_ != null)
                    {
                        if (moveSequenceSettings_ == null)
                        {
                            moveSequenceSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.MoveSequenceSettings();
                        }
                        MoveSequenceSettings.MergeFrom(other.MoveSequenceSettings);
                    }
                    if (other.typeEffective_ != null)
                    {
                        if (typeEffective_ == null)
                        {
                            typeEffective_ = new global::PokeGodar.WebAPI.GeneratedCode.TypeEffectiveSettings();
                        }
                        TypeEffective.MergeFrom(other.TypeEffective);
                    }
                    if (other.badgeSettings_ != null)
                    {
                        if (badgeSettings_ == null)
                        {
                            badgeSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.BadgeSettings();
                        }
                        BadgeSettings.MergeFrom(other.BadgeSettings);
                    }
                    if (other.camera_ != null)
                    {
                        if (camera_ == null)
                        {
                            camera_ = new global::PokeGodar.WebAPI.GeneratedCode.CameraSettings();
                        }
                        Camera.MergeFrom(other.Camera);
                    }
                    if (other.playerLevel_ != null)
                    {
                        if (playerLevel_ == null)
                        {
                            playerLevel_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerLevelSettings();
                        }
                        PlayerLevel.MergeFrom(other.PlayerLevel);
                    }
                    if (other.gymLevel_ != null)
                    {
                        if (gymLevel_ == null)
                        {
                            gymLevel_ = new global::PokeGodar.WebAPI.GeneratedCode.GymLevelSettings();
                        }
                        GymLevel.MergeFrom(other.GymLevel);
                    }
                    if (other.battleSettings_ != null)
                    {
                        if (battleSettings_ == null)
                        {
                            battleSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.GymBattleSettings();
                        }
                        BattleSettings.MergeFrom(other.BattleSettings);
                    }
                    if (other.encounterSettings_ != null)
                    {
                        if (encounterSettings_ == null)
                        {
                            encounterSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.EncounterSettings();
                        }
                        EncounterSettings.MergeFrom(other.EncounterSettings);
                    }
                    if (other.iapItemDisplay_ != null)
                    {
                        if (iapItemDisplay_ == null)
                        {
                            iapItemDisplay_ = new global::PokeGodar.WebAPI.GeneratedCode.IapItemDisplay();
                        }
                        IapItemDisplay.MergeFrom(other.IapItemDisplay);
                    }
                    if (other.iapSettings_ != null)
                    {
                        if (iapSettings_ == null)
                        {
                            iapSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.IapSettings();
                        }
                        IapSettings.MergeFrom(other.IapSettings);
                    }
                    if (other.pokemonUpgrades_ != null)
                    {
                        if (pokemonUpgrades_ == null)
                        {
                            pokemonUpgrades_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonUpgradeSettings();
                        }
                        PokemonUpgrades.MergeFrom(other.PokemonUpgrades);
                    }
                    if (other.equippedBadges_ != null)
                    {
                        if (equippedBadges_ == null)
                        {
                            equippedBadges_ = new global::PokeGodar.WebAPI.GeneratedCode.EquippedBadgeSettings();
                        }
                        EquippedBadges.MergeFrom(other.EquippedBadges);
                    }
                }

                public void MergeFrom(pb::CodedInputStream input)
                {
                    uint tag;
                    while ((tag = input.ReadTag()) != 0)
                    {
                        switch (tag)
                        {
                            default:
                                input.SkipLastField();
                                break;
                            case 10:
                                {
                                    TemplateId = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    if (pokemonSettings_ == null)
                                    {
                                        pokemonSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonSettings();
                                    }
                                    input.ReadMessage(pokemonSettings_);
                                    break;
                                }
                            case 26:
                                {
                                    if (itemSettings_ == null)
                                    {
                                        itemSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.ItemSettings();
                                    }
                                    input.ReadMessage(itemSettings_);
                                    break;
                                }
                            case 34:
                                {
                                    if (moveSettings_ == null)
                                    {
                                        moveSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.MoveSettings();
                                    }
                                    input.ReadMessage(moveSettings_);
                                    break;
                                }
                            case 42:
                                {
                                    if (moveSequenceSettings_ == null)
                                    {
                                        moveSequenceSettings_ =
                                            new global::PokeGodar.WebAPI.GeneratedCode.MoveSequenceSettings();
                                    }
                                    input.ReadMessage(moveSequenceSettings_);
                                    break;
                                }
                            case 66:
                                {
                                    if (typeEffective_ == null)
                                    {
                                        typeEffective_ =
                                            new global::PokeGodar.WebAPI.GeneratedCode.TypeEffectiveSettings();
                                    }
                                    input.ReadMessage(typeEffective_);
                                    break;
                                }
                            case 82:
                                {
                                    if (badgeSettings_ == null)
                                    {
                                        badgeSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.BadgeSettings();
                                    }
                                    input.ReadMessage(badgeSettings_);
                                    break;
                                }
                            case 90:
                                {
                                    if (camera_ == null)
                                    {
                                        camera_ = new global::PokeGodar.WebAPI.GeneratedCode.CameraSettings();
                                    }
                                    input.ReadMessage(camera_);
                                    break;
                                }
                            case 98:
                                {
                                    if (playerLevel_ == null)
                                    {
                                        playerLevel_ = new global::PokeGodar.WebAPI.GeneratedCode.PlayerLevelSettings();
                                    }
                                    input.ReadMessage(playerLevel_);
                                    break;
                                }
                            case 106:
                                {
                                    if (gymLevel_ == null)
                                    {
                                        gymLevel_ = new global::PokeGodar.WebAPI.GeneratedCode.GymLevelSettings();
                                    }
                                    input.ReadMessage(gymLevel_);
                                    break;
                                }
                            case 114:
                                {
                                    if (battleSettings_ == null)
                                    {
                                        battleSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.GymBattleSettings();
                                    }
                                    input.ReadMessage(battleSettings_);
                                    break;
                                }
                            case 122:
                                {
                                    if (encounterSettings_ == null)
                                    {
                                        encounterSettings_ =
                                            new global::PokeGodar.WebAPI.GeneratedCode.EncounterSettings();
                                    }
                                    input.ReadMessage(encounterSettings_);
                                    break;
                                }
                            case 130:
                                {
                                    if (iapItemDisplay_ == null)
                                    {
                                        iapItemDisplay_ = new global::PokeGodar.WebAPI.GeneratedCode.IapItemDisplay();
                                    }
                                    input.ReadMessage(iapItemDisplay_);
                                    break;
                                }
                            case 138:
                                {
                                    if (iapSettings_ == null)
                                    {
                                        iapSettings_ = new global::PokeGodar.WebAPI.GeneratedCode.IapSettings();
                                    }
                                    input.ReadMessage(iapSettings_);
                                    break;
                                }
                            case 146:
                                {
                                    if (pokemonUpgrades_ == null)
                                    {
                                        pokemonUpgrades_ =
                                            new global::PokeGodar.WebAPI.GeneratedCode.PokemonUpgradeSettings();
                                    }
                                    input.ReadMessage(pokemonUpgrades_);
                                    break;
                                }
                            case 154:
                                {
                                    if (equippedBadges_ == null)
                                    {
                                        equippedBadges_ =
                                            new global::PokeGodar.WebAPI.GeneratedCode.EquippedBadgeSettings();
                                    }
                                    input.ReadMessage(equippedBadges_);
                                    break;
                                }
                        }
                    }
                }

                public override bool Equals(object other)
                {
                    return Equals(other as ItemTemplate);
                }

                public override int GetHashCode()
                {
                    var hash = 1;
                    if (TemplateId.Length != 0) hash ^= TemplateId.GetHashCode();
                    if (pokemonSettings_ != null) hash ^= PokemonSettings.GetHashCode();
                    if (itemSettings_ != null) hash ^= ItemSettings.GetHashCode();
                    if (moveSettings_ != null) hash ^= MoveSettings.GetHashCode();
                    if (moveSequenceSettings_ != null) hash ^= MoveSequenceSettings.GetHashCode();
                    if (typeEffective_ != null) hash ^= TypeEffective.GetHashCode();
                    if (badgeSettings_ != null) hash ^= BadgeSettings.GetHashCode();
                    if (camera_ != null) hash ^= Camera.GetHashCode();
                    if (playerLevel_ != null) hash ^= PlayerLevel.GetHashCode();
                    if (gymLevel_ != null) hash ^= GymLevel.GetHashCode();
                    if (battleSettings_ != null) hash ^= BattleSettings.GetHashCode();
                    if (encounterSettings_ != null) hash ^= EncounterSettings.GetHashCode();
                    if (iapItemDisplay_ != null) hash ^= IapItemDisplay.GetHashCode();
                    if (iapSettings_ != null) hash ^= IapSettings.GetHashCode();
                    if (pokemonUpgrades_ != null) hash ^= PokemonUpgrades.GetHashCode();
                    if (equippedBadges_ != null) hash ^= EquippedBadges.GetHashCode();
                    return hash;
                }

                partial void OnConstruction();

                public override string ToString()
                {
                    return pb::JsonFormatter.ToDiagnosticString(this);
                }
            }
        }

        #endregion
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class UseItemCaptureRequest : pb::IMessage<UseItemCaptureRequest>
    {
        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;

        /// <summary>Field number for the "encounter_id" field.</summary>
        public const int EncounterIdFieldNumber = 2;

        /// <summary>Field number for the "spawn_point_guid" field.</summary>
        public const int SpawnPointGuidFieldNumber = 3;

        private static readonly pb::MessageParser<UseItemCaptureRequest> _parser =
            new pb::MessageParser<UseItemCaptureRequest>(() => new UseItemCaptureRequest());

        private ulong encounterId_;
        private global::AllEnum.ItemId itemId_ = 0;
        private string spawnPointGuid_ = "";

        public UseItemCaptureRequest()
        {
            OnConstruction();
        }

        public UseItemCaptureRequest(UseItemCaptureRequest other) : this()
        {
            itemId_ = other.itemId_;
            encounterId_ = other.encounterId_;
            spawnPointGuid_ = other.spawnPointGuid_;
        }

        public static pb::MessageParser<UseItemCaptureRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[44]; }
        }

        public global::AllEnum.ItemId ItemId
        {
            get { return itemId_; }
            set { itemId_ = value; }
        }

        public ulong EncounterId
        {
            get { return encounterId_; }
            set { encounterId_ = value; }
        }

        public string SpawnPointGuid
        {
            get { return spawnPointGuid_; }
            set { spawnPointGuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UseItemCaptureRequest Clone()
        {
            return new UseItemCaptureRequest(this);
        }

        public bool Equals(UseItemCaptureRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ItemId != other.ItemId) return false;
            if (EncounterId != other.EncounterId) return false;
            if (SpawnPointGuid != other.SpawnPointGuid) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ItemId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)ItemId);
            }
            if (EncounterId != 0UL)
            {
                output.WriteRawTag(17);
                output.WriteFixed64(EncounterId);
            }
            if (SpawnPointGuid.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(SpawnPointGuid);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ItemId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
            }
            if (EncounterId != 0UL)
            {
                size += 1 + 8;
            }
            if (SpawnPointGuid.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointGuid);
            }
            return size;
        }

        public void MergeFrom(UseItemCaptureRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ItemId != 0)
            {
                ItemId = other.ItemId;
            }
            if (other.EncounterId != 0UL)
            {
                EncounterId = other.EncounterId;
            }
            if (other.SpawnPointGuid.Length != 0)
            {
                SpawnPointGuid = other.SpawnPointGuid;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            itemId_ = (global::AllEnum.ItemId)input.ReadEnum();
                            break;
                        }
                    case 17:
                        {
                            EncounterId = input.ReadFixed64();
                            break;
                        }
                    case 26:
                        {
                            SpawnPointGuid = input.ReadString();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as UseItemCaptureRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ItemId != 0) hash ^= ItemId.GetHashCode();
            if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
            if (SpawnPointGuid.Length != 0) hash ^= SpawnPointGuid.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class UseItemRequest : pb::IMessage<UseItemRequest>
    {
        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;

        private static readonly pb::MessageParser<UseItemRequest> _parser =
            new pb::MessageParser<UseItemRequest>(() => new UseItemRequest());

        private global::AllEnum.ItemId itemId_ = 0;

        public UseItemRequest()
        {
            OnConstruction();
        }

        public UseItemRequest(UseItemRequest other) : this()
        {
            itemId_ = other.itemId_;
        }

        public static pb::MessageParser<UseItemRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[44]; }
        }

        public global::AllEnum.ItemId ItemId
        {
            get { return itemId_; }
            set { itemId_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UseItemRequest Clone()
        {
            return new UseItemRequest(this);
        }

        public bool Equals(UseItemRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ItemId != other.ItemId) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ItemId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)ItemId);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ItemId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
            }
            return size;
        }

        public void MergeFrom(UseItemRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ItemId != 0)
            {
                ItemId = other.ItemId;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            itemId_ = (global::AllEnum.ItemId)input.ReadEnum();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as UseItemRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ItemId != 0) hash ^= ItemId.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class UseItemCaptureResponse : pb::IMessage<UseItemCaptureResponse>
    {
        /// <summary>Field number for the "success" field.</summary>
        public const int SuccessFieldNumber = 1;

        /// <summary>Field number for the "item_capture_mult" field.</summary>
        public const int ItemCaptureMultFieldNumber = 2;

        /// <summary>Field number for the "item_flee_mult" field.</summary>
        public const int ItemFleeMultFieldNumber = 3;

        /// <summary>Field number for the "stop_movement" field.</summary>
        public const int StopMovementFieldNumber = 4;

        /// <summary>Field number for the "stop_attack" field.</summary>
        public const int StopAttackFieldNumber = 5;

        /// <summary>Field number for the "target_max" field.</summary>
        public const int TargetMaxFieldNumber = 6;

        /// <summary>Field number for the "target_slow" field.</summary>
        public const int TargetSlowFieldNumber = 7;

        private static readonly pb::MessageParser<UseItemCaptureResponse> _parser =
            new pb::MessageParser<UseItemCaptureResponse>(() => new UseItemCaptureResponse());

        private double itemCaptureMult_;
        private double itemFleeMult_;
        private bool stopAttack_;
        private bool stopMovement_;
        private bool success_;
        private bool targetMax_;
        private bool targetSlow_;

        public UseItemCaptureResponse()
        {
            OnConstruction();
        }

        public UseItemCaptureResponse(UseItemCaptureResponse other) : this()
        {
            success_ = other.success_;
            itemCaptureMult_ = other.itemCaptureMult_;
            itemFleeMult_ = other.itemFleeMult_;
            stopMovement_ = other.stopMovement_;
            stopAttack_ = other.stopAttack_;
            targetMax_ = other.targetMax_;
            targetSlow_ = other.targetSlow_;
        }

        public static pb::MessageParser<UseItemCaptureResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[45]; }
        }

        public bool Success
        {
            get { return success_; }
            set { success_ = value; }
        }

        public double ItemCaptureMult
        {
            get { return itemCaptureMult_; }
            set { itemCaptureMult_ = value; }
        }

        public double ItemFleeMult
        {
            get { return itemFleeMult_; }
            set { itemFleeMult_ = value; }
        }

        public bool StopMovement
        {
            get { return stopMovement_; }
            set { stopMovement_ = value; }
        }

        public bool StopAttack
        {
            get { return stopAttack_; }
            set { stopAttack_ = value; }
        }

        public bool TargetMax
        {
            get { return targetMax_; }
            set { targetMax_ = value; }
        }

        public bool TargetSlow
        {
            get { return targetSlow_; }
            set { targetSlow_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UseItemCaptureResponse Clone()
        {
            return new UseItemCaptureResponse(this);
        }

        public bool Equals(UseItemCaptureResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Success != other.Success) return false;
            if (ItemCaptureMult != other.ItemCaptureMult) return false;
            if (ItemFleeMult != other.ItemFleeMult) return false;
            if (StopMovement != other.StopMovement) return false;
            if (StopAttack != other.StopAttack) return false;
            if (TargetMax != other.TargetMax) return false;
            if (TargetSlow != other.TargetSlow) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Success != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(Success);
            }
            if (ItemCaptureMult != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(ItemCaptureMult);
            }
            if (ItemFleeMult != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(ItemFleeMult);
            }
            if (StopMovement != false)
            {
                output.WriteRawTag(32);
                output.WriteBool(StopMovement);
            }
            if (StopAttack != false)
            {
                output.WriteRawTag(40);
                output.WriteBool(StopAttack);
            }
            if (TargetMax != false)
            {
                output.WriteRawTag(48);
                output.WriteBool(TargetMax);
            }
            if (TargetSlow != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(TargetSlow);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Success != false)
            {
                size += 1 + 1;
            }
            if (ItemCaptureMult != 0D)
            {
                size += 1 + 8;
            }
            if (ItemFleeMult != 0D)
            {
                size += 1 + 8;
            }
            if (StopMovement != false)
            {
                size += 1 + 1;
            }
            if (StopAttack != false)
            {
                size += 1 + 1;
            }
            if (TargetMax != false)
            {
                size += 1 + 1;
            }
            if (TargetSlow != false)
            {
                size += 1 + 1;
            }
            return size;
        }

        public void MergeFrom(UseItemCaptureResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Success != false)
            {
                Success = other.Success;
            }
            if (other.ItemCaptureMult != 0D)
            {
                ItemCaptureMult = other.ItemCaptureMult;
            }
            if (other.ItemFleeMult != 0D)
            {
                ItemFleeMult = other.ItemFleeMult;
            }
            if (other.StopMovement != false)
            {
                StopMovement = other.StopMovement;
            }
            if (other.StopAttack != false)
            {
                StopAttack = other.StopAttack;
            }
            if (other.TargetMax != false)
            {
                TargetMax = other.TargetMax;
            }
            if (other.TargetSlow != false)
            {
                TargetSlow = other.TargetSlow;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Success = input.ReadBool();
                            break;
                        }
                    case 17:
                        {
                            ItemCaptureMult = input.ReadDouble();
                            break;
                        }
                    case 25:
                        {
                            ItemFleeMult = input.ReadDouble();
                            break;
                        }
                    case 32:
                        {
                            StopMovement = input.ReadBool();
                            break;
                        }
                    case 40:
                        {
                            StopAttack = input.ReadBool();
                            break;
                        }
                    case 48:
                        {
                            TargetMax = input.ReadBool();
                            break;
                        }
                    case 56:
                        {
                            TargetSlow = input.ReadBool();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as UseItemCaptureResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Success != false) hash ^= Success.GetHashCode();
            if (ItemCaptureMult != 0D) hash ^= ItemCaptureMult.GetHashCode();
            if (ItemFleeMult != 0D) hash ^= ItemFleeMult.GetHashCode();
            if (StopMovement != false) hash ^= StopMovement.GetHashCode();
            if (StopAttack != false) hash ^= StopAttack.GetHashCode();
            if (TargetMax != false) hash ^= TargetMax.GetHashCode();
            if (TargetSlow != false) hash ^= TargetSlow.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class ReleasePokemonRequest : pb::IMessage<ReleasePokemonRequest>
    {
        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 1;

        private static readonly pb::MessageParser<ReleasePokemonRequest> _parser =
            new pb::MessageParser<ReleasePokemonRequest>(() => new ReleasePokemonRequest());

        private ulong pokemonId_;

        public ReleasePokemonRequest()
        {
            OnConstruction();
        }

        public ReleasePokemonRequest(ReleasePokemonRequest other) : this()
        {
            pokemonId_ = other.pokemonId_;
        }

        public static pb::MessageParser<ReleasePokemonRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[46]; }
        }

        public ulong PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ReleasePokemonRequest Clone()
        {
            return new ReleasePokemonRequest(this);
        }

        public bool Equals(ReleasePokemonRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PokemonId != other.PokemonId) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (PokemonId != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(PokemonId);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (PokemonId != 0UL)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(ReleasePokemonRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PokemonId != 0UL)
            {
                PokemonId = other.PokemonId;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            PokemonId = input.ReadFixed64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as ReleasePokemonRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class ReleasePokemonResponse : pb::IMessage<ReleasePokemonResponse>
    {
        /// <summary>Field number for the "result" field.</summary>
        public const int ResultFieldNumber = 1;

        /// <summary>Field number for the "candy_awarded" field.</summary>
        public const int CandyAwardedFieldNumber = 2;

        private static readonly pb::MessageParser<ReleasePokemonResponse> _parser =
            new pb::MessageParser<ReleasePokemonResponse>(() => new ReleasePokemonResponse());

        private int candyAwarded_;
        private global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonResponse.Types.Result result_ = 0;

        public ReleasePokemonResponse()
        {
            OnConstruction();
        }

        public ReleasePokemonResponse(ReleasePokemonResponse other) : this()
        {
            result_ = other.result_;
            candyAwarded_ = other.candyAwarded_;
        }

        public static pb::MessageParser<ReleasePokemonResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[47]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonResponse.Types.Result Result
        {
            get { return result_; }
            set { result_ = value; }
        }

        public int CandyAwarded
        {
            get { return candyAwarded_; }
            set { candyAwarded_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ReleasePokemonResponse Clone()
        {
            return new ReleasePokemonResponse(this);
        }

        public bool Equals(ReleasePokemonResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Result != other.Result) return false;
            if (CandyAwarded != other.CandyAwarded) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Result != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Result);
            }
            if (CandyAwarded != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(CandyAwarded);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Result != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
            }
            if (CandyAwarded != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(CandyAwarded);
            }
            return size;
        }

        public void MergeFrom(ReleasePokemonResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Result != 0)
            {
                Result = other.Result;
            }
            if (other.CandyAwarded != 0)
            {
                CandyAwarded = other.CandyAwarded;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            result_ =
                                (global::PokeGodar.WebAPI.GeneratedCode.ReleasePokemonResponse.Types.Result)
                                    input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            CandyAwarded = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as ReleasePokemonResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Result != 0) hash ^= Result.GetHashCode();
            if (CandyAwarded != 0) hash ^= CandyAwarded.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        #region Nested types

        /// <summary>Container for nested types declared in the ReleasePokemonResponse message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types
        {
            public enum Result
            {
                [pbr::OriginalName("UNSET")]
                Unset = 0,
                [pbr::OriginalName("SUCCESS")]
                Success = 1,
                [pbr::OriginalName("POKEMON_DEPLOYED")]
                PokemonDeployed = 2,
                [pbr::OriginalName("FAILED")]
                Failed = 3,
                [pbr::OriginalName("ERROR_POKEMON_IS_EGG")]
                ErrorPokemonIsEgg = 4,
            }
        }

        #endregion
    }

    /// <summary>
    ///     No message needed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GetHatchedEggsRequest : pb::IMessage<GetHatchedEggsRequest>
    {
        private static readonly pb::MessageParser<GetHatchedEggsRequest> _parser =
            new pb::MessageParser<GetHatchedEggsRequest>(() => new GetHatchedEggsRequest());

        public GetHatchedEggsRequest()
        {
            OnConstruction();
        }

        public GetHatchedEggsRequest(GetHatchedEggsRequest other) : this()
        {
        }

        public static pb::MessageParser<GetHatchedEggsRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[48]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetHatchedEggsRequest Clone()
        {
            return new GetHatchedEggsRequest(this);
        }

        public bool Equals(GetHatchedEggsRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
        }

        public int CalculateSize()
        {
            var size = 0;
            return size;
        }

        public void MergeFrom(GetHatchedEggsRequest other)
        {
            if (other == null)
            {
                return;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GetHatchedEggsRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     Confirm if this is correct, I think that it should be "repeated HatchedEgg hatched_eggs" or something like that.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GetHatchedEggsResponse : pb::IMessage<GetHatchedEggsResponse>
    {
        /// <summary>Field number for the "success" field.</summary>
        public const int SuccessFieldNumber = 1;

        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 2;

        /// <summary>Field number for the "experience_awarded" field.</summary>
        public const int ExperienceAwardedFieldNumber = 3;

        /// <summary>Field number for the "candy_awarded" field.</summary>
        public const int CandyAwardedFieldNumber = 4;

        /// <summary>Field number for the "stardust_awarded" field.</summary>
        public const int StardustAwardedFieldNumber = 5;

        private static readonly pb::MessageParser<GetHatchedEggsResponse> _parser =
            new pb::MessageParser<GetHatchedEggsResponse>(() => new GetHatchedEggsResponse());

        private static readonly pb::FieldCodec<ulong> _repeated_pokemonId_codec
            = pb::FieldCodec.ForUInt64(18);

        private static readonly pb::FieldCodec<int> _repeated_experienceAwarded_codec
            = pb::FieldCodec.ForInt32(26);

        private static readonly pb::FieldCodec<int> _repeated_candyAwarded_codec
            = pb::FieldCodec.ForInt32(34);

        private static readonly pb::FieldCodec<int> _repeated_stardustAwarded_codec
            = pb::FieldCodec.ForInt32(42);

        private readonly pbc::RepeatedField<int> candyAwarded_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> experienceAwarded_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<ulong> pokemonId_ = new pbc::RepeatedField<ulong>();
        private readonly pbc::RepeatedField<int> stardustAwarded_ = new pbc::RepeatedField<int>();
        private bool success_;

        public GetHatchedEggsResponse()
        {
            OnConstruction();
        }

        public GetHatchedEggsResponse(GetHatchedEggsResponse other) : this()
        {
            success_ = other.success_;
            pokemonId_ = other.pokemonId_.Clone();
            experienceAwarded_ = other.experienceAwarded_.Clone();
            candyAwarded_ = other.candyAwarded_.Clone();
            stardustAwarded_ = other.stardustAwarded_.Clone();
        }

        public static pb::MessageParser<GetHatchedEggsResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[49]; }
        }

        public bool Success
        {
            get { return success_; }
            set { success_ = value; }
        }

        /// <summary>
        ///     Might be POGOProtos.Enums.Pokemon
        /// </summary>
        public pbc::RepeatedField<ulong> PokemonId
        {
            get { return pokemonId_; }
        }

        public pbc::RepeatedField<int> ExperienceAwarded
        {
            get { return experienceAwarded_; }
        }

        public pbc::RepeatedField<int> CandyAwarded
        {
            get { return candyAwarded_; }
        }

        public pbc::RepeatedField<int> StardustAwarded
        {
            get { return stardustAwarded_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetHatchedEggsResponse Clone()
        {
            return new GetHatchedEggsResponse(this);
        }

        public bool Equals(GetHatchedEggsResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Success != other.Success) return false;
            if (!pokemonId_.Equals(other.pokemonId_)) return false;
            if (!experienceAwarded_.Equals(other.experienceAwarded_)) return false;
            if (!candyAwarded_.Equals(other.candyAwarded_)) return false;
            if (!stardustAwarded_.Equals(other.stardustAwarded_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Success != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(Success);
            }
            pokemonId_.WriteTo(output, _repeated_pokemonId_codec);
            experienceAwarded_.WriteTo(output, _repeated_experienceAwarded_codec);
            candyAwarded_.WriteTo(output, _repeated_candyAwarded_codec);
            stardustAwarded_.WriteTo(output, _repeated_stardustAwarded_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Success != false)
            {
                size += 1 + 1;
            }
            size += pokemonId_.CalculateSize(_repeated_pokemonId_codec);
            size += experienceAwarded_.CalculateSize(_repeated_experienceAwarded_codec);
            size += candyAwarded_.CalculateSize(_repeated_candyAwarded_codec);
            size += stardustAwarded_.CalculateSize(_repeated_stardustAwarded_codec);
            return size;
        }

        public void MergeFrom(GetHatchedEggsResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Success != false)
            {
                Success = other.Success;
            }
            pokemonId_.Add(other.pokemonId_);
            experienceAwarded_.Add(other.experienceAwarded_);
            candyAwarded_.Add(other.candyAwarded_);
            stardustAwarded_.Add(other.stardustAwarded_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Success = input.ReadBool();
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            pokemonId_.AddEntriesFrom(input, _repeated_pokemonId_codec);
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            experienceAwarded_.AddEntriesFrom(input, _repeated_experienceAwarded_codec);
                            break;
                        }
                    case 34:
                    case 32:
                        {
                            candyAwarded_.AddEntriesFrom(input, _repeated_candyAwarded_codec);
                            break;
                        }
                    case 42:
                    case 40:
                        {
                            stardustAwarded_.AddEntriesFrom(input, _repeated_stardustAwarded_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GetHatchedEggsResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Success != false) hash ^= Success.GetHashCode();
            hash ^= pokemonId_.GetHashCode();
            hash ^= experienceAwarded_.GetHashCode();
            hash ^= candyAwarded_.GetHashCode();
            hash ^= stardustAwarded_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortSearchRequest : pb::IMessage<FortSearchRequest>
    {
        /// <summary>Field number for the "fort_id" field.</summary>
        public const int FortIdFieldNumber = 1;

        /// <summary>Field number for the "player_latitude" field.</summary>
        public const int PlayerLatitudeFieldNumber = 2;

        /// <summary>Field number for the "player_longitude" field.</summary>
        public const int PlayerLongitudeFieldNumber = 3;

        /// <summary>Field number for the "fort_latitude" field.</summary>
        public const int FortLatitudeFieldNumber = 4;

        /// <summary>Field number for the "fort_longitude" field.</summary>
        public const int FortLongitudeFieldNumber = 5;

        private static readonly pb::MessageParser<FortSearchRequest> _parser =
            new pb::MessageParser<FortSearchRequest>(() => new FortSearchRequest());

        private string fortId_ = "";
        private double fortLatitude_;
        private double fortLongitude_;
        private double playerLatitude_;
        private double playerLongitude_;

        public FortSearchRequest()
        {
            OnConstruction();
        }

        public FortSearchRequest(FortSearchRequest other) : this()
        {
            fortId_ = other.fortId_;
            playerLatitude_ = other.playerLatitude_;
            playerLongitude_ = other.playerLongitude_;
            fortLatitude_ = other.fortLatitude_;
            fortLongitude_ = other.fortLongitude_;
        }

        public static pb::MessageParser<FortSearchRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[50]; }
        }

        public string FortId
        {
            get { return fortId_; }
            set { fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public double PlayerLatitude
        {
            get { return playerLatitude_; }
            set { playerLatitude_ = value; }
        }

        public double PlayerLongitude
        {
            get { return playerLongitude_; }
            set { playerLongitude_ = value; }
        }

        public double FortLatitude
        {
            get { return fortLatitude_; }
            set { fortLatitude_ = value; }
        }

        public double FortLongitude
        {
            get { return fortLongitude_; }
            set { fortLongitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortSearchRequest Clone()
        {
            return new FortSearchRequest(this);
        }

        public bool Equals(FortSearchRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (FortId != other.FortId) return false;
            if (PlayerLatitude != other.PlayerLatitude) return false;
            if (PlayerLongitude != other.PlayerLongitude) return false;
            if (FortLatitude != other.FortLatitude) return false;
            if (FortLongitude != other.FortLongitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (FortId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(FortId);
            }
            if (PlayerLatitude != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(PlayerLatitude);
            }
            if (PlayerLongitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(PlayerLongitude);
            }
            if (FortLatitude != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(FortLatitude);
            }
            if (FortLongitude != 0D)
            {
                output.WriteRawTag(41);
                output.WriteDouble(FortLongitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (FortId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
            }
            if (PlayerLatitude != 0D)
            {
                size += 1 + 8;
            }
            if (PlayerLongitude != 0D)
            {
                size += 1 + 8;
            }
            if (FortLatitude != 0D)
            {
                size += 1 + 8;
            }
            if (FortLongitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(FortSearchRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.FortId.Length != 0)
            {
                FortId = other.FortId;
            }
            if (other.PlayerLatitude != 0D)
            {
                PlayerLatitude = other.PlayerLatitude;
            }
            if (other.PlayerLongitude != 0D)
            {
                PlayerLongitude = other.PlayerLongitude;
            }
            if (other.FortLatitude != 0D)
            {
                FortLatitude = other.FortLatitude;
            }
            if (other.FortLongitude != 0D)
            {
                FortLongitude = other.FortLongitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            FortId = input.ReadString();
                            break;
                        }
                    case 17:
                        {
                            PlayerLatitude = input.ReadDouble();
                            break;
                        }
                    case 25:
                        {
                            PlayerLongitude = input.ReadDouble();
                            break;
                        }
                    case 33:
                        {
                            FortLatitude = input.ReadDouble();
                            break;
                        }
                    case 41:
                        {
                            FortLongitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortSearchRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (FortId.Length != 0) hash ^= FortId.GetHashCode();
            if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
            if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
            if (FortLatitude != 0D) hash ^= FortLatitude.GetHashCode();
            if (FortLongitude != 0D) hash ^= FortLongitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortSearchResponse : pb::IMessage<FortSearchResponse>
    {
        /// <summary>Field number for the "result" field.</summary>
        public const int ResultFieldNumber = 1;

        /// <summary>Field number for the "items_awarded" field.</summary>
        public const int ItemsAwardedFieldNumber = 2;

        /// <summary>Field number for the "gems_awarded" field.</summary>
        public const int GemsAwardedFieldNumber = 3;

        /// <summary>Field number for the "pokemon_data_egg" field.</summary>
        public const int PokemonDataEggFieldNumber = 4;

        /// <summary>Field number for the "experience_awarded" field.</summary>
        public const int ExperienceAwardedFieldNumber = 5;

        /// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
        public const int CooldownCompleteTimestampMsFieldNumber = 6;

        /// <summary>Field number for the "chain_hack_sequence_number" field.</summary>
        public const int ChainHackSequenceNumberFieldNumber = 7;

        private static readonly pb::MessageParser<FortSearchResponse> _parser =
            new pb::MessageParser<FortSearchResponse>(() => new FortSearchResponse());

        private static readonly
            pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.ItemAward>
            _repeated_itemsAwarded_codec
                = pb::FieldCodec.ForMessage(18,
                    global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.ItemAward.Parser);

        private readonly
            pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.ItemAward>
            itemsAwarded_ =
                new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.ItemAward>();

        private int chainHackSequenceNumber_;
        private long cooldownCompleteTimestampMs_;
        private int experienceAwarded_;
        private int gemsAwarded_;
        private global::PokeGodar.WebAPI.GeneratedCode.PokemonData pokemonDataEgg_;
        private global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.Result result_ = 0;

        public FortSearchResponse()
        {
            OnConstruction();
        }

        public FortSearchResponse(FortSearchResponse other) : this()
        {
            result_ = other.result_;
            itemsAwarded_ = other.itemsAwarded_.Clone();
            gemsAwarded_ = other.gemsAwarded_;
            PokemonDataEgg = other.pokemonDataEgg_ != null ? other.PokemonDataEgg.Clone() : null;
            experienceAwarded_ = other.experienceAwarded_;
            cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
            chainHackSequenceNumber_ = other.chainHackSequenceNumber_;
        }

        public static pb::MessageParser<FortSearchResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[51]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.Result Result
        {
            get { return result_; }
            set { result_ = value; }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.ItemAward>
            ItemsAwarded
        {
            get { return itemsAwarded_; }
        }

        public int GemsAwarded
        {
            get { return gemsAwarded_; }
            set { gemsAwarded_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokemonData PokemonDataEgg
        {
            get { return pokemonDataEgg_; }
            set { pokemonDataEgg_ = value; }
        }

        public int ExperienceAwarded
        {
            get { return experienceAwarded_; }
            set { experienceAwarded_ = value; }
        }

        public long CooldownCompleteTimestampMs
        {
            get { return cooldownCompleteTimestampMs_; }
            set { cooldownCompleteTimestampMs_ = value; }
        }

        public int ChainHackSequenceNumber
        {
            get { return chainHackSequenceNumber_; }
            set { chainHackSequenceNumber_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortSearchResponse Clone()
        {
            return new FortSearchResponse(this);
        }

        public bool Equals(FortSearchResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Result != other.Result) return false;
            if (!itemsAwarded_.Equals(other.itemsAwarded_)) return false;
            if (GemsAwarded != other.GemsAwarded) return false;
            if (!Equals(PokemonDataEgg, other.PokemonDataEgg)) return false;
            if (ExperienceAwarded != other.ExperienceAwarded) return false;
            if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs) return false;
            if (ChainHackSequenceNumber != other.ChainHackSequenceNumber) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Result != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Result);
            }
            itemsAwarded_.WriteTo(output, _repeated_itemsAwarded_codec);
            if (GemsAwarded != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(GemsAwarded);
            }
            if (pokemonDataEgg_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(PokemonDataEgg);
            }
            if (ExperienceAwarded != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(ExperienceAwarded);
            }
            if (CooldownCompleteTimestampMs != 0L)
            {
                output.WriteRawTag(48);
                output.WriteInt64(CooldownCompleteTimestampMs);
            }
            if (ChainHackSequenceNumber != 0)
            {
                output.WriteRawTag(56);
                output.WriteInt32(ChainHackSequenceNumber);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Result != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
            }
            size += itemsAwarded_.CalculateSize(_repeated_itemsAwarded_codec);
            if (GemsAwarded != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(GemsAwarded);
            }
            if (pokemonDataEgg_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonDataEgg);
            }
            if (ExperienceAwarded != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(ExperienceAwarded);
            }
            if (CooldownCompleteTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
            }
            if (ChainHackSequenceNumber != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChainHackSequenceNumber);
            }
            return size;
        }

        public void MergeFrom(FortSearchResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Result != 0)
            {
                Result = other.Result;
            }
            itemsAwarded_.Add(other.itemsAwarded_);
            if (other.GemsAwarded != 0)
            {
                GemsAwarded = other.GemsAwarded;
            }
            if (other.pokemonDataEgg_ != null)
            {
                if (pokemonDataEgg_ == null)
                {
                    pokemonDataEgg_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                }
                PokemonDataEgg.MergeFrom(other.PokemonDataEgg);
            }
            if (other.ExperienceAwarded != 0)
            {
                ExperienceAwarded = other.ExperienceAwarded;
            }
            if (other.CooldownCompleteTimestampMs != 0L)
            {
                CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
            }
            if (other.ChainHackSequenceNumber != 0)
            {
                ChainHackSequenceNumber = other.ChainHackSequenceNumber;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            result_ =
                                (global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Types.Result)input.ReadEnum();
                            break;
                        }
                    case 18:
                        {
                            itemsAwarded_.AddEntriesFrom(input, _repeated_itemsAwarded_codec);
                            break;
                        }
                    case 24:
                        {
                            GemsAwarded = input.ReadInt32();
                            break;
                        }
                    case 34:
                        {
                            if (pokemonDataEgg_ == null)
                            {
                                pokemonDataEgg_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                            }
                            input.ReadMessage(pokemonDataEgg_);
                            break;
                        }
                    case 40:
                        {
                            ExperienceAwarded = input.ReadInt32();
                            break;
                        }
                    case 48:
                        {
                            CooldownCompleteTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 56:
                        {
                            ChainHackSequenceNumber = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortSearchResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Result != 0) hash ^= Result.GetHashCode();
            hash ^= itemsAwarded_.GetHashCode();
            if (GemsAwarded != 0) hash ^= GemsAwarded.GetHashCode();
            if (pokemonDataEgg_ != null) hash ^= PokemonDataEgg.GetHashCode();
            if (ExperienceAwarded != 0) hash ^= ExperienceAwarded.GetHashCode();
            if (CooldownCompleteTimestampMs != 0L) hash ^= CooldownCompleteTimestampMs.GetHashCode();
            if (ChainHackSequenceNumber != 0) hash ^= ChainHackSequenceNumber.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        #region Nested types

        /// <summary>Container for nested types declared in the FortSearchResponse message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types
        {
            public enum Result
            {
                [pbr::OriginalName("NO_RESULT_SET")]
                NoResultSet = 0,
                [pbr::OriginalName("SUCCESS")]
                Success = 1,
                [pbr::OriginalName("OUT_OF_RANGE")]
                OutOfRange = 2,
                [pbr::OriginalName("IN_COOLDOWN_PERIOD")]
                InCooldownPeriod = 3,
                [pbr::OriginalName("INVENTORY_FULL")]
                InventoryFull = 4,
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed partial class ItemAward : pb::IMessage<ItemAward>
            {
                /// <summary>Field number for the "item_id" field.</summary>
                public const int ItemIdFieldNumber = 1;

                /// <summary>Field number for the "item_count" field.</summary>
                public const int ItemCountFieldNumber = 2;

                private static readonly pb::MessageParser<ItemAward> _parser =
                    new pb::MessageParser<ItemAward>(() => new ItemAward());

                private int itemCount_;
                private global::AllEnum.ItemId itemId_ = 0;

                public ItemAward()
                {
                    OnConstruction();
                }

                public ItemAward(ItemAward other) : this()
                {
                    itemId_ = other.itemId_;
                    itemCount_ = other.itemCount_;
                }

                public static pb::MessageParser<ItemAward> Parser
                {
                    get { return _parser; }
                }

                public static pbr::MessageDescriptor Descriptor
                {
                    get
                    {
                        return global::PokeGodar.WebAPI.GeneratedCode.FortSearchResponse.Descriptor.NestedTypes[0];
                    }
                }

                public global::AllEnum.ItemId ItemId
                {
                    get { return itemId_; }
                    set { itemId_ = value; }
                }

                public int ItemCount
                {
                    get { return itemCount_; }
                    set { itemCount_ = value; }
                }

                pbr::MessageDescriptor pb::IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public ItemAward Clone()
                {
                    return new ItemAward(this);
                }

                public bool Equals(ItemAward other)
                {
                    if (ReferenceEquals(other, null))
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (ItemId != other.ItemId) return false;
                    if (ItemCount != other.ItemCount) return false;
                    return true;
                }

                public void WriteTo(pb::CodedOutputStream output)
                {
                    if (ItemId != 0)
                    {
                        output.WriteRawTag(8);
                        output.WriteEnum((int)ItemId);
                    }
                    if (ItemCount != 0)
                    {
                        output.WriteRawTag(16);
                        output.WriteInt32(ItemCount);
                    }
                }

                public int CalculateSize()
                {
                    var size = 0;
                    if (ItemId != 0)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
                    }
                    if (ItemCount != 0)
                    {
                        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemCount);
                    }
                    return size;
                }

                public void MergeFrom(ItemAward other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.ItemId != 0)
                    {
                        ItemId = other.ItemId;
                    }
                    if (other.ItemCount != 0)
                    {
                        ItemCount = other.ItemCount;
                    }
                }

                public void MergeFrom(pb::CodedInputStream input)
                {
                    uint tag;
                    while ((tag = input.ReadTag()) != 0)
                    {
                        switch (tag)
                        {
                            default:
                                input.SkipLastField();
                                break;
                            case 8:
                                {
                                    itemId_ = (global::AllEnum.ItemId)input.ReadEnum();
                                    break;
                                }
                            case 16:
                                {
                                    ItemCount = input.ReadInt32();
                                    break;
                                }
                        }
                    }
                }

                public override bool Equals(object other)
                {
                    return Equals(other as ItemAward);
                }

                public override int GetHashCode()
                {
                    var hash = 1;
                    if (ItemId != 0) hash ^= ItemId.GetHashCode();
                    if (ItemCount != 0) hash ^= ItemCount.GetHashCode();
                    return hash;
                }

                partial void OnConstruction();

                public override string ToString()
                {
                    return pb::JsonFormatter.ToDiagnosticString(this);
                }
            }
        }

        #endregion
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortDetailsRequest : pb::IMessage<FortDetailsRequest>
    {
        /// <summary>Field number for the "fort_id" field.</summary>
        public const int FortIdFieldNumber = 1;

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 2;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 3;

        private static readonly pb::MessageParser<FortDetailsRequest> _parser =
            new pb::MessageParser<FortDetailsRequest>(() => new FortDetailsRequest());

        private string fortId_ = "";
        private double latitude_;
        private double longitude_;

        public FortDetailsRequest()
        {
            OnConstruction();
        }

        public FortDetailsRequest(FortDetailsRequest other) : this()
        {
            fortId_ = other.fortId_;
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
        }

        public static pb::MessageParser<FortDetailsRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[52]; }
        }

        public string FortId
        {
            get { return fortId_; }
            set { fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortDetailsRequest Clone()
        {
            return new FortDetailsRequest(this);
        }

        public bool Equals(FortDetailsRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (FortId != other.FortId) return false;
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (FortId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(FortId);
            }
            if (Latitude != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(Longitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (FortId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
            }
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(FortDetailsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.FortId.Length != 0)
            {
                FortId = other.FortId;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            FortId = input.ReadString();
                            break;
                        }
                    case 17:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 25:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortDetailsRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (FortId.Length != 0) hash ^= FortId.GetHashCode();
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortDetailsResponse : pb::IMessage<FortDetailsResponse>
    {
        /// <summary>Field number for the "fort_id" field.</summary>
        public const int FortIdFieldNumber = 1;

        /// <summary>Field number for the "team_color" field.</summary>
        public const int TeamColorFieldNumber = 2;

        /// <summary>Field number for the "pokemon_data" field.</summary>
        public const int PokemonDataFieldNumber = 3;

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 4;

        /// <summary>Field number for the "image_urls" field.</summary>
        public const int ImageUrlsFieldNumber = 5;

        /// <summary>Field number for the "fp" field.</summary>
        public const int FpFieldNumber = 6;

        /// <summary>Field number for the "stamina" field.</summary>
        public const int StaminaFieldNumber = 7;

        /// <summary>Field number for the "max_stamina" field.</summary>
        public const int MaxStaminaFieldNumber = 8;

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 9;

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 10;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 11;

        /// <summary>Field number for the "description" field.</summary>
        public const int DescriptionFieldNumber = 12;

        /// <summary>Field number for the "modifiers" field.</summary>
        public const int ModifiersFieldNumber = 13;

        private static readonly pb::MessageParser<FortDetailsResponse> _parser =
            new pb::MessageParser<FortDetailsResponse>(() => new FortDetailsResponse());

        private static readonly pb::FieldCodec<string> _repeated_imageUrls_codec
            = pb::FieldCodec.ForString(42);

        private static readonly pb::FieldCodec<global::PokeGodar.WebAPI.GeneratedCode.FortModifier>
            _repeated_modifiers_codec
                = pb::FieldCodec.ForMessage(106, global::PokeGodar.WebAPI.GeneratedCode.FortModifier.Parser);

        private readonly pbc::RepeatedField<string> imageUrls_ = new pbc::RepeatedField<string>();

        private readonly pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortModifier> modifiers_ =
            new pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortModifier>();

        private string description_ = "";
        private string fortId_ = "";
        private int fp_;
        private double latitude_;
        private double longitude_;
        private int maxStamina_;
        private string name_ = "";
        private global::PokeGodar.WebAPI.GeneratedCode.PokemonData pokemonData_;
        private int stamina_;
        private global::AllEnum.TeamColor teamColor_ = 0;
        private global::AllEnum.FortType type_ = 0;

        public FortDetailsResponse()
        {
            OnConstruction();
        }

        public FortDetailsResponse(FortDetailsResponse other) : this()
        {
            fortId_ = other.fortId_;
            teamColor_ = other.teamColor_;
            PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
            name_ = other.name_;
            imageUrls_ = other.imageUrls_.Clone();
            fp_ = other.fp_;
            stamina_ = other.stamina_;
            maxStamina_ = other.maxStamina_;
            type_ = other.type_;
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
            description_ = other.description_;
            modifiers_ = other.modifiers_.Clone();
        }

        public static pb::MessageParser<FortDetailsResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[53]; }
        }

        public string FortId
        {
            get { return fortId_; }
            set { fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::AllEnum.TeamColor TeamColor
        {
            get { return teamColor_; }
            set { teamColor_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokemonData PokemonData
        {
            get { return pokemonData_; }
            set { pokemonData_ = value; }
        }

        public string Name
        {
            get { return name_; }
            set { name_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public pbc::RepeatedField<string> ImageUrls
        {
            get { return imageUrls_; }
        }

        public int Fp
        {
            get { return fp_; }
            set { fp_ = value; }
        }

        public int Stamina
        {
            get { return stamina_; }
            set { stamina_ = value; }
        }

        public int MaxStamina
        {
            get { return maxStamina_; }
            set { maxStamina_ = value; }
        }

        public global::AllEnum.FortType Type
        {
            get { return type_; }
            set { type_ = value; }
        }

        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        public string Description
        {
            get { return description_; }
            set { description_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public pbc::RepeatedField<global::PokeGodar.WebAPI.GeneratedCode.FortModifier> Modifiers
        {
            get { return modifiers_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortDetailsResponse Clone()
        {
            return new FortDetailsResponse(this);
        }

        public bool Equals(FortDetailsResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (FortId != other.FortId) return false;
            if (TeamColor != other.TeamColor) return false;
            if (!Equals(PokemonData, other.PokemonData)) return false;
            if (Name != other.Name) return false;
            if (!imageUrls_.Equals(other.imageUrls_)) return false;
            if (Fp != other.Fp) return false;
            if (Stamina != other.Stamina) return false;
            if (MaxStamina != other.MaxStamina) return false;
            if (Type != other.Type) return false;
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            if (Description != other.Description) return false;
            if (!modifiers_.Equals(other.modifiers_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (FortId.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(FortId);
            }
            if (TeamColor != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)TeamColor);
            }
            if (pokemonData_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(PokemonData);
            }
            if (Name.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Name);
            }
            imageUrls_.WriteTo(output, _repeated_imageUrls_codec);
            if (Fp != 0)
            {
                output.WriteRawTag(48);
                output.WriteInt32(Fp);
            }
            if (Stamina != 0)
            {
                output.WriteRawTag(56);
                output.WriteInt32(Stamina);
            }
            if (MaxStamina != 0)
            {
                output.WriteRawTag(64);
                output.WriteInt32(MaxStamina);
            }
            if (Type != 0)
            {
                output.WriteRawTag(72);
                output.WriteEnum((int)Type);
            }
            if (Latitude != 0D)
            {
                output.WriteRawTag(81);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(89);
                output.WriteDouble(Longitude);
            }
            if (Description.Length != 0)
            {
                output.WriteRawTag(98);
                output.WriteString(Description);
            }
            modifiers_.WriteTo(output, _repeated_modifiers_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (FortId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
            }
            if (TeamColor != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)TeamColor);
            }
            if (pokemonData_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
            }
            if (Name.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
            }
            size += imageUrls_.CalculateSize(_repeated_imageUrls_codec);
            if (Fp != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fp);
            }
            if (Stamina != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
            }
            if (MaxStamina != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxStamina);
            }
            if (Type != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
            }
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            if (Description.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
            }
            size += modifiers_.CalculateSize(_repeated_modifiers_codec);
            return size;
        }

        public void MergeFrom(FortDetailsResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.FortId.Length != 0)
            {
                FortId = other.FortId;
            }
            if (other.TeamColor != 0)
            {
                TeamColor = other.TeamColor;
            }
            if (other.pokemonData_ != null)
            {
                if (pokemonData_ == null)
                {
                    pokemonData_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                }
                PokemonData.MergeFrom(other.PokemonData);
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            imageUrls_.Add(other.imageUrls_);
            if (other.Fp != 0)
            {
                Fp = other.Fp;
            }
            if (other.Stamina != 0)
            {
                Stamina = other.Stamina;
            }
            if (other.MaxStamina != 0)
            {
                MaxStamina = other.MaxStamina;
            }
            if (other.Type != 0)
            {
                Type = other.Type;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
            if (other.Description.Length != 0)
            {
                Description = other.Description;
            }
            modifiers_.Add(other.modifiers_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            FortId = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            teamColor_ = (global::AllEnum.TeamColor)input.ReadEnum();
                            break;
                        }
                    case 26:
                        {
                            if (pokemonData_ == null)
                            {
                                pokemonData_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                            }
                            input.ReadMessage(pokemonData_);
                            break;
                        }
                    case 34:
                        {
                            Name = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            imageUrls_.AddEntriesFrom(input, _repeated_imageUrls_codec);
                            break;
                        }
                    case 48:
                        {
                            Fp = input.ReadInt32();
                            break;
                        }
                    case 56:
                        {
                            Stamina = input.ReadInt32();
                            break;
                        }
                    case 64:
                        {
                            MaxStamina = input.ReadInt32();
                            break;
                        }
                    case 72:
                        {
                            type_ = (global::AllEnum.FortType)input.ReadEnum();
                            break;
                        }
                    case 81:
                        {
                            Latitude = input.ReadDouble();
                            break;
                        }
                    case 89:
                        {
                            Longitude = input.ReadDouble();
                            break;
                        }
                    case 98:
                        {
                            Description = input.ReadString();
                            break;
                        }
                    case 106:
                        {
                            modifiers_.AddEntriesFrom(input, _repeated_modifiers_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortDetailsResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (FortId.Length != 0) hash ^= FortId.GetHashCode();
            if (TeamColor != 0) hash ^= TeamColor.GetHashCode();
            if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            hash ^= imageUrls_.GetHashCode();
            if (Fp != 0) hash ^= Fp.GetHashCode();
            if (Stamina != 0) hash ^= Stamina.GetHashCode();
            if (MaxStamina != 0) hash ^= MaxStamina.GetHashCode();
            if (Type != 0) hash ^= Type.GetHashCode();
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            if (Description.Length != 0) hash ^= Description.GetHashCode();
            hash ^= modifiers_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortModifier : pb::IMessage<FortModifier>
    {
        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;

        /// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
        public const int ExpirationTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "deployer_player_codename" field.</summary>
        public const int DeployerPlayerCodenameFieldNumber = 3;

        private static readonly pb::MessageParser<FortModifier> _parser =
            new pb::MessageParser<FortModifier>(() => new FortModifier());

        private string deployerPlayerCodename_ = "";
        private long expirationTimestampMs_;
        private global::AllEnum.ItemId itemId_ = 0;

        public FortModifier()
        {
            OnConstruction();
        }

        public FortModifier(FortModifier other) : this()
        {
            itemId_ = other.itemId_;
            expirationTimestampMs_ = other.expirationTimestampMs_;
            deployerPlayerCodename_ = other.deployerPlayerCodename_;
        }

        public static pb::MessageParser<FortModifier> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[54]; }
        }

        public global::AllEnum.ItemId ItemId
        {
            get { return itemId_; }
            set { itemId_ = value; }
        }

        public long ExpirationTimestampMs
        {
            get { return expirationTimestampMs_; }
            set { expirationTimestampMs_ = value; }
        }

        public string DeployerPlayerCodename
        {
            get { return deployerPlayerCodename_; }
            set { deployerPlayerCodename_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortModifier Clone()
        {
            return new FortModifier(this);
        }

        public bool Equals(FortModifier other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ItemId != other.ItemId) return false;
            if (ExpirationTimestampMs != other.ExpirationTimestampMs) return false;
            if (DeployerPlayerCodename != other.DeployerPlayerCodename) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ItemId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)ItemId);
            }
            if (ExpirationTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(ExpirationTimestampMs);
            }
            if (DeployerPlayerCodename.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DeployerPlayerCodename);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ItemId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
            }
            if (ExpirationTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
            }
            if (DeployerPlayerCodename.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(DeployerPlayerCodename);
            }
            return size;
        }

        public void MergeFrom(FortModifier other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ItemId != 0)
            {
                ItemId = other.ItemId;
            }
            if (other.ExpirationTimestampMs != 0L)
            {
                ExpirationTimestampMs = other.ExpirationTimestampMs;
            }
            if (other.DeployerPlayerCodename.Length != 0)
            {
                DeployerPlayerCodename = other.DeployerPlayerCodename;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            itemId_ = (global::AllEnum.ItemId)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            ExpirationTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 26:
                        {
                            DeployerPlayerCodename = input.ReadString();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortModifier);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ItemId != 0) hash ^= ItemId.GetHashCode();
            if (ExpirationTimestampMs != 0L) hash ^= ExpirationTimestampMs.GetHashCode();
            if (DeployerPlayerCodename.Length != 0) hash ^= DeployerPlayerCodename.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EncounterRequest : pb::IMessage<EncounterRequest>
    {
        /// <summary>Field number for the "encounter_id" field.</summary>
        public const int EncounterIdFieldNumber = 1;

        /// <summary>Field number for the "spawnpoint_id" field.</summary>
        public const int SpawnpointIdFieldNumber = 2;

        /// <summary>Field number for the "player_latitude" field.</summary>
        public const int PlayerLatitudeFieldNumber = 3;

        /// <summary>Field number for the "player_longitude" field.</summary>
        public const int PlayerLongitudeFieldNumber = 4;

        private static readonly pb::MessageParser<EncounterRequest> _parser =
            new pb::MessageParser<EncounterRequest>(() => new EncounterRequest());

        private ulong encounterId_;
        private double playerLatitude_;
        private double playerLongitude_;
        private string spawnpointId_ = "";

        public EncounterRequest()
        {
            OnConstruction();
        }

        public EncounterRequest(EncounterRequest other) : this()
        {
            encounterId_ = other.encounterId_;
            spawnpointId_ = other.spawnpointId_;
            playerLatitude_ = other.playerLatitude_;
            playerLongitude_ = other.playerLongitude_;
        }

        public static pb::MessageParser<EncounterRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[55]; }
        }

        public ulong EncounterId
        {
            get { return encounterId_; }
            set { encounterId_ = value; }
        }

        public string SpawnpointId
        {
            get { return spawnpointId_; }
            set { spawnpointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public double PlayerLatitude
        {
            get { return playerLatitude_; }
            set { playerLatitude_ = value; }
        }

        public double PlayerLongitude
        {
            get { return playerLongitude_; }
            set { playerLongitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncounterRequest Clone()
        {
            return new EncounterRequest(this);
        }

        public bool Equals(EncounterRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (EncounterId != other.EncounterId) return false;
            if (SpawnpointId != other.SpawnpointId) return false;
            if (PlayerLatitude != other.PlayerLatitude) return false;
            if (PlayerLongitude != other.PlayerLongitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (EncounterId != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(EncounterId);
            }
            if (SpawnpointId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(SpawnpointId);
            }
            if (PlayerLatitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(PlayerLatitude);
            }
            if (PlayerLongitude != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(PlayerLongitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (EncounterId != 0UL)
            {
                size += 1 + 8;
            }
            if (SpawnpointId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnpointId);
            }
            if (PlayerLatitude != 0D)
            {
                size += 1 + 8;
            }
            if (PlayerLongitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(EncounterRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.EncounterId != 0UL)
            {
                EncounterId = other.EncounterId;
            }
            if (other.SpawnpointId.Length != 0)
            {
                SpawnpointId = other.SpawnpointId;
            }
            if (other.PlayerLatitude != 0D)
            {
                PlayerLatitude = other.PlayerLatitude;
            }
            if (other.PlayerLongitude != 0D)
            {
                PlayerLongitude = other.PlayerLongitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            EncounterId = input.ReadFixed64();
                            break;
                        }
                    case 18:
                        {
                            SpawnpointId = input.ReadString();
                            break;
                        }
                    case 25:
                        {
                            PlayerLatitude = input.ReadDouble();
                            break;
                        }
                    case 33:
                        {
                            PlayerLongitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EncounterRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
            if (SpawnpointId.Length != 0) hash ^= SpawnpointId.GetHashCode();
            if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
            if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EncounterResponse : pb::IMessage<EncounterResponse>
    {
        /// <summary>Field number for the "wild_pokemon" field.</summary>
        public const int WildPokemonFieldNumber = 1;

        /// <summary>Field number for the "background" field.</summary>
        public const int BackgroundFieldNumber = 2;

        /// <summary>Field number for the "status" field.</summary>
        public const int StatusFieldNumber = 3;

        /// <summary>Field number for the "capture_probability" field.</summary>
        public const int CaptureProbabilityFieldNumber = 4;

        private static readonly pb::MessageParser<EncounterResponse> _parser =
            new pb::MessageParser<EncounterResponse>(() => new EncounterResponse());

        private global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Background background_ = 0;
        private global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability captureProbability_;
        private global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Status status_ = 0;
        private global::PokeGodar.WebAPI.GeneratedCode.WildPokemon wildPokemon_;

        public EncounterResponse()
        {
            OnConstruction();
        }

        public EncounterResponse(EncounterResponse other) : this()
        {
            WildPokemon = other.wildPokemon_ != null ? other.WildPokemon.Clone() : null;
            background_ = other.background_;
            status_ = other.status_;
            CaptureProbability = other.captureProbability_ != null ? other.CaptureProbability.Clone() : null;
        }

        public static pb::MessageParser<EncounterResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[56]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.WildPokemon WildPokemon
        {
            get { return wildPokemon_; }
            set { wildPokemon_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Background Background
        {
            get { return background_; }
            set { background_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Status Status
        {
            get { return status_; }
            set { status_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability CaptureProbability
        {
            get { return captureProbability_; }
            set { captureProbability_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncounterResponse Clone()
        {
            return new EncounterResponse(this);
        }

        public bool Equals(EncounterResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(WildPokemon, other.WildPokemon)) return false;
            if (Background != other.Background) return false;
            if (Status != other.Status) return false;
            if (!Equals(CaptureProbability, other.CaptureProbability)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (wildPokemon_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(WildPokemon);
            }
            if (Background != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)Background);
            }
            if (Status != 0)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)Status);
            }
            if (captureProbability_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(CaptureProbability);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (wildPokemon_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(WildPokemon);
            }
            if (Background != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Background);
            }
            if (Status != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Status);
            }
            if (captureProbability_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbability);
            }
            return size;
        }

        public void MergeFrom(EncounterResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.wildPokemon_ != null)
            {
                if (wildPokemon_ == null)
                {
                    wildPokemon_ = new global::PokeGodar.WebAPI.GeneratedCode.WildPokemon();
                }
                WildPokemon.MergeFrom(other.WildPokemon);
            }
            if (other.Background != 0)
            {
                Background = other.Background;
            }
            if (other.Status != 0)
            {
                Status = other.Status;
            }
            if (other.captureProbability_ != null)
            {
                if (captureProbability_ == null)
                {
                    captureProbability_ = new global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability();
                }
                CaptureProbability.MergeFrom(other.CaptureProbability);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            if (wildPokemon_ == null)
                            {
                                wildPokemon_ = new global::PokeGodar.WebAPI.GeneratedCode.WildPokemon();
                            }
                            input.ReadMessage(wildPokemon_);
                            break;
                        }
                    case 16:
                        {
                            background_ =
                                (global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Background)
                                    input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            status_ =
                                (global::PokeGodar.WebAPI.GeneratedCode.EncounterResponse.Types.Status)input.ReadEnum();
                            break;
                        }
                    case 34:
                        {
                            if (captureProbability_ == null)
                            {
                                captureProbability_ = new global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability();
                            }
                            input.ReadMessage(captureProbability_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EncounterResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (wildPokemon_ != null) hash ^= WildPokemon.GetHashCode();
            if (Background != 0) hash ^= Background.GetHashCode();
            if (Status != 0) hash ^= Status.GetHashCode();
            if (captureProbability_ != null) hash ^= CaptureProbability.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        #region Nested types

        /// <summary>Container for nested types declared in the EncounterResponse message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types
        {
            public enum Background
            {
                [pbr::OriginalName("PARK")]
                Park = 0,
                [pbr::OriginalName("DESERT")]
                Desert = 1,
            }

            public enum Status
            {
                [pbr::OriginalName("ENCOUNTER_ERROR")]
                EncounterError = 0,
                [pbr::OriginalName("ENCOUNTER_SUCCESS")]
                EncounterSuccess = 1,
                [pbr::OriginalName("ENCOUNTER_NOT_FOUND")]
                EncounterNotFound = 2,
                [pbr::OriginalName("ENCOUNTER_CLOSED")]
                EncounterClosed = 3,
                [pbr::OriginalName("ENCOUNTER_POKEMON_FLED")]
                EncounterPokemonFled = 4,
                [pbr::OriginalName("ENCOUNTER_NOT_IN_RANGE")]
                EncounterNotInRange = 5,
                [pbr::OriginalName("ENCOUNTER_ALREADY_HAPPENED")]
                EncounterAlreadyHappened = 6,
                [pbr::OriginalName("POKEMON_INVENTORY_FULL")]
                PokemonInventoryFull = 7,
            }
        }

        #endregion
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CaptureProbability : pb::IMessage<CaptureProbability>
    {
        /// <summary>Field number for the "pokeball_type" field.</summary>
        public const int PokeballTypeFieldNumber = 1;

        /// <summary>Field number for the "capture_probability" field.</summary>
        public const int CaptureProbability_FieldNumber = 2;

        /// <summary>Field number for the "reticle_difficulty_scale" field.</summary>
        public const int ReticleDifficultyScaleFieldNumber = 12;

        private static readonly pb::MessageParser<CaptureProbability> _parser =
            new pb::MessageParser<CaptureProbability>(() => new CaptureProbability());

        private static readonly pb::FieldCodec<global::AllEnum.ItemId> _repeated_pokeballType_codec
            = pb::FieldCodec.ForEnum(10, x => (int)x, x => (global::AllEnum.ItemId)x);

        private static readonly pb::FieldCodec<float> _repeated_captureProbability_codec
            = pb::FieldCodec.ForFloat(18);

        private readonly pbc::RepeatedField<float> captureProbability_ = new pbc::RepeatedField<float>();

        private readonly pbc::RepeatedField<global::AllEnum.ItemId> pokeballType_ =
            new pbc::RepeatedField<global::AllEnum.ItemId>();

        private double reticleDifficultyScale_;

        public CaptureProbability()
        {
            OnConstruction();
        }

        public CaptureProbability(CaptureProbability other) : this()
        {
            pokeballType_ = other.pokeballType_.Clone();
            captureProbability_ = other.captureProbability_.Clone();
            reticleDifficultyScale_ = other.reticleDifficultyScale_;
        }

        public static pb::MessageParser<CaptureProbability> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[57]; }
        }

        public pbc::RepeatedField<global::AllEnum.ItemId> PokeballType
        {
            get { return pokeballType_; }
        }

        public pbc::RepeatedField<float> CaptureProbability_
        {
            get { return captureProbability_; }
        }

        public double ReticleDifficultyScale
        {
            get { return reticleDifficultyScale_; }
            set { reticleDifficultyScale_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CaptureProbability Clone()
        {
            return new CaptureProbability(this);
        }

        public bool Equals(CaptureProbability other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!pokeballType_.Equals(other.pokeballType_)) return false;
            if (!captureProbability_.Equals(other.captureProbability_)) return false;
            if (ReticleDifficultyScale != other.ReticleDifficultyScale) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            pokeballType_.WriteTo(output, _repeated_pokeballType_codec);
            captureProbability_.WriteTo(output, _repeated_captureProbability_codec);
            if (ReticleDifficultyScale != 0D)
            {
                output.WriteRawTag(97);
                output.WriteDouble(ReticleDifficultyScale);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            size += pokeballType_.CalculateSize(_repeated_pokeballType_codec);
            size += captureProbability_.CalculateSize(_repeated_captureProbability_codec);
            if (ReticleDifficultyScale != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(CaptureProbability other)
        {
            if (other == null)
            {
                return;
            }
            pokeballType_.Add(other.pokeballType_);
            captureProbability_.Add(other.captureProbability_);
            if (other.ReticleDifficultyScale != 0D)
            {
                ReticleDifficultyScale = other.ReticleDifficultyScale;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    case 8:
                        {
                            pokeballType_.AddEntriesFrom(input, _repeated_pokeballType_codec);
                            break;
                        }
                    case 18:
                    case 21:
                        {
                            captureProbability_.AddEntriesFrom(input, _repeated_captureProbability_codec);
                            break;
                        }
                    case 97:
                        {
                            ReticleDifficultyScale = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CaptureProbability);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= pokeballType_.GetHashCode();
            hash ^= captureProbability_.GetHashCode();
            if (ReticleDifficultyScale != 0D) hash ^= ReticleDifficultyScale.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class DiskEncounterRequest : pb::IMessage<DiskEncounterRequest>
    {
        /// <summary>Field number for the "encounter_id" field.</summary>
        public const int EncounterIdFieldNumber = 1;

        /// <summary>Field number for the "fort_id" field.</summary>
        public const int FortIdFieldNumber = 2;

        /// <summary>Field number for the "player_latitude" field.</summary>
        public const int PlayerLatitudeFieldNumber = 3;

        /// <summary>Field number for the "player_longitude" field.</summary>
        public const int PlayerLongitudeFieldNumber = 4;

        private static readonly pb::MessageParser<DiskEncounterRequest> _parser =
            new pb::MessageParser<DiskEncounterRequest>(() => new DiskEncounterRequest());

        private ulong encounterId_;
        private string fortId_ = "";
        private double playerLatitude_;
        private double playerLongitude_;

        public DiskEncounterRequest()
        {
            OnConstruction();
        }

        public DiskEncounterRequest(DiskEncounterRequest other) : this()
        {
            encounterId_ = other.encounterId_;
            fortId_ = other.fortId_;
            playerLatitude_ = other.playerLatitude_;
            playerLongitude_ = other.playerLongitude_;
        }

        public static pb::MessageParser<DiskEncounterRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[58]; }
        }

        public ulong EncounterId
        {
            get { return encounterId_; }
            set { encounterId_ = value; }
        }

        public string FortId
        {
            get { return fortId_; }
            set { fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public double PlayerLatitude
        {
            get { return playerLatitude_; }
            set { playerLatitude_ = value; }
        }

        public double PlayerLongitude
        {
            get { return playerLongitude_; }
            set { playerLongitude_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DiskEncounterRequest Clone()
        {
            return new DiskEncounterRequest(this);
        }

        public bool Equals(DiskEncounterRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (EncounterId != other.EncounterId) return false;
            if (FortId != other.FortId) return false;
            if (PlayerLatitude != other.PlayerLatitude) return false;
            if (PlayerLongitude != other.PlayerLongitude) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (EncounterId != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(EncounterId);
            }
            if (FortId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(FortId);
            }
            if (PlayerLatitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(PlayerLatitude);
            }
            if (PlayerLongitude != 0D)
            {
                output.WriteRawTag(33);
                output.WriteDouble(PlayerLongitude);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (EncounterId != 0UL)
            {
                size += 1 + 8;
            }
            if (FortId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
            }
            if (PlayerLatitude != 0D)
            {
                size += 1 + 8;
            }
            if (PlayerLongitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(DiskEncounterRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.EncounterId != 0UL)
            {
                EncounterId = other.EncounterId;
            }
            if (other.FortId.Length != 0)
            {
                FortId = other.FortId;
            }
            if (other.PlayerLatitude != 0D)
            {
                PlayerLatitude = other.PlayerLatitude;
            }
            if (other.PlayerLongitude != 0D)
            {
                PlayerLongitude = other.PlayerLongitude;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            EncounterId = input.ReadFixed64();
                            break;
                        }
                    case 18:
                        {
                            FortId = input.ReadString();
                            break;
                        }
                    case 25:
                        {
                            PlayerLatitude = input.ReadDouble();
                            break;
                        }
                    case 33:
                        {
                            PlayerLongitude = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as DiskEncounterRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
            if (FortId.Length != 0) hash ^= FortId.GetHashCode();
            if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
            if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class DiskEncounterResponse : pb::IMessage<DiskEncounterResponse>
    {
        /// <summary>Field number for the "result" field.</summary>
        public const int ResultFieldNumber = 1;

        /// <summary>Field number for the "pokemon_data" field.</summary>
        public const int PokemonDataFieldNumber = 2;

        /// <summary>Field number for the "capture_probability" field.</summary>
        public const int CaptureProbabilityFieldNumber = 3;

        private static readonly pb::MessageParser<DiskEncounterResponse> _parser =
            new pb::MessageParser<DiskEncounterResponse>(() => new DiskEncounterResponse());

        private global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability captureProbability_;
        private global::PokeGodar.WebAPI.GeneratedCode.PokemonData pokemonData_;
        private global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterResponse.Types.Result result_ = 0;

        public DiskEncounterResponse()
        {
            OnConstruction();
        }

        public DiskEncounterResponse(DiskEncounterResponse other) : this()
        {
            result_ = other.result_;
            PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
            CaptureProbability = other.captureProbability_ != null ? other.CaptureProbability.Clone() : null;
        }

        public static pb::MessageParser<DiskEncounterResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[59]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterResponse.Types.Result Result
        {
            get { return result_; }
            set { result_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokemonData PokemonData
        {
            get { return pokemonData_; }
            set { pokemonData_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability CaptureProbability
        {
            get { return captureProbability_; }
            set { captureProbability_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DiskEncounterResponse Clone()
        {
            return new DiskEncounterResponse(this);
        }

        public bool Equals(DiskEncounterResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Result != other.Result) return false;
            if (!Equals(PokemonData, other.PokemonData)) return false;
            if (!Equals(CaptureProbability, other.CaptureProbability)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Result != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Result);
            }
            if (pokemonData_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(PokemonData);
            }
            if (captureProbability_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(CaptureProbability);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Result != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
            }
            if (pokemonData_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
            }
            if (captureProbability_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbability);
            }
            return size;
        }

        public void MergeFrom(DiskEncounterResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Result != 0)
            {
                Result = other.Result;
            }
            if (other.pokemonData_ != null)
            {
                if (pokemonData_ == null)
                {
                    pokemonData_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                }
                PokemonData.MergeFrom(other.PokemonData);
            }
            if (other.captureProbability_ != null)
            {
                if (captureProbability_ == null)
                {
                    captureProbability_ = new global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability();
                }
                CaptureProbability.MergeFrom(other.CaptureProbability);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            result_ =
                                (global::PokeGodar.WebAPI.GeneratedCode.DiskEncounterResponse.Types.Result)
                                    input.ReadEnum();
                            break;
                        }
                    case 18:
                        {
                            if (pokemonData_ == null)
                            {
                                pokemonData_ = new global::PokeGodar.WebAPI.GeneratedCode.PokemonData();
                            }
                            input.ReadMessage(pokemonData_);
                            break;
                        }
                    case 26:
                        {
                            if (captureProbability_ == null)
                            {
                                captureProbability_ = new global::PokeGodar.WebAPI.GeneratedCode.CaptureProbability();
                            }
                            input.ReadMessage(captureProbability_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as DiskEncounterResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Result != 0) hash ^= Result.GetHashCode();
            if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
            if (captureProbability_ != null) hash ^= CaptureProbability.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        #region Nested types

        /// <summary>Container for nested types declared in the DiskEncounterResponse message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types
        {
            public enum Result
            {
                [pbr::OriginalName("UNKNOWN")]
                Unknown = 0,
                [pbr::OriginalName("SUCCESS")]
                Success = 1,
                [pbr::OriginalName("NOT_AVAILABLE")]
                NotAvailable = 2,
                [pbr::OriginalName("NOT_IN_RANGE")]
                NotInRange = 3,
                [pbr::OriginalName("ENCOUNTER_ALREADY_FINISHED")]
                EncounterAlreadyFinished = 4,
                [pbr::OriginalName("POKEMON_INVENTORY_FULL")]
                PokemonInventoryFull = 5,
            }
        }

        #endregion
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CatchPokemonRequest : pb::IMessage<CatchPokemonRequest>
    {
        /// <summary>Field number for the "encounter_id" field.</summary>
        public const int EncounterIdFieldNumber = 1;

        /// <summary>Field number for the "pokeball" field.</summary>
        public const int PokeballFieldNumber = 2;

        /// <summary>Field number for the "normalized_reticle_size" field.</summary>
        public const int NormalizedReticleSizeFieldNumber = 3;

        /// <summary>Field number for the "spawn_point_guid" field.</summary>
        public const int SpawnPointGuidFieldNumber = 4;

        /// <summary>Field number for the "hit_pokemon" field.</summary>
        public const int HitPokemonFieldNumber = 5;

        /// <summary>Field number for the "spin_modifier" field.</summary>
        public const int SpinModifierFieldNumber = 6;

        /// <summary>Field number for the "NormalizedHitPosition" field.</summary>
        public const int NormalizedHitPositionFieldNumber = 7;

        private static readonly pb::MessageParser<CatchPokemonRequest> _parser =
            new pb::MessageParser<CatchPokemonRequest>(() => new CatchPokemonRequest());

        private ulong encounterId_;
        private bool hitPokemon_;
        private double normalizedHitPosition_;
        private double normalizedReticleSize_;
        private int pokeball_;
        private string spawnPointGuid_ = "";
        private double spinModifier_;

        public CatchPokemonRequest()
        {
            OnConstruction();
        }

        public CatchPokemonRequest(CatchPokemonRequest other) : this()
        {
            encounterId_ = other.encounterId_;
            pokeball_ = other.pokeball_;
            normalizedReticleSize_ = other.normalizedReticleSize_;
            spawnPointGuid_ = other.spawnPointGuid_;
            hitPokemon_ = other.hitPokemon_;
            spinModifier_ = other.spinModifier_;
            normalizedHitPosition_ = other.normalizedHitPosition_;
        }

        public static pb::MessageParser<CatchPokemonRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[60]; }
        }

        public ulong EncounterId
        {
            get { return encounterId_; }
            set { encounterId_ = value; }
        }

        public int Pokeball
        {
            get { return pokeball_; }
            set { pokeball_ = value; }
        }

        public double NormalizedReticleSize
        {
            get { return normalizedReticleSize_; }
            set { normalizedReticleSize_ = value; }
        }

        public string SpawnPointGuid
        {
            get { return spawnPointGuid_; }
            set { spawnPointGuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public bool HitPokemon
        {
            get { return hitPokemon_; }
            set { hitPokemon_ = value; }
        }

        public double SpinModifier
        {
            get { return spinModifier_; }
            set { spinModifier_ = value; }
        }

        public double NormalizedHitPosition
        {
            get { return normalizedHitPosition_; }
            set { normalizedHitPosition_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CatchPokemonRequest Clone()
        {
            return new CatchPokemonRequest(this);
        }

        public bool Equals(CatchPokemonRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (EncounterId != other.EncounterId) return false;
            if (Pokeball != other.Pokeball) return false;
            if (NormalizedReticleSize != other.NormalizedReticleSize) return false;
            if (SpawnPointGuid != other.SpawnPointGuid) return false;
            if (HitPokemon != other.HitPokemon) return false;
            if (SpinModifier != other.SpinModifier) return false;
            if (NormalizedHitPosition != other.NormalizedHitPosition) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (EncounterId != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(EncounterId);
            }
            if (Pokeball != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Pokeball);
            }
            if (NormalizedReticleSize != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(NormalizedReticleSize);
            }
            if (SpawnPointGuid.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(SpawnPointGuid);
            }
            if (HitPokemon != false)
            {
                output.WriteRawTag(40);
                output.WriteBool(HitPokemon);
            }
            if (SpinModifier != 0D)
            {
                output.WriteRawTag(49);
                output.WriteDouble(SpinModifier);
            }
            if (NormalizedHitPosition != 0D)
            {
                output.WriteRawTag(57);
                output.WriteDouble(NormalizedHitPosition);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (EncounterId != 0UL)
            {
                size += 1 + 8;
            }
            if (Pokeball != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Pokeball);
            }
            if (NormalizedReticleSize != 0D)
            {
                size += 1 + 8;
            }
            if (SpawnPointGuid.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointGuid);
            }
            if (HitPokemon != false)
            {
                size += 1 + 1;
            }
            if (SpinModifier != 0D)
            {
                size += 1 + 8;
            }
            if (NormalizedHitPosition != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(CatchPokemonRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.EncounterId != 0UL)
            {
                EncounterId = other.EncounterId;
            }
            if (other.Pokeball != 0)
            {
                Pokeball = other.Pokeball;
            }
            if (other.NormalizedReticleSize != 0D)
            {
                NormalizedReticleSize = other.NormalizedReticleSize;
            }
            if (other.SpawnPointGuid.Length != 0)
            {
                SpawnPointGuid = other.SpawnPointGuid;
            }
            if (other.HitPokemon != false)
            {
                HitPokemon = other.HitPokemon;
            }
            if (other.SpinModifier != 0D)
            {
                SpinModifier = other.SpinModifier;
            }
            if (other.NormalizedHitPosition != 0D)
            {
                NormalizedHitPosition = other.NormalizedHitPosition;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            EncounterId = input.ReadFixed64();
                            break;
                        }
                    case 16:
                        {
                            Pokeball = input.ReadInt32();
                            break;
                        }
                    case 25:
                        {
                            NormalizedReticleSize = input.ReadDouble();
                            break;
                        }
                    case 34:
                        {
                            SpawnPointGuid = input.ReadString();
                            break;
                        }
                    case 40:
                        {
                            HitPokemon = input.ReadBool();
                            break;
                        }
                    case 49:
                        {
                            SpinModifier = input.ReadDouble();
                            break;
                        }
                    case 57:
                        {
                            NormalizedHitPosition = input.ReadDouble();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CatchPokemonRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
            if (Pokeball != 0) hash ^= Pokeball.GetHashCode();
            if (NormalizedReticleSize != 0D) hash ^= NormalizedReticleSize.GetHashCode();
            if (SpawnPointGuid.Length != 0) hash ^= SpawnPointGuid.GetHashCode();
            if (HitPokemon != false) hash ^= HitPokemon.GetHashCode();
            if (SpinModifier != 0D) hash ^= SpinModifier.GetHashCode();
            if (NormalizedHitPosition != 0D) hash ^= NormalizedHitPosition.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CatchPokemonResponse : pb::IMessage<CatchPokemonResponse>
    {
        /// <summary>Field number for the "status" field.</summary>
        public const int StatusFieldNumber = 1;

        /// <summary>Field number for the "miss_percent" field.</summary>
        public const int MissPercentFieldNumber = 2;

        /// <summary>Field number for the "captured_pokemon_id" field.</summary>
        public const int CapturedPokemonIdFieldNumber = 3;

        /// <summary>Field number for the "scores" field.</summary>
        public const int ScoresFieldNumber = 4;

        private static readonly pb::MessageParser<CatchPokemonResponse> _parser =
            new pb::MessageParser<CatchPokemonResponse>(() => new CatchPokemonResponse());

        private ulong capturedPokemonId_;
        private double missPercent_;
        private global::PokeGodar.WebAPI.GeneratedCode.CaptureScore scores_;
        private global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonResponse.Types.CatchStatus status_ = 0;

        public CatchPokemonResponse()
        {
            OnConstruction();
        }

        public CatchPokemonResponse(CatchPokemonResponse other) : this()
        {
            status_ = other.status_;
            missPercent_ = other.missPercent_;
            capturedPokemonId_ = other.capturedPokemonId_;
            Scores = other.scores_ != null ? other.Scores.Clone() : null;
        }

        public static pb::MessageParser<CatchPokemonResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[61]; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonResponse.Types.CatchStatus Status
        {
            get { return status_; }
            set { status_ = value; }
        }

        public double MissPercent
        {
            get { return missPercent_; }
            set { missPercent_ = value; }
        }

        public ulong CapturedPokemonId
        {
            get { return capturedPokemonId_; }
            set { capturedPokemonId_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.CaptureScore Scores
        {
            get { return scores_; }
            set { scores_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CatchPokemonResponse Clone()
        {
            return new CatchPokemonResponse(this);
        }

        public bool Equals(CatchPokemonResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Status != other.Status) return false;
            if (MissPercent != other.MissPercent) return false;
            if (CapturedPokemonId != other.CapturedPokemonId) return false;
            if (!Equals(Scores, other.Scores)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Status != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Status);
            }
            if (MissPercent != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(MissPercent);
            }
            if (CapturedPokemonId != 0UL)
            {
                output.WriteRawTag(24);
                output.WriteUInt64(CapturedPokemonId);
            }
            if (scores_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(Scores);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Status != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Status);
            }
            if (MissPercent != 0D)
            {
                size += 1 + 8;
            }
            if (CapturedPokemonId != 0UL)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CapturedPokemonId);
            }
            if (scores_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scores);
            }
            return size;
        }

        public void MergeFrom(CatchPokemonResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Status != 0)
            {
                Status = other.Status;
            }
            if (other.MissPercent != 0D)
            {
                MissPercent = other.MissPercent;
            }
            if (other.CapturedPokemonId != 0UL)
            {
                CapturedPokemonId = other.CapturedPokemonId;
            }
            if (other.scores_ != null)
            {
                if (scores_ == null)
                {
                    scores_ = new global::PokeGodar.WebAPI.GeneratedCode.CaptureScore();
                }
                Scores.MergeFrom(other.Scores);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            status_ =
                                (global::PokeGodar.WebAPI.GeneratedCode.CatchPokemonResponse.Types.CatchStatus)
                                    input.ReadEnum();
                            break;
                        }
                    case 17:
                        {
                            MissPercent = input.ReadDouble();
                            break;
                        }
                    case 24:
                        {
                            CapturedPokemonId = input.ReadUInt64();
                            break;
                        }
                    case 34:
                        {
                            if (scores_ == null)
                            {
                                scores_ = new global::PokeGodar.WebAPI.GeneratedCode.CaptureScore();
                            }
                            input.ReadMessage(scores_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CatchPokemonResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Status != 0) hash ^= Status.GetHashCode();
            if (MissPercent != 0D) hash ^= MissPercent.GetHashCode();
            if (CapturedPokemonId != 0UL) hash ^= CapturedPokemonId.GetHashCode();
            if (scores_ != null) hash ^= Scores.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        #region Nested types

        /// <summary>Container for nested types declared in the CatchPokemonResponse message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types
        {
            public enum CatchStatus
            {
                [pbr::OriginalName("CATCH_ERROR")]
                CatchError = 0,
                [pbr::OriginalName("CATCH_SUCCESS")]
                CatchSuccess = 1,
                [pbr::OriginalName("CATCH_ESCAPE")]
                CatchEscape = 2,
                [pbr::OriginalName("CATCH_FLEE")]
                CatchFlee = 3,
                [pbr::OriginalName("CATCH_MISSED")]
                CatchMissed = 4,
            }
        }

        #endregion
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CaptureScore : pb::IMessage<CaptureScore>
    {
        /// <summary>Field number for the "activity_type" field.</summary>
        public const int ActivityTypeFieldNumber = 1;

        /// <summary>Field number for the "xp" field.</summary>
        public const int XpFieldNumber = 2;

        /// <summary>Field number for the "candy" field.</summary>
        public const int CandyFieldNumber = 3;

        /// <summary>Field number for the "stardust" field.</summary>
        public const int StardustFieldNumber = 4;

        private static readonly pb::MessageParser<CaptureScore> _parser =
            new pb::MessageParser<CaptureScore>(() => new CaptureScore());

        private static readonly pb::FieldCodec<global::AllEnum.ActivityType> _repeated_activityType_codec
            = pb::FieldCodec.ForEnum(10, x => (int)x, x => (global::AllEnum.ActivityType)x);

        private static readonly pb::FieldCodec<int> _repeated_xp_codec
            = pb::FieldCodec.ForInt32(18);

        private static readonly pb::FieldCodec<int> _repeated_candy_codec
            = pb::FieldCodec.ForInt32(26);

        private static readonly pb::FieldCodec<int> _repeated_stardust_codec
            = pb::FieldCodec.ForInt32(34);

        private readonly pbc::RepeatedField<global::AllEnum.ActivityType> activityType_ =
            new pbc::RepeatedField<global::AllEnum.ActivityType>();

        private readonly pbc::RepeatedField<int> candy_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> stardust_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> xp_ = new pbc::RepeatedField<int>();

        public CaptureScore()
        {
            OnConstruction();
        }

        public CaptureScore(CaptureScore other) : this()
        {
            activityType_ = other.activityType_.Clone();
            xp_ = other.xp_.Clone();
            candy_ = other.candy_.Clone();
            stardust_ = other.stardust_.Clone();
        }

        public static pb::MessageParser<CaptureScore> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[62]; }
        }

        public pbc::RepeatedField<global::AllEnum.ActivityType> ActivityType
        {
            get { return activityType_; }
        }

        public pbc::RepeatedField<int> Xp
        {
            get { return xp_; }
        }

        public pbc::RepeatedField<int> Candy
        {
            get { return candy_; }
        }

        public pbc::RepeatedField<int> Stardust
        {
            get { return stardust_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CaptureScore Clone()
        {
            return new CaptureScore(this);
        }

        public bool Equals(CaptureScore other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!activityType_.Equals(other.activityType_)) return false;
            if (!xp_.Equals(other.xp_)) return false;
            if (!candy_.Equals(other.candy_)) return false;
            if (!stardust_.Equals(other.stardust_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            activityType_.WriteTo(output, _repeated_activityType_codec);
            xp_.WriteTo(output, _repeated_xp_codec);
            candy_.WriteTo(output, _repeated_candy_codec);
            stardust_.WriteTo(output, _repeated_stardust_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            size += activityType_.CalculateSize(_repeated_activityType_codec);
            size += xp_.CalculateSize(_repeated_xp_codec);
            size += candy_.CalculateSize(_repeated_candy_codec);
            size += stardust_.CalculateSize(_repeated_stardust_codec);
            return size;
        }

        public void MergeFrom(CaptureScore other)
        {
            if (other == null)
            {
                return;
            }
            activityType_.Add(other.activityType_);
            xp_.Add(other.xp_);
            candy_.Add(other.candy_);
            stardust_.Add(other.stardust_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    case 8:
                        {
                            activityType_.AddEntriesFrom(input, _repeated_activityType_codec);
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            xp_.AddEntriesFrom(input, _repeated_xp_codec);
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            candy_.AddEntriesFrom(input, _repeated_candy_codec);
                            break;
                        }
                    case 34:
                    case 32:
                        {
                            stardust_.AddEntriesFrom(input, _repeated_stardust_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CaptureScore);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= activityType_.GetHashCode();
            hash ^= xp_.GetHashCode();
            hash ^= candy_.GetHashCode();
            hash ^= stardust_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     No message needed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CheckAwardedBadgesRequest : pb::IMessage<CheckAwardedBadgesRequest>
    {
        private static readonly pb::MessageParser<CheckAwardedBadgesRequest> _parser =
            new pb::MessageParser<CheckAwardedBadgesRequest>(() => new CheckAwardedBadgesRequest());

        public CheckAwardedBadgesRequest()
        {
            OnConstruction();
        }

        public CheckAwardedBadgesRequest(CheckAwardedBadgesRequest other) : this()
        {
        }

        public static pb::MessageParser<CheckAwardedBadgesRequest> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[63]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CheckAwardedBadgesRequest Clone()
        {
            return new CheckAwardedBadgesRequest(this);
        }

        public bool Equals(CheckAwardedBadgesRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
        }

        public int CalculateSize()
        {
            var size = 0;
            return size;
        }

        public void MergeFrom(CheckAwardedBadgesRequest other)
        {
            if (other == null)
            {
                return;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CheckAwardedBadgesRequest);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     Confirm if this is correct, I think that it should be "repeated AwardedBadge awarded_badges" or something like
    ///     that.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CheckAwardedBadgesResponse : pb::IMessage<CheckAwardedBadgesResponse>
    {
        /// <summary>Field number for the "success" field.</summary>
        public const int SuccessFieldNumber = 1;

        /// <summary>Field number for the "awarded_badges" field.</summary>
        public const int AwardedBadgesFieldNumber = 2;

        /// <summary>Field number for the "awarded_badge_levels" field.</summary>
        public const int AwardedBadgeLevelsFieldNumber = 3;

        private static readonly pb::MessageParser<CheckAwardedBadgesResponse> _parser =
            new pb::MessageParser<CheckAwardedBadgesResponse>(() => new CheckAwardedBadgesResponse());

        private static readonly pb::FieldCodec<global::AllEnum.BadgeType> _repeated_awardedBadges_codec
            = pb::FieldCodec.ForEnum(18, x => (int)x, x => (global::AllEnum.BadgeType)x);

        private static readonly pb::FieldCodec<int> _repeated_awardedBadgeLevels_codec
            = pb::FieldCodec.ForInt32(26);

        private readonly pbc::RepeatedField<int> awardedBadgeLevels_ = new pbc::RepeatedField<int>();

        private readonly pbc::RepeatedField<global::AllEnum.BadgeType> awardedBadges_ =
            new pbc::RepeatedField<global::AllEnum.BadgeType>();

        private bool success_;

        public CheckAwardedBadgesResponse()
        {
            OnConstruction();
        }

        public CheckAwardedBadgesResponse(CheckAwardedBadgesResponse other) : this()
        {
            success_ = other.success_;
            awardedBadges_ = other.awardedBadges_.Clone();
            awardedBadgeLevels_ = other.awardedBadgeLevels_.Clone();
        }

        public static pb::MessageParser<CheckAwardedBadgesResponse> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[64]; }
        }

        public bool Success
        {
            get { return success_; }
            set { success_ = value; }
        }

        public pbc::RepeatedField<global::AllEnum.BadgeType> AwardedBadges
        {
            get { return awardedBadges_; }
        }

        public pbc::RepeatedField<int> AwardedBadgeLevels
        {
            get { return awardedBadgeLevels_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CheckAwardedBadgesResponse Clone()
        {
            return new CheckAwardedBadgesResponse(this);
        }

        public bool Equals(CheckAwardedBadgesResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Success != other.Success) return false;
            if (!awardedBadges_.Equals(other.awardedBadges_)) return false;
            if (!awardedBadgeLevels_.Equals(other.awardedBadgeLevels_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Success != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(Success);
            }
            awardedBadges_.WriteTo(output, _repeated_awardedBadges_codec);
            awardedBadgeLevels_.WriteTo(output, _repeated_awardedBadgeLevels_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Success != false)
            {
                size += 1 + 1;
            }
            size += awardedBadges_.CalculateSize(_repeated_awardedBadges_codec);
            size += awardedBadgeLevels_.CalculateSize(_repeated_awardedBadgeLevels_codec);
            return size;
        }

        public void MergeFrom(CheckAwardedBadgesResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Success != false)
            {
                Success = other.Success;
            }
            awardedBadges_.Add(other.awardedBadges_);
            awardedBadgeLevels_.Add(other.awardedBadgeLevels_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Success = input.ReadBool();
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            awardedBadges_.AddEntriesFrom(input, _repeated_awardedBadges_codec);
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            awardedBadgeLevels_.AddEntriesFrom(input, _repeated_awardedBadgeLevels_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CheckAwardedBadgesResponse);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Success != false) hash ^= Success.GetHashCode();
            hash ^= awardedBadges_.GetHashCode();
            hash ^= awardedBadgeLevels_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EquippedBadgeSettings : pb::IMessage<EquippedBadgeSettings>
    {
        /// <summary>Field number for the "equip_badge_cooldown_ms" field.</summary>
        public const int EquipBadgeCooldownMsFieldNumber = 1;

        /// <summary>Field number for the "catch_probability_bonus" field.</summary>
        public const int CatchProbabilityBonusFieldNumber = 2;

        /// <summary>Field number for the "flee_probability_bonus" field.</summary>
        public const int FleeProbabilityBonusFieldNumber = 3;

        private static readonly pb::MessageParser<EquippedBadgeSettings> _parser =
            new pb::MessageParser<EquippedBadgeSettings>(() => new EquippedBadgeSettings());

        private static readonly pb::FieldCodec<float> _repeated_catchProbabilityBonus_codec
            = pb::FieldCodec.ForFloat(18);

        private static readonly pb::FieldCodec<float> _repeated_fleeProbabilityBonus_codec
            = pb::FieldCodec.ForFloat(26);

        private readonly pbc::RepeatedField<float> catchProbabilityBonus_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> fleeProbabilityBonus_ = new pbc::RepeatedField<float>();
        private long equipBadgeCooldownMs_;

        public EquippedBadgeSettings()
        {
            OnConstruction();
        }

        public EquippedBadgeSettings(EquippedBadgeSettings other) : this()
        {
            equipBadgeCooldownMs_ = other.equipBadgeCooldownMs_;
            catchProbabilityBonus_ = other.catchProbabilityBonus_.Clone();
            fleeProbabilityBonus_ = other.fleeProbabilityBonus_.Clone();
        }

        public static pb::MessageParser<EquippedBadgeSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[65]; }
        }

        public long EquipBadgeCooldownMs
        {
            get { return equipBadgeCooldownMs_; }
            set { equipBadgeCooldownMs_ = value; }
        }

        public pbc::RepeatedField<float> CatchProbabilityBonus
        {
            get { return catchProbabilityBonus_; }
        }

        public pbc::RepeatedField<float> FleeProbabilityBonus
        {
            get { return fleeProbabilityBonus_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EquippedBadgeSettings Clone()
        {
            return new EquippedBadgeSettings(this);
        }

        public bool Equals(EquippedBadgeSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (EquipBadgeCooldownMs != other.EquipBadgeCooldownMs) return false;
            if (!catchProbabilityBonus_.Equals(other.catchProbabilityBonus_)) return false;
            if (!fleeProbabilityBonus_.Equals(other.fleeProbabilityBonus_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (EquipBadgeCooldownMs != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(EquipBadgeCooldownMs);
            }
            catchProbabilityBonus_.WriteTo(output, _repeated_catchProbabilityBonus_codec);
            fleeProbabilityBonus_.WriteTo(output, _repeated_fleeProbabilityBonus_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (EquipBadgeCooldownMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(EquipBadgeCooldownMs);
            }
            size += catchProbabilityBonus_.CalculateSize(_repeated_catchProbabilityBonus_codec);
            size += fleeProbabilityBonus_.CalculateSize(_repeated_fleeProbabilityBonus_codec);
            return size;
        }

        public void MergeFrom(EquippedBadgeSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.EquipBadgeCooldownMs != 0L)
            {
                EquipBadgeCooldownMs = other.EquipBadgeCooldownMs;
            }
            catchProbabilityBonus_.Add(other.catchProbabilityBonus_);
            fleeProbabilityBonus_.Add(other.fleeProbabilityBonus_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            EquipBadgeCooldownMs = input.ReadInt64();
                            break;
                        }
                    case 18:
                    case 21:
                        {
                            catchProbabilityBonus_.AddEntriesFrom(input, _repeated_catchProbabilityBonus_codec);
                            break;
                        }
                    case 26:
                    case 29:
                        {
                            fleeProbabilityBonus_.AddEntriesFrom(input, _repeated_fleeProbabilityBonus_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EquippedBadgeSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (EquipBadgeCooldownMs != 0L) hash ^= EquipBadgeCooldownMs.GetHashCode();
            hash ^= catchProbabilityBonus_.GetHashCode();
            hash ^= fleeProbabilityBonus_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PokemonUpgradeSettings : pb::IMessage<PokemonUpgradeSettings>
    {
        /// <summary>Field number for the "upgrades_per_level" field.</summary>
        public const int UpgradesPerLevelFieldNumber = 1;

        /// <summary>Field number for the "allowed_levels_above_player" field.</summary>
        public const int AllowedLevelsAbovePlayerFieldNumber = 2;

        /// <summary>Field number for the "candy_cost" field.</summary>
        public const int CandyCostFieldNumber = 3;

        /// <summary>Field number for the "stardust_cost" field.</summary>
        public const int StardustCostFieldNumber = 4;

        private static readonly pb::MessageParser<PokemonUpgradeSettings> _parser =
            new pb::MessageParser<PokemonUpgradeSettings>(() => new PokemonUpgradeSettings());

        private static readonly pb::FieldCodec<int> _repeated_candyCost_codec
            = pb::FieldCodec.ForInt32(26);

        private static readonly pb::FieldCodec<int> _repeated_stardustCost_codec
            = pb::FieldCodec.ForInt32(34);

        private readonly pbc::RepeatedField<int> candyCost_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> stardustCost_ = new pbc::RepeatedField<int>();
        private int allowedLevelsAbovePlayer_;
        private int upgradesPerLevel_;

        public PokemonUpgradeSettings()
        {
            OnConstruction();
        }

        public PokemonUpgradeSettings(PokemonUpgradeSettings other) : this()
        {
            upgradesPerLevel_ = other.upgradesPerLevel_;
            allowedLevelsAbovePlayer_ = other.allowedLevelsAbovePlayer_;
            candyCost_ = other.candyCost_.Clone();
            stardustCost_ = other.stardustCost_.Clone();
        }

        public static pb::MessageParser<PokemonUpgradeSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[66]; }
        }

        public int UpgradesPerLevel
        {
            get { return upgradesPerLevel_; }
            set { upgradesPerLevel_ = value; }
        }

        public int AllowedLevelsAbovePlayer
        {
            get { return allowedLevelsAbovePlayer_; }
            set { allowedLevelsAbovePlayer_ = value; }
        }

        public pbc::RepeatedField<int> CandyCost
        {
            get { return candyCost_; }
        }

        public pbc::RepeatedField<int> StardustCost
        {
            get { return stardustCost_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PokemonUpgradeSettings Clone()
        {
            return new PokemonUpgradeSettings(this);
        }

        public bool Equals(PokemonUpgradeSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (UpgradesPerLevel != other.UpgradesPerLevel) return false;
            if (AllowedLevelsAbovePlayer != other.AllowedLevelsAbovePlayer) return false;
            if (!candyCost_.Equals(other.candyCost_)) return false;
            if (!stardustCost_.Equals(other.stardustCost_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (UpgradesPerLevel != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(UpgradesPerLevel);
            }
            if (AllowedLevelsAbovePlayer != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(AllowedLevelsAbovePlayer);
            }
            candyCost_.WriteTo(output, _repeated_candyCost_codec);
            stardustCost_.WriteTo(output, _repeated_stardustCost_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (UpgradesPerLevel != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(UpgradesPerLevel);
            }
            if (AllowedLevelsAbovePlayer != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(AllowedLevelsAbovePlayer);
            }
            size += candyCost_.CalculateSize(_repeated_candyCost_codec);
            size += stardustCost_.CalculateSize(_repeated_stardustCost_codec);
            return size;
        }

        public void MergeFrom(PokemonUpgradeSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.UpgradesPerLevel != 0)
            {
                UpgradesPerLevel = other.UpgradesPerLevel;
            }
            if (other.AllowedLevelsAbovePlayer != 0)
            {
                AllowedLevelsAbovePlayer = other.AllowedLevelsAbovePlayer;
            }
            candyCost_.Add(other.candyCost_);
            stardustCost_.Add(other.stardustCost_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            UpgradesPerLevel = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            AllowedLevelsAbovePlayer = input.ReadInt32();
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            candyCost_.AddEntriesFrom(input, _repeated_candyCost_codec);
                            break;
                        }
                    case 34:
                    case 32:
                        {
                            stardustCost_.AddEntriesFrom(input, _repeated_stardustCost_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PokemonUpgradeSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (UpgradesPerLevel != 0) hash ^= UpgradesPerLevel.GetHashCode();
            if (AllowedLevelsAbovePlayer != 0) hash ^= AllowedLevelsAbovePlayer.GetHashCode();
            hash ^= candyCost_.GetHashCode();
            hash ^= stardustCost_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class IapSettings : pb::IMessage<IapSettings>
    {
        /// <summary>Field number for the "daily_bonus_coins" field.</summary>
        public const int DailyBonusCoinsFieldNumber = 1;

        /// <summary>Field number for the "daily_defender_bonus_per_pokemon" field.</summary>
        public const int DailyDefenderBonusPerPokemonFieldNumber = 2;

        /// <summary>Field number for the "daily_defender_bonus_max_defenders" field.</summary>
        public const int DailyDefenderBonusMaxDefendersFieldNumber = 3;

        /// <summary>Field number for the "daily_defender_bonus_currency" field.</summary>
        public const int DailyDefenderBonusCurrencyFieldNumber = 4;

        /// <summary>Field number for the "min_time_between_claims_ms" field.</summary>
        public const int MinTimeBetweenClaimsMsFieldNumber = 5;

        /// <summary>Field number for the "daily_bonus_enabled" field.</summary>
        public const int DailyBonusEnabledFieldNumber = 6;

        /// <summary>Field number for the "daily_defender_bonus_enabled" field.</summary>
        public const int DailyDefenderBonusEnabledFieldNumber = 7;

        private static readonly pb::MessageParser<IapSettings> _parser =
            new pb::MessageParser<IapSettings>(() => new IapSettings());

        private static readonly pb::FieldCodec<int> _repeated_dailyDefenderBonusPerPokemon_codec
            = pb::FieldCodec.ForInt32(18);

        private static readonly pb::FieldCodec<string> _repeated_dailyDefenderBonusCurrency_codec
            = pb::FieldCodec.ForString(34);

        private readonly pbc::RepeatedField<string> dailyDefenderBonusCurrency_ = new pbc::RepeatedField<string>();
        private readonly pbc::RepeatedField<int> dailyDefenderBonusPerPokemon_ = new pbc::RepeatedField<int>();
        private int dailyBonusCoins_;
        private bool dailyBonusEnabled_;
        private bool dailyDefenderBonusEnabled_;
        private int dailyDefenderBonusMaxDefenders_;
        private long minTimeBetweenClaimsMs_;

        public IapSettings()
        {
            OnConstruction();
        }

        public IapSettings(IapSettings other) : this()
        {
            dailyBonusCoins_ = other.dailyBonusCoins_;
            dailyDefenderBonusPerPokemon_ = other.dailyDefenderBonusPerPokemon_.Clone();
            dailyDefenderBonusMaxDefenders_ = other.dailyDefenderBonusMaxDefenders_;
            dailyDefenderBonusCurrency_ = other.dailyDefenderBonusCurrency_.Clone();
            minTimeBetweenClaimsMs_ = other.minTimeBetweenClaimsMs_;
            dailyBonusEnabled_ = other.dailyBonusEnabled_;
            dailyDefenderBonusEnabled_ = other.dailyDefenderBonusEnabled_;
        }

        public static pb::MessageParser<IapSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[67]; }
        }

        public int DailyBonusCoins
        {
            get { return dailyBonusCoins_; }
            set { dailyBonusCoins_ = value; }
        }

        public pbc::RepeatedField<int> DailyDefenderBonusPerPokemon
        {
            get { return dailyDefenderBonusPerPokemon_; }
        }

        public int DailyDefenderBonusMaxDefenders
        {
            get { return dailyDefenderBonusMaxDefenders_; }
            set { dailyDefenderBonusMaxDefenders_ = value; }
        }

        public pbc::RepeatedField<string> DailyDefenderBonusCurrency
        {
            get { return dailyDefenderBonusCurrency_; }
        }

        public long MinTimeBetweenClaimsMs
        {
            get { return minTimeBetweenClaimsMs_; }
            set { minTimeBetweenClaimsMs_ = value; }
        }

        public bool DailyBonusEnabled
        {
            get { return dailyBonusEnabled_; }
            set { dailyBonusEnabled_ = value; }
        }

        public bool DailyDefenderBonusEnabled
        {
            get { return dailyDefenderBonusEnabled_; }
            set { dailyDefenderBonusEnabled_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IapSettings Clone()
        {
            return new IapSettings(this);
        }

        public bool Equals(IapSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (DailyBonusCoins != other.DailyBonusCoins) return false;
            if (!dailyDefenderBonusPerPokemon_.Equals(other.dailyDefenderBonusPerPokemon_)) return false;
            if (DailyDefenderBonusMaxDefenders != other.DailyDefenderBonusMaxDefenders) return false;
            if (!dailyDefenderBonusCurrency_.Equals(other.dailyDefenderBonusCurrency_)) return false;
            if (MinTimeBetweenClaimsMs != other.MinTimeBetweenClaimsMs) return false;
            if (DailyBonusEnabled != other.DailyBonusEnabled) return false;
            if (DailyDefenderBonusEnabled != other.DailyDefenderBonusEnabled) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (DailyBonusCoins != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(DailyBonusCoins);
            }
            dailyDefenderBonusPerPokemon_.WriteTo(output, _repeated_dailyDefenderBonusPerPokemon_codec);
            if (DailyDefenderBonusMaxDefenders != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(DailyDefenderBonusMaxDefenders);
            }
            dailyDefenderBonusCurrency_.WriteTo(output, _repeated_dailyDefenderBonusCurrency_codec);
            if (MinTimeBetweenClaimsMs != 0L)
            {
                output.WriteRawTag(40);
                output.WriteInt64(MinTimeBetweenClaimsMs);
            }
            if (DailyBonusEnabled != false)
            {
                output.WriteRawTag(48);
                output.WriteBool(DailyBonusEnabled);
            }
            if (DailyDefenderBonusEnabled != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(DailyDefenderBonusEnabled);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (DailyBonusCoins != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DailyBonusCoins);
            }
            size += dailyDefenderBonusPerPokemon_.CalculateSize(_repeated_dailyDefenderBonusPerPokemon_codec);
            if (DailyDefenderBonusMaxDefenders != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DailyDefenderBonusMaxDefenders);
            }
            size += dailyDefenderBonusCurrency_.CalculateSize(_repeated_dailyDefenderBonusCurrency_codec);
            if (MinTimeBetweenClaimsMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(MinTimeBetweenClaimsMs);
            }
            if (DailyBonusEnabled != false)
            {
                size += 1 + 1;
            }
            if (DailyDefenderBonusEnabled != false)
            {
                size += 1 + 1;
            }
            return size;
        }

        public void MergeFrom(IapSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.DailyBonusCoins != 0)
            {
                DailyBonusCoins = other.DailyBonusCoins;
            }
            dailyDefenderBonusPerPokemon_.Add(other.dailyDefenderBonusPerPokemon_);
            if (other.DailyDefenderBonusMaxDefenders != 0)
            {
                DailyDefenderBonusMaxDefenders = other.DailyDefenderBonusMaxDefenders;
            }
            dailyDefenderBonusCurrency_.Add(other.dailyDefenderBonusCurrency_);
            if (other.MinTimeBetweenClaimsMs != 0L)
            {
                MinTimeBetweenClaimsMs = other.MinTimeBetweenClaimsMs;
            }
            if (other.DailyBonusEnabled != false)
            {
                DailyBonusEnabled = other.DailyBonusEnabled;
            }
            if (other.DailyDefenderBonusEnabled != false)
            {
                DailyDefenderBonusEnabled = other.DailyDefenderBonusEnabled;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            DailyBonusCoins = input.ReadInt32();
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            dailyDefenderBonusPerPokemon_.AddEntriesFrom(input, _repeated_dailyDefenderBonusPerPokemon_codec);
                            break;
                        }
                    case 24:
                        {
                            DailyDefenderBonusMaxDefenders = input.ReadInt32();
                            break;
                        }
                    case 34:
                        {
                            dailyDefenderBonusCurrency_.AddEntriesFrom(input, _repeated_dailyDefenderBonusCurrency_codec);
                            break;
                        }
                    case 40:
                        {
                            MinTimeBetweenClaimsMs = input.ReadInt64();
                            break;
                        }
                    case 48:
                        {
                            DailyBonusEnabled = input.ReadBool();
                            break;
                        }
                    case 56:
                        {
                            DailyDefenderBonusEnabled = input.ReadBool();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as IapSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (DailyBonusCoins != 0) hash ^= DailyBonusCoins.GetHashCode();
            hash ^= dailyDefenderBonusPerPokemon_.GetHashCode();
            if (DailyDefenderBonusMaxDefenders != 0) hash ^= DailyDefenderBonusMaxDefenders.GetHashCode();
            hash ^= dailyDefenderBonusCurrency_.GetHashCode();
            if (MinTimeBetweenClaimsMs != 0L) hash ^= MinTimeBetweenClaimsMs.GetHashCode();
            if (DailyBonusEnabled != false) hash ^= DailyBonusEnabled.GetHashCode();
            if (DailyDefenderBonusEnabled != false) hash ^= DailyDefenderBonusEnabled.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class IapItemDisplay : pb::IMessage<IapItemDisplay>
    {
        /// <summary>Field number for the "sku" field.</summary>
        public const int SkuFieldNumber = 1;

        /// <summary>Field number for the "category" field.</summary>
        public const int CategoryFieldNumber = 2;

        /// <summary>Field number for the "sort_order" field.</summary>
        public const int SortOrderFieldNumber = 3;

        /// <summary>Field number for the "item_ids" field.</summary>
        public const int ItemIdsFieldNumber = 4;

        /// <summary>Field number for the "counts" field.</summary>
        public const int CountsFieldNumber = 5;

        private static readonly pb::MessageParser<IapItemDisplay> _parser =
            new pb::MessageParser<IapItemDisplay>(() => new IapItemDisplay());

        private static readonly pb::FieldCodec<global::AllEnum.ItemId> _repeated_itemIds_codec
            = pb::FieldCodec.ForEnum(34, x => (int)x, x => (global::AllEnum.ItemId)x);

        private static readonly pb::FieldCodec<int> _repeated_counts_codec
            = pb::FieldCodec.ForInt32(42);

        private readonly pbc::RepeatedField<int> counts_ = new pbc::RepeatedField<int>();

        private readonly pbc::RepeatedField<global::AllEnum.ItemId> itemIds_ =
            new pbc::RepeatedField<global::AllEnum.ItemId>();

        private global::AllEnum.HoloIapItemCategory category_ = 0;
        private string sku_ = "";
        private int sortOrder_;

        public IapItemDisplay()
        {
            OnConstruction();
        }

        public IapItemDisplay(IapItemDisplay other) : this()
        {
            sku_ = other.sku_;
            category_ = other.category_;
            sortOrder_ = other.sortOrder_;
            itemIds_ = other.itemIds_.Clone();
            counts_ = other.counts_.Clone();
        }

        public static pb::MessageParser<IapItemDisplay> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[68]; }
        }

        public string Sku
        {
            get { return sku_; }
            set { sku_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public global::AllEnum.HoloIapItemCategory Category
        {
            get { return category_; }
            set { category_ = value; }
        }

        public int SortOrder
        {
            get { return sortOrder_; }
            set { sortOrder_ = value; }
        }

        public pbc::RepeatedField<global::AllEnum.ItemId> ItemIds
        {
            get { return itemIds_; }
        }

        public pbc::RepeatedField<int> Counts
        {
            get { return counts_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IapItemDisplay Clone()
        {
            return new IapItemDisplay(this);
        }

        public bool Equals(IapItemDisplay other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Sku != other.Sku) return false;
            if (Category != other.Category) return false;
            if (SortOrder != other.SortOrder) return false;
            if (!itemIds_.Equals(other.itemIds_)) return false;
            if (!counts_.Equals(other.counts_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Sku.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Sku);
            }
            if (Category != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)Category);
            }
            if (SortOrder != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(SortOrder);
            }
            itemIds_.WriteTo(output, _repeated_itemIds_codec);
            counts_.WriteTo(output, _repeated_counts_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Sku.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Sku);
            }
            if (Category != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Category);
            }
            if (SortOrder != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(SortOrder);
            }
            size += itemIds_.CalculateSize(_repeated_itemIds_codec);
            size += counts_.CalculateSize(_repeated_counts_codec);
            return size;
        }

        public void MergeFrom(IapItemDisplay other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Sku.Length != 0)
            {
                Sku = other.Sku;
            }
            if (other.Category != 0)
            {
                Category = other.Category;
            }
            if (other.SortOrder != 0)
            {
                SortOrder = other.SortOrder;
            }
            itemIds_.Add(other.itemIds_);
            counts_.Add(other.counts_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            Sku = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            category_ = (global::AllEnum.HoloIapItemCategory)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            SortOrder = input.ReadInt32();
                            break;
                        }
                    case 34:
                    case 32:
                        {
                            itemIds_.AddEntriesFrom(input, _repeated_itemIds_codec);
                            break;
                        }
                    case 42:
                    case 40:
                        {
                            counts_.AddEntriesFrom(input, _repeated_counts_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as IapItemDisplay);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Sku.Length != 0) hash ^= Sku.GetHashCode();
            if (Category != 0) hash ^= Category.GetHashCode();
            if (SortOrder != 0) hash ^= SortOrder.GetHashCode();
            hash ^= itemIds_.GetHashCode();
            hash ^= counts_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EncounterSettings : pb::IMessage<EncounterSettings>
    {
        /// <summary>Field number for the "spin_bonus_threshold" field.</summary>
        public const int SpinBonusThresholdFieldNumber = 1;

        /// <summary>Field number for the "excellent_throw_threshold" field.</summary>
        public const int ExcellentThrowThresholdFieldNumber = 2;

        /// <summary>Field number for the "great_throw_threshold" field.</summary>
        public const int GreatThrowThresholdFieldNumber = 3;

        /// <summary>Field number for the "nice_throw_threshold" field.</summary>
        public const int NiceThrowThresholdFieldNumber = 4;

        /// <summary>Field number for the "milestone_threshold" field.</summary>
        public const int MilestoneThresholdFieldNumber = 5;

        private static readonly pb::MessageParser<EncounterSettings> _parser =
            new pb::MessageParser<EncounterSettings>(() => new EncounterSettings());

        private float excellentThrowThreshold_;
        private float greatThrowThreshold_;
        private int milestoneThreshold_;
        private float niceThrowThreshold_;
        private float spinBonusThreshold_;

        public EncounterSettings()
        {
            OnConstruction();
        }

        public EncounterSettings(EncounterSettings other) : this()
        {
            spinBonusThreshold_ = other.spinBonusThreshold_;
            excellentThrowThreshold_ = other.excellentThrowThreshold_;
            greatThrowThreshold_ = other.greatThrowThreshold_;
            niceThrowThreshold_ = other.niceThrowThreshold_;
            milestoneThreshold_ = other.milestoneThreshold_;
        }

        public static pb::MessageParser<EncounterSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[69]; }
        }

        public float SpinBonusThreshold
        {
            get { return spinBonusThreshold_; }
            set { spinBonusThreshold_ = value; }
        }

        public float ExcellentThrowThreshold
        {
            get { return excellentThrowThreshold_; }
            set { excellentThrowThreshold_ = value; }
        }

        public float GreatThrowThreshold
        {
            get { return greatThrowThreshold_; }
            set { greatThrowThreshold_ = value; }
        }

        public float NiceThrowThreshold
        {
            get { return niceThrowThreshold_; }
            set { niceThrowThreshold_ = value; }
        }

        public int MilestoneThreshold
        {
            get { return milestoneThreshold_; }
            set { milestoneThreshold_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncounterSettings Clone()
        {
            return new EncounterSettings(this);
        }

        public bool Equals(EncounterSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (SpinBonusThreshold != other.SpinBonusThreshold) return false;
            if (ExcellentThrowThreshold != other.ExcellentThrowThreshold) return false;
            if (GreatThrowThreshold != other.GreatThrowThreshold) return false;
            if (NiceThrowThreshold != other.NiceThrowThreshold) return false;
            if (MilestoneThreshold != other.MilestoneThreshold) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (SpinBonusThreshold != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(SpinBonusThreshold);
            }
            if (ExcellentThrowThreshold != 0F)
            {
                output.WriteRawTag(21);
                output.WriteFloat(ExcellentThrowThreshold);
            }
            if (GreatThrowThreshold != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(GreatThrowThreshold);
            }
            if (NiceThrowThreshold != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(NiceThrowThreshold);
            }
            if (MilestoneThreshold != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(MilestoneThreshold);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (SpinBonusThreshold != 0F)
            {
                size += 1 + 4;
            }
            if (ExcellentThrowThreshold != 0F)
            {
                size += 1 + 4;
            }
            if (GreatThrowThreshold != 0F)
            {
                size += 1 + 4;
            }
            if (NiceThrowThreshold != 0F)
            {
                size += 1 + 4;
            }
            if (MilestoneThreshold != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MilestoneThreshold);
            }
            return size;
        }

        public void MergeFrom(EncounterSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.SpinBonusThreshold != 0F)
            {
                SpinBonusThreshold = other.SpinBonusThreshold;
            }
            if (other.ExcellentThrowThreshold != 0F)
            {
                ExcellentThrowThreshold = other.ExcellentThrowThreshold;
            }
            if (other.GreatThrowThreshold != 0F)
            {
                GreatThrowThreshold = other.GreatThrowThreshold;
            }
            if (other.NiceThrowThreshold != 0F)
            {
                NiceThrowThreshold = other.NiceThrowThreshold;
            }
            if (other.MilestoneThreshold != 0)
            {
                MilestoneThreshold = other.MilestoneThreshold;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            SpinBonusThreshold = input.ReadFloat();
                            break;
                        }
                    case 21:
                        {
                            ExcellentThrowThreshold = input.ReadFloat();
                            break;
                        }
                    case 29:
                        {
                            GreatThrowThreshold = input.ReadFloat();
                            break;
                        }
                    case 37:
                        {
                            NiceThrowThreshold = input.ReadFloat();
                            break;
                        }
                    case 40:
                        {
                            MilestoneThreshold = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EncounterSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (SpinBonusThreshold != 0F) hash ^= SpinBonusThreshold.GetHashCode();
            if (ExcellentThrowThreshold != 0F) hash ^= ExcellentThrowThreshold.GetHashCode();
            if (GreatThrowThreshold != 0F) hash ^= GreatThrowThreshold.GetHashCode();
            if (NiceThrowThreshold != 0F) hash ^= NiceThrowThreshold.GetHashCode();
            if (MilestoneThreshold != 0) hash ^= MilestoneThreshold.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GymBattleSettings : pb::IMessage<GymBattleSettings>
    {
        /// <summary>Field number for the "energy_per_sec" field.</summary>
        public const int EnergyPerSecFieldNumber = 1;

        /// <summary>Field number for the "dodge_energy_cost" field.</summary>
        public const int DodgeEnergyCostFieldNumber = 2;

        /// <summary>Field number for the "retarget_seconds" field.</summary>
        public const int RetargetSecondsFieldNumber = 3;

        /// <summary>Field number for the "enemy_attack_interval" field.</summary>
        public const int EnemyAttackIntervalFieldNumber = 4;

        /// <summary>Field number for the "attack_server_interval" field.</summary>
        public const int AttackServerIntervalFieldNumber = 5;

        /// <summary>Field number for the "round_duration_seconds" field.</summary>
        public const int RoundDurationSecondsFieldNumber = 6;

        /// <summary>Field number for the "bonus_time_per_ally_seconds" field.</summary>
        public const int BonusTimePerAllySecondsFieldNumber = 7;

        /// <summary>Field number for the "maximum_attackers_per_battle" field.</summary>
        public const int MaximumAttackersPerBattleFieldNumber = 8;

        /// <summary>Field number for the "same_type_attack_bonus_multiplier" field.</summary>
        public const int SameTypeAttackBonusMultiplierFieldNumber = 9;

        /// <summary>Field number for the "maximum_energy" field.</summary>
        public const int MaximumEnergyFieldNumber = 10;

        /// <summary>Field number for the "energy_delta_per_health_lost" field.</summary>
        public const int EnergyDeltaPerHealthLostFieldNumber = 11;

        /// <summary>Field number for the "dodge_duration_ms" field.</summary>
        public const int DodgeDurationMsFieldNumber = 12;

        /// <summary>Field number for the "minimum_player_level" field.</summary>
        public const int MinimumPlayerLevelFieldNumber = 13;

        /// <summary>Field number for the "swap_duration_ms" field.</summary>
        public const int SwapDurationMsFieldNumber = 14;

        private static readonly pb::MessageParser<GymBattleSettings> _parser =
            new pb::MessageParser<GymBattleSettings>(() => new GymBattleSettings());

        private float attackServerInterval_;
        private float bonusTimePerAllySeconds_;
        private int dodgeDurationMs_;
        private float dodgeEnergyCost_;
        private float enemyAttackInterval_;
        private float energyDeltaPerHealthLost_;
        private float energyPerSec_;
        private int maximumAttackersPerBattle_;
        private int maximumEnergy_;
        private int minimumPlayerLevel_;
        private float retargetSeconds_;
        private float roundDurationSeconds_;
        private float sameTypeAttackBonusMultiplier_;
        private int swapDurationMs_;

        public GymBattleSettings()
        {
            OnConstruction();
        }

        public GymBattleSettings(GymBattleSettings other) : this()
        {
            energyPerSec_ = other.energyPerSec_;
            dodgeEnergyCost_ = other.dodgeEnergyCost_;
            retargetSeconds_ = other.retargetSeconds_;
            enemyAttackInterval_ = other.enemyAttackInterval_;
            attackServerInterval_ = other.attackServerInterval_;
            roundDurationSeconds_ = other.roundDurationSeconds_;
            bonusTimePerAllySeconds_ = other.bonusTimePerAllySeconds_;
            maximumAttackersPerBattle_ = other.maximumAttackersPerBattle_;
            sameTypeAttackBonusMultiplier_ = other.sameTypeAttackBonusMultiplier_;
            maximumEnergy_ = other.maximumEnergy_;
            energyDeltaPerHealthLost_ = other.energyDeltaPerHealthLost_;
            dodgeDurationMs_ = other.dodgeDurationMs_;
            minimumPlayerLevel_ = other.minimumPlayerLevel_;
            swapDurationMs_ = other.swapDurationMs_;
        }

        public static pb::MessageParser<GymBattleSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[70]; }
        }

        public float EnergyPerSec
        {
            get { return energyPerSec_; }
            set { energyPerSec_ = value; }
        }

        public float DodgeEnergyCost
        {
            get { return dodgeEnergyCost_; }
            set { dodgeEnergyCost_ = value; }
        }

        public float RetargetSeconds
        {
            get { return retargetSeconds_; }
            set { retargetSeconds_ = value; }
        }

        public float EnemyAttackInterval
        {
            get { return enemyAttackInterval_; }
            set { enemyAttackInterval_ = value; }
        }

        public float AttackServerInterval
        {
            get { return attackServerInterval_; }
            set { attackServerInterval_ = value; }
        }

        public float RoundDurationSeconds
        {
            get { return roundDurationSeconds_; }
            set { roundDurationSeconds_ = value; }
        }

        public float BonusTimePerAllySeconds
        {
            get { return bonusTimePerAllySeconds_; }
            set { bonusTimePerAllySeconds_ = value; }
        }

        public int MaximumAttackersPerBattle
        {
            get { return maximumAttackersPerBattle_; }
            set { maximumAttackersPerBattle_ = value; }
        }

        public float SameTypeAttackBonusMultiplier
        {
            get { return sameTypeAttackBonusMultiplier_; }
            set { sameTypeAttackBonusMultiplier_ = value; }
        }

        public int MaximumEnergy
        {
            get { return maximumEnergy_; }
            set { maximumEnergy_ = value; }
        }

        public float EnergyDeltaPerHealthLost
        {
            get { return energyDeltaPerHealthLost_; }
            set { energyDeltaPerHealthLost_ = value; }
        }

        public int DodgeDurationMs
        {
            get { return dodgeDurationMs_; }
            set { dodgeDurationMs_ = value; }
        }

        public int MinimumPlayerLevel
        {
            get { return minimumPlayerLevel_; }
            set { minimumPlayerLevel_ = value; }
        }

        public int SwapDurationMs
        {
            get { return swapDurationMs_; }
            set { swapDurationMs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GymBattleSettings Clone()
        {
            return new GymBattleSettings(this);
        }

        public bool Equals(GymBattleSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (EnergyPerSec != other.EnergyPerSec) return false;
            if (DodgeEnergyCost != other.DodgeEnergyCost) return false;
            if (RetargetSeconds != other.RetargetSeconds) return false;
            if (EnemyAttackInterval != other.EnemyAttackInterval) return false;
            if (AttackServerInterval != other.AttackServerInterval) return false;
            if (RoundDurationSeconds != other.RoundDurationSeconds) return false;
            if (BonusTimePerAllySeconds != other.BonusTimePerAllySeconds) return false;
            if (MaximumAttackersPerBattle != other.MaximumAttackersPerBattle) return false;
            if (SameTypeAttackBonusMultiplier != other.SameTypeAttackBonusMultiplier) return false;
            if (MaximumEnergy != other.MaximumEnergy) return false;
            if (EnergyDeltaPerHealthLost != other.EnergyDeltaPerHealthLost) return false;
            if (DodgeDurationMs != other.DodgeDurationMs) return false;
            if (MinimumPlayerLevel != other.MinimumPlayerLevel) return false;
            if (SwapDurationMs != other.SwapDurationMs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (EnergyPerSec != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(EnergyPerSec);
            }
            if (DodgeEnergyCost != 0F)
            {
                output.WriteRawTag(21);
                output.WriteFloat(DodgeEnergyCost);
            }
            if (RetargetSeconds != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(RetargetSeconds);
            }
            if (EnemyAttackInterval != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(EnemyAttackInterval);
            }
            if (AttackServerInterval != 0F)
            {
                output.WriteRawTag(45);
                output.WriteFloat(AttackServerInterval);
            }
            if (RoundDurationSeconds != 0F)
            {
                output.WriteRawTag(53);
                output.WriteFloat(RoundDurationSeconds);
            }
            if (BonusTimePerAllySeconds != 0F)
            {
                output.WriteRawTag(61);
                output.WriteFloat(BonusTimePerAllySeconds);
            }
            if (MaximumAttackersPerBattle != 0)
            {
                output.WriteRawTag(64);
                output.WriteInt32(MaximumAttackersPerBattle);
            }
            if (SameTypeAttackBonusMultiplier != 0F)
            {
                output.WriteRawTag(77);
                output.WriteFloat(SameTypeAttackBonusMultiplier);
            }
            if (MaximumEnergy != 0)
            {
                output.WriteRawTag(80);
                output.WriteInt32(MaximumEnergy);
            }
            if (EnergyDeltaPerHealthLost != 0F)
            {
                output.WriteRawTag(93);
                output.WriteFloat(EnergyDeltaPerHealthLost);
            }
            if (DodgeDurationMs != 0)
            {
                output.WriteRawTag(96);
                output.WriteInt32(DodgeDurationMs);
            }
            if (MinimumPlayerLevel != 0)
            {
                output.WriteRawTag(104);
                output.WriteInt32(MinimumPlayerLevel);
            }
            if (SwapDurationMs != 0)
            {
                output.WriteRawTag(112);
                output.WriteInt32(SwapDurationMs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (EnergyPerSec != 0F)
            {
                size += 1 + 4;
            }
            if (DodgeEnergyCost != 0F)
            {
                size += 1 + 4;
            }
            if (RetargetSeconds != 0F)
            {
                size += 1 + 4;
            }
            if (EnemyAttackInterval != 0F)
            {
                size += 1 + 4;
            }
            if (AttackServerInterval != 0F)
            {
                size += 1 + 4;
            }
            if (RoundDurationSeconds != 0F)
            {
                size += 1 + 4;
            }
            if (BonusTimePerAllySeconds != 0F)
            {
                size += 1 + 4;
            }
            if (MaximumAttackersPerBattle != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumAttackersPerBattle);
            }
            if (SameTypeAttackBonusMultiplier != 0F)
            {
                size += 1 + 4;
            }
            if (MaximumEnergy != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumEnergy);
            }
            if (EnergyDeltaPerHealthLost != 0F)
            {
                size += 1 + 4;
            }
            if (DodgeDurationMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DodgeDurationMs);
            }
            if (MinimumPlayerLevel != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinimumPlayerLevel);
            }
            if (SwapDurationMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(SwapDurationMs);
            }
            return size;
        }

        public void MergeFrom(GymBattleSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.EnergyPerSec != 0F)
            {
                EnergyPerSec = other.EnergyPerSec;
            }
            if (other.DodgeEnergyCost != 0F)
            {
                DodgeEnergyCost = other.DodgeEnergyCost;
            }
            if (other.RetargetSeconds != 0F)
            {
                RetargetSeconds = other.RetargetSeconds;
            }
            if (other.EnemyAttackInterval != 0F)
            {
                EnemyAttackInterval = other.EnemyAttackInterval;
            }
            if (other.AttackServerInterval != 0F)
            {
                AttackServerInterval = other.AttackServerInterval;
            }
            if (other.RoundDurationSeconds != 0F)
            {
                RoundDurationSeconds = other.RoundDurationSeconds;
            }
            if (other.BonusTimePerAllySeconds != 0F)
            {
                BonusTimePerAllySeconds = other.BonusTimePerAllySeconds;
            }
            if (other.MaximumAttackersPerBattle != 0)
            {
                MaximumAttackersPerBattle = other.MaximumAttackersPerBattle;
            }
            if (other.SameTypeAttackBonusMultiplier != 0F)
            {
                SameTypeAttackBonusMultiplier = other.SameTypeAttackBonusMultiplier;
            }
            if (other.MaximumEnergy != 0)
            {
                MaximumEnergy = other.MaximumEnergy;
            }
            if (other.EnergyDeltaPerHealthLost != 0F)
            {
                EnergyDeltaPerHealthLost = other.EnergyDeltaPerHealthLost;
            }
            if (other.DodgeDurationMs != 0)
            {
                DodgeDurationMs = other.DodgeDurationMs;
            }
            if (other.MinimumPlayerLevel != 0)
            {
                MinimumPlayerLevel = other.MinimumPlayerLevel;
            }
            if (other.SwapDurationMs != 0)
            {
                SwapDurationMs = other.SwapDurationMs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            EnergyPerSec = input.ReadFloat();
                            break;
                        }
                    case 21:
                        {
                            DodgeEnergyCost = input.ReadFloat();
                            break;
                        }
                    case 29:
                        {
                            RetargetSeconds = input.ReadFloat();
                            break;
                        }
                    case 37:
                        {
                            EnemyAttackInterval = input.ReadFloat();
                            break;
                        }
                    case 45:
                        {
                            AttackServerInterval = input.ReadFloat();
                            break;
                        }
                    case 53:
                        {
                            RoundDurationSeconds = input.ReadFloat();
                            break;
                        }
                    case 61:
                        {
                            BonusTimePerAllySeconds = input.ReadFloat();
                            break;
                        }
                    case 64:
                        {
                            MaximumAttackersPerBattle = input.ReadInt32();
                            break;
                        }
                    case 77:
                        {
                            SameTypeAttackBonusMultiplier = input.ReadFloat();
                            break;
                        }
                    case 80:
                        {
                            MaximumEnergy = input.ReadInt32();
                            break;
                        }
                    case 93:
                        {
                            EnergyDeltaPerHealthLost = input.ReadFloat();
                            break;
                        }
                    case 96:
                        {
                            DodgeDurationMs = input.ReadInt32();
                            break;
                        }
                    case 104:
                        {
                            MinimumPlayerLevel = input.ReadInt32();
                            break;
                        }
                    case 112:
                        {
                            SwapDurationMs = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GymBattleSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (EnergyPerSec != 0F) hash ^= EnergyPerSec.GetHashCode();
            if (DodgeEnergyCost != 0F) hash ^= DodgeEnergyCost.GetHashCode();
            if (RetargetSeconds != 0F) hash ^= RetargetSeconds.GetHashCode();
            if (EnemyAttackInterval != 0F) hash ^= EnemyAttackInterval.GetHashCode();
            if (AttackServerInterval != 0F) hash ^= AttackServerInterval.GetHashCode();
            if (RoundDurationSeconds != 0F) hash ^= RoundDurationSeconds.GetHashCode();
            if (BonusTimePerAllySeconds != 0F) hash ^= BonusTimePerAllySeconds.GetHashCode();
            if (MaximumAttackersPerBattle != 0) hash ^= MaximumAttackersPerBattle.GetHashCode();
            if (SameTypeAttackBonusMultiplier != 0F) hash ^= SameTypeAttackBonusMultiplier.GetHashCode();
            if (MaximumEnergy != 0) hash ^= MaximumEnergy.GetHashCode();
            if (EnergyDeltaPerHealthLost != 0F) hash ^= EnergyDeltaPerHealthLost.GetHashCode();
            if (DodgeDurationMs != 0) hash ^= DodgeDurationMs.GetHashCode();
            if (MinimumPlayerLevel != 0) hash ^= MinimumPlayerLevel.GetHashCode();
            if (SwapDurationMs != 0) hash ^= SwapDurationMs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class GymLevelSettings : pb::IMessage<GymLevelSettings>
    {
        /// <summary>Field number for the "required_experience" field.</summary>
        public const int RequiredExperienceFieldNumber = 1;

        /// <summary>Field number for the "leader_slots" field.</summary>
        public const int LeaderSlotsFieldNumber = 2;

        /// <summary>Field number for the "trainer_slots" field.</summary>
        public const int TrainerSlotsFieldNumber = 3;

        /// <summary>Field number for the "search_roll_bonus" field.</summary>
        public const int SearchRollBonusFieldNumber = 4;

        private static readonly pb::MessageParser<GymLevelSettings> _parser =
            new pb::MessageParser<GymLevelSettings>(() => new GymLevelSettings());

        private static readonly pb::FieldCodec<int> _repeated_requiredExperience_codec
            = pb::FieldCodec.ForInt32(10);

        private static readonly pb::FieldCodec<int> _repeated_leaderSlots_codec
            = pb::FieldCodec.ForInt32(18);

        private static readonly pb::FieldCodec<int> _repeated_trainerSlots_codec
            = pb::FieldCodec.ForInt32(26);

        private static readonly pb::FieldCodec<int> _repeated_searchRollBonus_codec
            = pb::FieldCodec.ForInt32(34);

        private readonly pbc::RepeatedField<int> leaderSlots_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> requiredExperience_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> searchRollBonus_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> trainerSlots_ = new pbc::RepeatedField<int>();

        public GymLevelSettings()
        {
            OnConstruction();
        }

        public GymLevelSettings(GymLevelSettings other) : this()
        {
            requiredExperience_ = other.requiredExperience_.Clone();
            leaderSlots_ = other.leaderSlots_.Clone();
            trainerSlots_ = other.trainerSlots_.Clone();
            searchRollBonus_ = other.searchRollBonus_.Clone();
        }

        public static pb::MessageParser<GymLevelSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[71]; }
        }

        public pbc::RepeatedField<int> RequiredExperience
        {
            get { return requiredExperience_; }
        }

        public pbc::RepeatedField<int> LeaderSlots
        {
            get { return leaderSlots_; }
        }

        public pbc::RepeatedField<int> TrainerSlots
        {
            get { return trainerSlots_; }
        }

        public pbc::RepeatedField<int> SearchRollBonus
        {
            get { return searchRollBonus_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GymLevelSettings Clone()
        {
            return new GymLevelSettings(this);
        }

        public bool Equals(GymLevelSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!requiredExperience_.Equals(other.requiredExperience_)) return false;
            if (!leaderSlots_.Equals(other.leaderSlots_)) return false;
            if (!trainerSlots_.Equals(other.trainerSlots_)) return false;
            if (!searchRollBonus_.Equals(other.searchRollBonus_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            requiredExperience_.WriteTo(output, _repeated_requiredExperience_codec);
            leaderSlots_.WriteTo(output, _repeated_leaderSlots_codec);
            trainerSlots_.WriteTo(output, _repeated_trainerSlots_codec);
            searchRollBonus_.WriteTo(output, _repeated_searchRollBonus_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            size += requiredExperience_.CalculateSize(_repeated_requiredExperience_codec);
            size += leaderSlots_.CalculateSize(_repeated_leaderSlots_codec);
            size += trainerSlots_.CalculateSize(_repeated_trainerSlots_codec);
            size += searchRollBonus_.CalculateSize(_repeated_searchRollBonus_codec);
            return size;
        }

        public void MergeFrom(GymLevelSettings other)
        {
            if (other == null)
            {
                return;
            }
            requiredExperience_.Add(other.requiredExperience_);
            leaderSlots_.Add(other.leaderSlots_);
            trainerSlots_.Add(other.trainerSlots_);
            searchRollBonus_.Add(other.searchRollBonus_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    case 8:
                        {
                            requiredExperience_.AddEntriesFrom(input, _repeated_requiredExperience_codec);
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            leaderSlots_.AddEntriesFrom(input, _repeated_leaderSlots_codec);
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            trainerSlots_.AddEntriesFrom(input, _repeated_trainerSlots_codec);
                            break;
                        }
                    case 34:
                    case 32:
                        {
                            searchRollBonus_.AddEntriesFrom(input, _repeated_searchRollBonus_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as GymLevelSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= requiredExperience_.GetHashCode();
            hash ^= leaderSlots_.GetHashCode();
            hash ^= trainerSlots_.GetHashCode();
            hash ^= searchRollBonus_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PlayerLevelSettings : pb::IMessage<PlayerLevelSettings>
    {
        /// <summary>Field number for the "rank_num" field.</summary>
        public const int RankNumFieldNumber = 1;

        /// <summary>Field number for the "required_experience" field.</summary>
        public const int RequiredExperienceFieldNumber = 2;

        /// <summary>Field number for the "cp_multiplier" field.</summary>
        public const int CpMultiplierFieldNumber = 3;

        /// <summary>Field number for the "max_egg_player_level" field.</summary>
        public const int MaxEggPlayerLevelFieldNumber = 4;

        /// <summary>Field number for the "max_encounter_player_level" field.</summary>
        public const int MaxEncounterPlayerLevelFieldNumber = 5;

        private static readonly pb::MessageParser<PlayerLevelSettings> _parser =
            new pb::MessageParser<PlayerLevelSettings>(() => new PlayerLevelSettings());

        private static readonly pb::FieldCodec<int> _repeated_rankNum_codec
            = pb::FieldCodec.ForInt32(10);

        private static readonly pb::FieldCodec<int> _repeated_requiredExperience_codec
            = pb::FieldCodec.ForInt32(18);

        private static readonly pb::FieldCodec<float> _repeated_cpMultiplier_codec
            = pb::FieldCodec.ForFloat(26);

        private readonly pbc::RepeatedField<float> cpMultiplier_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<int> rankNum_ = new pbc::RepeatedField<int>();
        private readonly pbc::RepeatedField<int> requiredExperience_ = new pbc::RepeatedField<int>();
        private int maxEggPlayerLevel_;
        private int maxEncounterPlayerLevel_;

        public PlayerLevelSettings()
        {
            OnConstruction();
        }

        public PlayerLevelSettings(PlayerLevelSettings other) : this()
        {
            rankNum_ = other.rankNum_.Clone();
            requiredExperience_ = other.requiredExperience_.Clone();
            cpMultiplier_ = other.cpMultiplier_.Clone();
            maxEggPlayerLevel_ = other.maxEggPlayerLevel_;
            maxEncounterPlayerLevel_ = other.maxEncounterPlayerLevel_;
        }

        public static pb::MessageParser<PlayerLevelSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[72]; }
        }

        public pbc::RepeatedField<int> RankNum
        {
            get { return rankNum_; }
        }

        public pbc::RepeatedField<int> RequiredExperience
        {
            get { return requiredExperience_; }
        }

        public pbc::RepeatedField<float> CpMultiplier
        {
            get { return cpMultiplier_; }
        }

        public int MaxEggPlayerLevel
        {
            get { return maxEggPlayerLevel_; }
            set { maxEggPlayerLevel_ = value; }
        }

        public int MaxEncounterPlayerLevel
        {
            get { return maxEncounterPlayerLevel_; }
            set { maxEncounterPlayerLevel_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PlayerLevelSettings Clone()
        {
            return new PlayerLevelSettings(this);
        }

        public bool Equals(PlayerLevelSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!rankNum_.Equals(other.rankNum_)) return false;
            if (!requiredExperience_.Equals(other.requiredExperience_)) return false;
            if (!cpMultiplier_.Equals(other.cpMultiplier_)) return false;
            if (MaxEggPlayerLevel != other.MaxEggPlayerLevel) return false;
            if (MaxEncounterPlayerLevel != other.MaxEncounterPlayerLevel) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            rankNum_.WriteTo(output, _repeated_rankNum_codec);
            requiredExperience_.WriteTo(output, _repeated_requiredExperience_codec);
            cpMultiplier_.WriteTo(output, _repeated_cpMultiplier_codec);
            if (MaxEggPlayerLevel != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(MaxEggPlayerLevel);
            }
            if (MaxEncounterPlayerLevel != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(MaxEncounterPlayerLevel);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            size += rankNum_.CalculateSize(_repeated_rankNum_codec);
            size += requiredExperience_.CalculateSize(_repeated_requiredExperience_codec);
            size += cpMultiplier_.CalculateSize(_repeated_cpMultiplier_codec);
            if (MaxEggPlayerLevel != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxEggPlayerLevel);
            }
            if (MaxEncounterPlayerLevel != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxEncounterPlayerLevel);
            }
            return size;
        }

        public void MergeFrom(PlayerLevelSettings other)
        {
            if (other == null)
            {
                return;
            }
            rankNum_.Add(other.rankNum_);
            requiredExperience_.Add(other.requiredExperience_);
            cpMultiplier_.Add(other.cpMultiplier_);
            if (other.MaxEggPlayerLevel != 0)
            {
                MaxEggPlayerLevel = other.MaxEggPlayerLevel;
            }
            if (other.MaxEncounterPlayerLevel != 0)
            {
                MaxEncounterPlayerLevel = other.MaxEncounterPlayerLevel;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    case 8:
                        {
                            rankNum_.AddEntriesFrom(input, _repeated_rankNum_codec);
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            requiredExperience_.AddEntriesFrom(input, _repeated_requiredExperience_codec);
                            break;
                        }
                    case 26:
                    case 29:
                        {
                            cpMultiplier_.AddEntriesFrom(input, _repeated_cpMultiplier_codec);
                            break;
                        }
                    case 32:
                        {
                            MaxEggPlayerLevel = input.ReadInt32();
                            break;
                        }
                    case 40:
                        {
                            MaxEncounterPlayerLevel = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PlayerLevelSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= rankNum_.GetHashCode();
            hash ^= requiredExperience_.GetHashCode();
            hash ^= cpMultiplier_.GetHashCode();
            if (MaxEggPlayerLevel != 0) hash ^= MaxEggPlayerLevel.GetHashCode();
            if (MaxEncounterPlayerLevel != 0) hash ^= MaxEncounterPlayerLevel.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CameraSettings : pb::IMessage<CameraSettings>
    {
        /// <summary>Field number for the "next_camera" field.</summary>
        public const int NextCameraFieldNumber = 1;

        /// <summary>Field number for the "interpolation" field.</summary>
        public const int InterpolationFieldNumber = 2;

        /// <summary>Field number for the "target_type" field.</summary>
        public const int TargetTypeFieldNumber = 3;

        /// <summary>Field number for the "ease_in_speed" field.</summary>
        public const int EaseInSpeedFieldNumber = 4;

        /// <summary>Field number for the "east_out_speed" field.</summary>
        public const int EastOutSpeedFieldNumber = 5;

        /// <summary>Field number for the "duration_seconds" field.</summary>
        public const int DurationSecondsFieldNumber = 6;

        /// <summary>Field number for the "wait_seconds" field.</summary>
        public const int WaitSecondsFieldNumber = 7;

        /// <summary>Field number for the "transition_seconds" field.</summary>
        public const int TransitionSecondsFieldNumber = 8;

        /// <summary>Field number for the "angle_degree" field.</summary>
        public const int AngleDegreeFieldNumber = 9;

        /// <summary>Field number for the "angle_offset_degree" field.</summary>
        public const int AngleOffsetDegreeFieldNumber = 10;

        /// <summary>Field number for the "pitch_degree" field.</summary>
        public const int PitchDegreeFieldNumber = 11;

        /// <summary>Field number for the "pitch_offset_degree" field.</summary>
        public const int PitchOffsetDegreeFieldNumber = 12;

        /// <summary>Field number for the "roll_degree" field.</summary>
        public const int RollDegreeFieldNumber = 13;

        /// <summary>Field number for the "distance_meters" field.</summary>
        public const int DistanceMetersFieldNumber = 14;

        /// <summary>Field number for the "height_percent" field.</summary>
        public const int HeightPercentFieldNumber = 15;

        /// <summary>Field number for the "vert_ctr_ratio" field.</summary>
        public const int VertCtrRatioFieldNumber = 16;

        private static readonly pb::MessageParser<CameraSettings> _parser =
            new pb::MessageParser<CameraSettings>(() => new CameraSettings());

        private static readonly pb::FieldCodec<global::AllEnum.CameraInterpolation> _repeated_interpolation_codec
            = pb::FieldCodec.ForEnum(18, x => (int)x, x => (global::AllEnum.CameraInterpolation)x);

        private static readonly pb::FieldCodec<global::AllEnum.CameraTarget> _repeated_targetType_codec
            = pb::FieldCodec.ForEnum(26, x => (int)x, x => (global::AllEnum.CameraTarget)x);

        private static readonly pb::FieldCodec<float> _repeated_easeInSpeed_codec
            = pb::FieldCodec.ForFloat(34);

        private static readonly pb::FieldCodec<float> _repeated_eastOutSpeed_codec
            = pb::FieldCodec.ForFloat(42);

        private static readonly pb::FieldCodec<float> _repeated_durationSeconds_codec
            = pb::FieldCodec.ForFloat(50);

        private static readonly pb::FieldCodec<float> _repeated_waitSeconds_codec
            = pb::FieldCodec.ForFloat(58);

        private static readonly pb::FieldCodec<float> _repeated_transitionSeconds_codec
            = pb::FieldCodec.ForFloat(66);

        private static readonly pb::FieldCodec<float> _repeated_angleDegree_codec
            = pb::FieldCodec.ForFloat(74);

        private static readonly pb::FieldCodec<float> _repeated_angleOffsetDegree_codec
            = pb::FieldCodec.ForFloat(82);

        private static readonly pb::FieldCodec<float> _repeated_pitchDegree_codec
            = pb::FieldCodec.ForFloat(90);

        private static readonly pb::FieldCodec<float> _repeated_pitchOffsetDegree_codec
            = pb::FieldCodec.ForFloat(98);

        private static readonly pb::FieldCodec<float> _repeated_rollDegree_codec
            = pb::FieldCodec.ForFloat(106);

        private static readonly pb::FieldCodec<float> _repeated_distanceMeters_codec
            = pb::FieldCodec.ForFloat(114);

        private static readonly pb::FieldCodec<float> _repeated_heightPercent_codec
            = pb::FieldCodec.ForFloat(122);

        private static readonly pb::FieldCodec<float> _repeated_vertCtrRatio_codec
            = pb::FieldCodec.ForFloat(130);

        private readonly pbc::RepeatedField<float> angleDegree_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> angleOffsetDegree_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> distanceMeters_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> durationSeconds_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> easeInSpeed_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> eastOutSpeed_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> heightPercent_ = new pbc::RepeatedField<float>();

        private readonly pbc::RepeatedField<global::AllEnum.CameraInterpolation> interpolation_ =
            new pbc::RepeatedField<global::AllEnum.CameraInterpolation>();

        private readonly pbc::RepeatedField<float> pitchDegree_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> pitchOffsetDegree_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> rollDegree_ = new pbc::RepeatedField<float>();

        private readonly pbc::RepeatedField<global::AllEnum.CameraTarget> targetType_ =
            new pbc::RepeatedField<global::AllEnum.CameraTarget>();

        private readonly pbc::RepeatedField<float> transitionSeconds_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> vertCtrRatio_ = new pbc::RepeatedField<float>();
        private readonly pbc::RepeatedField<float> waitSeconds_ = new pbc::RepeatedField<float>();
        private string nextCamera_ = "";

        public CameraSettings()
        {
            OnConstruction();
        }

        public CameraSettings(CameraSettings other) : this()
        {
            nextCamera_ = other.nextCamera_;
            interpolation_ = other.interpolation_.Clone();
            targetType_ = other.targetType_.Clone();
            easeInSpeed_ = other.easeInSpeed_.Clone();
            eastOutSpeed_ = other.eastOutSpeed_.Clone();
            durationSeconds_ = other.durationSeconds_.Clone();
            waitSeconds_ = other.waitSeconds_.Clone();
            transitionSeconds_ = other.transitionSeconds_.Clone();
            angleDegree_ = other.angleDegree_.Clone();
            angleOffsetDegree_ = other.angleOffsetDegree_.Clone();
            pitchDegree_ = other.pitchDegree_.Clone();
            pitchOffsetDegree_ = other.pitchOffsetDegree_.Clone();
            rollDegree_ = other.rollDegree_.Clone();
            distanceMeters_ = other.distanceMeters_.Clone();
            heightPercent_ = other.heightPercent_.Clone();
            vertCtrRatio_ = other.vertCtrRatio_.Clone();
        }

        public static pb::MessageParser<CameraSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[73]; }
        }

        public string NextCamera
        {
            get { return nextCamera_; }
            set { nextCamera_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public pbc::RepeatedField<global::AllEnum.CameraInterpolation> Interpolation
        {
            get { return interpolation_; }
        }

        public pbc::RepeatedField<global::AllEnum.CameraTarget> TargetType
        {
            get { return targetType_; }
        }

        public pbc::RepeatedField<float> EaseInSpeed
        {
            get { return easeInSpeed_; }
        }

        public pbc::RepeatedField<float> EastOutSpeed
        {
            get { return eastOutSpeed_; }
        }

        public pbc::RepeatedField<float> DurationSeconds
        {
            get { return durationSeconds_; }
        }

        public pbc::RepeatedField<float> WaitSeconds
        {
            get { return waitSeconds_; }
        }

        public pbc::RepeatedField<float> TransitionSeconds
        {
            get { return transitionSeconds_; }
        }

        public pbc::RepeatedField<float> AngleDegree
        {
            get { return angleDegree_; }
        }

        public pbc::RepeatedField<float> AngleOffsetDegree
        {
            get { return angleOffsetDegree_; }
        }

        public pbc::RepeatedField<float> PitchDegree
        {
            get { return pitchDegree_; }
        }

        public pbc::RepeatedField<float> PitchOffsetDegree
        {
            get { return pitchOffsetDegree_; }
        }

        public pbc::RepeatedField<float> RollDegree
        {
            get { return rollDegree_; }
        }

        public pbc::RepeatedField<float> DistanceMeters
        {
            get { return distanceMeters_; }
        }

        public pbc::RepeatedField<float> HeightPercent
        {
            get { return heightPercent_; }
        }

        public pbc::RepeatedField<float> VertCtrRatio
        {
            get { return vertCtrRatio_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CameraSettings Clone()
        {
            return new CameraSettings(this);
        }

        public bool Equals(CameraSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (NextCamera != other.NextCamera) return false;
            if (!interpolation_.Equals(other.interpolation_)) return false;
            if (!targetType_.Equals(other.targetType_)) return false;
            if (!easeInSpeed_.Equals(other.easeInSpeed_)) return false;
            if (!eastOutSpeed_.Equals(other.eastOutSpeed_)) return false;
            if (!durationSeconds_.Equals(other.durationSeconds_)) return false;
            if (!waitSeconds_.Equals(other.waitSeconds_)) return false;
            if (!transitionSeconds_.Equals(other.transitionSeconds_)) return false;
            if (!angleDegree_.Equals(other.angleDegree_)) return false;
            if (!angleOffsetDegree_.Equals(other.angleOffsetDegree_)) return false;
            if (!pitchDegree_.Equals(other.pitchDegree_)) return false;
            if (!pitchOffsetDegree_.Equals(other.pitchOffsetDegree_)) return false;
            if (!rollDegree_.Equals(other.rollDegree_)) return false;
            if (!distanceMeters_.Equals(other.distanceMeters_)) return false;
            if (!heightPercent_.Equals(other.heightPercent_)) return false;
            if (!vertCtrRatio_.Equals(other.vertCtrRatio_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (NextCamera.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(NextCamera);
            }
            interpolation_.WriteTo(output, _repeated_interpolation_codec);
            targetType_.WriteTo(output, _repeated_targetType_codec);
            easeInSpeed_.WriteTo(output, _repeated_easeInSpeed_codec);
            eastOutSpeed_.WriteTo(output, _repeated_eastOutSpeed_codec);
            durationSeconds_.WriteTo(output, _repeated_durationSeconds_codec);
            waitSeconds_.WriteTo(output, _repeated_waitSeconds_codec);
            transitionSeconds_.WriteTo(output, _repeated_transitionSeconds_codec);
            angleDegree_.WriteTo(output, _repeated_angleDegree_codec);
            angleOffsetDegree_.WriteTo(output, _repeated_angleOffsetDegree_codec);
            pitchDegree_.WriteTo(output, _repeated_pitchDegree_codec);
            pitchOffsetDegree_.WriteTo(output, _repeated_pitchOffsetDegree_codec);
            rollDegree_.WriteTo(output, _repeated_rollDegree_codec);
            distanceMeters_.WriteTo(output, _repeated_distanceMeters_codec);
            heightPercent_.WriteTo(output, _repeated_heightPercent_codec);
            vertCtrRatio_.WriteTo(output, _repeated_vertCtrRatio_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (NextCamera.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(NextCamera);
            }
            size += interpolation_.CalculateSize(_repeated_interpolation_codec);
            size += targetType_.CalculateSize(_repeated_targetType_codec);
            size += easeInSpeed_.CalculateSize(_repeated_easeInSpeed_codec);
            size += eastOutSpeed_.CalculateSize(_repeated_eastOutSpeed_codec);
            size += durationSeconds_.CalculateSize(_repeated_durationSeconds_codec);
            size += waitSeconds_.CalculateSize(_repeated_waitSeconds_codec);
            size += transitionSeconds_.CalculateSize(_repeated_transitionSeconds_codec);
            size += angleDegree_.CalculateSize(_repeated_angleDegree_codec);
            size += angleOffsetDegree_.CalculateSize(_repeated_angleOffsetDegree_codec);
            size += pitchDegree_.CalculateSize(_repeated_pitchDegree_codec);
            size += pitchOffsetDegree_.CalculateSize(_repeated_pitchOffsetDegree_codec);
            size += rollDegree_.CalculateSize(_repeated_rollDegree_codec);
            size += distanceMeters_.CalculateSize(_repeated_distanceMeters_codec);
            size += heightPercent_.CalculateSize(_repeated_heightPercent_codec);
            size += vertCtrRatio_.CalculateSize(_repeated_vertCtrRatio_codec);
            return size;
        }

        public void MergeFrom(CameraSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.NextCamera.Length != 0)
            {
                NextCamera = other.NextCamera;
            }
            interpolation_.Add(other.interpolation_);
            targetType_.Add(other.targetType_);
            easeInSpeed_.Add(other.easeInSpeed_);
            eastOutSpeed_.Add(other.eastOutSpeed_);
            durationSeconds_.Add(other.durationSeconds_);
            waitSeconds_.Add(other.waitSeconds_);
            transitionSeconds_.Add(other.transitionSeconds_);
            angleDegree_.Add(other.angleDegree_);
            angleOffsetDegree_.Add(other.angleOffsetDegree_);
            pitchDegree_.Add(other.pitchDegree_);
            pitchOffsetDegree_.Add(other.pitchOffsetDegree_);
            rollDegree_.Add(other.rollDegree_);
            distanceMeters_.Add(other.distanceMeters_);
            heightPercent_.Add(other.heightPercent_);
            vertCtrRatio_.Add(other.vertCtrRatio_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            NextCamera = input.ReadString();
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            interpolation_.AddEntriesFrom(input, _repeated_interpolation_codec);
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            targetType_.AddEntriesFrom(input, _repeated_targetType_codec);
                            break;
                        }
                    case 34:
                    case 37:
                        {
                            easeInSpeed_.AddEntriesFrom(input, _repeated_easeInSpeed_codec);
                            break;
                        }
                    case 42:
                    case 45:
                        {
                            eastOutSpeed_.AddEntriesFrom(input, _repeated_eastOutSpeed_codec);
                            break;
                        }
                    case 50:
                    case 53:
                        {
                            durationSeconds_.AddEntriesFrom(input, _repeated_durationSeconds_codec);
                            break;
                        }
                    case 58:
                    case 61:
                        {
                            waitSeconds_.AddEntriesFrom(input, _repeated_waitSeconds_codec);
                            break;
                        }
                    case 66:
                    case 69:
                        {
                            transitionSeconds_.AddEntriesFrom(input, _repeated_transitionSeconds_codec);
                            break;
                        }
                    case 74:
                    case 77:
                        {
                            angleDegree_.AddEntriesFrom(input, _repeated_angleDegree_codec);
                            break;
                        }
                    case 82:
                    case 85:
                        {
                            angleOffsetDegree_.AddEntriesFrom(input, _repeated_angleOffsetDegree_codec);
                            break;
                        }
                    case 90:
                    case 93:
                        {
                            pitchDegree_.AddEntriesFrom(input, _repeated_pitchDegree_codec);
                            break;
                        }
                    case 98:
                    case 101:
                        {
                            pitchOffsetDegree_.AddEntriesFrom(input, _repeated_pitchOffsetDegree_codec);
                            break;
                        }
                    case 106:
                    case 109:
                        {
                            rollDegree_.AddEntriesFrom(input, _repeated_rollDegree_codec);
                            break;
                        }
                    case 114:
                    case 117:
                        {
                            distanceMeters_.AddEntriesFrom(input, _repeated_distanceMeters_codec);
                            break;
                        }
                    case 122:
                    case 125:
                        {
                            heightPercent_.AddEntriesFrom(input, _repeated_heightPercent_codec);
                            break;
                        }
                    case 130:
                    case 133:
                        {
                            vertCtrRatio_.AddEntriesFrom(input, _repeated_vertCtrRatio_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CameraSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (NextCamera.Length != 0) hash ^= NextCamera.GetHashCode();
            hash ^= interpolation_.GetHashCode();
            hash ^= targetType_.GetHashCode();
            hash ^= easeInSpeed_.GetHashCode();
            hash ^= eastOutSpeed_.GetHashCode();
            hash ^= durationSeconds_.GetHashCode();
            hash ^= waitSeconds_.GetHashCode();
            hash ^= transitionSeconds_.GetHashCode();
            hash ^= angleDegree_.GetHashCode();
            hash ^= angleOffsetDegree_.GetHashCode();
            hash ^= pitchDegree_.GetHashCode();
            hash ^= pitchOffsetDegree_.GetHashCode();
            hash ^= rollDegree_.GetHashCode();
            hash ^= distanceMeters_.GetHashCode();
            hash ^= heightPercent_.GetHashCode();
            hash ^= vertCtrRatio_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class BadgeSettings : pb::IMessage<BadgeSettings>
    {
        /// <summary>Field number for the "badge_type" field.</summary>
        public const int BadgeTypeFieldNumber = 1;

        /// <summary>Field number for the "badge_rank" field.</summary>
        public const int BadgeRankFieldNumber = 2;

        /// <summary>Field number for the "targets" field.</summary>
        public const int TargetsFieldNumber = 3;

        private static readonly pb::MessageParser<BadgeSettings> _parser =
            new pb::MessageParser<BadgeSettings>(() => new BadgeSettings());

        private static readonly pb::FieldCodec<int> _repeated_targets_codec
            = pb::FieldCodec.ForInt32(26);

        private readonly pbc::RepeatedField<int> targets_ = new pbc::RepeatedField<int>();
        private int badgeRank_;
        private global::AllEnum.BadgeType badgeType_ = 0;

        public BadgeSettings()
        {
            OnConstruction();
        }

        public BadgeSettings(BadgeSettings other) : this()
        {
            badgeType_ = other.badgeType_;
            badgeRank_ = other.badgeRank_;
            targets_ = other.targets_.Clone();
        }

        public static pb::MessageParser<BadgeSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[74]; }
        }

        public global::AllEnum.BadgeType BadgeType
        {
            get { return badgeType_; }
            set { badgeType_ = value; }
        }

        public int BadgeRank
        {
            get { return badgeRank_; }
            set { badgeRank_ = value; }
        }

        public pbc::RepeatedField<int> Targets
        {
            get { return targets_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BadgeSettings Clone()
        {
            return new BadgeSettings(this);
        }

        public bool Equals(BadgeSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (BadgeType != other.BadgeType) return false;
            if (BadgeRank != other.BadgeRank) return false;
            if (!targets_.Equals(other.targets_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (BadgeType != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)BadgeType);
            }
            if (BadgeRank != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(BadgeRank);
            }
            targets_.WriteTo(output, _repeated_targets_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            if (BadgeType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)BadgeType);
            }
            if (BadgeRank != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeRank);
            }
            size += targets_.CalculateSize(_repeated_targets_codec);
            return size;
        }

        public void MergeFrom(BadgeSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.BadgeType != 0)
            {
                BadgeType = other.BadgeType;
            }
            if (other.BadgeRank != 0)
            {
                BadgeRank = other.BadgeRank;
            }
            targets_.Add(other.targets_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            badgeType_ = (global::AllEnum.BadgeType)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            BadgeRank = input.ReadInt32();
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            targets_.AddEntriesFrom(input, _repeated_targets_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as BadgeSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (BadgeType != 0) hash ^= BadgeType.GetHashCode();
            if (BadgeRank != 0) hash ^= BadgeRank.GetHashCode();
            hash ^= targets_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class TypeEffectiveSettings : pb::IMessage<TypeEffectiveSettings>
    {
        /// <summary>Field number for the "attack_scalar" field.</summary>
        public const int AttackScalarFieldNumber = 1;

        /// <summary>Field number for the "attack_type" field.</summary>
        public const int AttackTypeFieldNumber = 2;

        private static readonly pb::MessageParser<TypeEffectiveSettings> _parser =
            new pb::MessageParser<TypeEffectiveSettings>(() => new TypeEffectiveSettings());

        private static readonly pb::FieldCodec<float> _repeated_attackScalar_codec
            = pb::FieldCodec.ForFloat(10);

        private readonly pbc::RepeatedField<float> attackScalar_ = new pbc::RepeatedField<float>();
        private global::AllEnum.PokemonType attackType_ = 0;

        public TypeEffectiveSettings()
        {
            OnConstruction();
        }

        public TypeEffectiveSettings(TypeEffectiveSettings other) : this()
        {
            attackScalar_ = other.attackScalar_.Clone();
            attackType_ = other.attackType_;
        }

        public static pb::MessageParser<TypeEffectiveSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[75]; }
        }

        public pbc::RepeatedField<float> AttackScalar
        {
            get { return attackScalar_; }
        }

        public global::AllEnum.PokemonType AttackType
        {
            get { return attackType_; }
            set { attackType_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TypeEffectiveSettings Clone()
        {
            return new TypeEffectiveSettings(this);
        }

        public bool Equals(TypeEffectiveSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!attackScalar_.Equals(other.attackScalar_)) return false;
            if (AttackType != other.AttackType) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            attackScalar_.WriteTo(output, _repeated_attackScalar_codec);
            if (AttackType != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)AttackType);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            size += attackScalar_.CalculateSize(_repeated_attackScalar_codec);
            if (AttackType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)AttackType);
            }
            return size;
        }

        public void MergeFrom(TypeEffectiveSettings other)
        {
            if (other == null)
            {
                return;
            }
            attackScalar_.Add(other.attackScalar_);
            if (other.AttackType != 0)
            {
                AttackType = other.AttackType;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    case 13:
                        {
                            attackScalar_.AddEntriesFrom(input, _repeated_attackScalar_codec);
                            break;
                        }
                    case 16:
                        {
                            attackType_ = (global::AllEnum.PokemonType)input.ReadEnum();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as TypeEffectiveSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= attackScalar_.GetHashCode();
            if (AttackType != 0) hash ^= AttackType.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class MoveSequenceSettings : pb::IMessage<MoveSequenceSettings>
    {
        /// <summary>Field number for the "sequence" field.</summary>
        public const int SequenceFieldNumber = 1;

        private static readonly pb::MessageParser<MoveSequenceSettings> _parser =
            new pb::MessageParser<MoveSequenceSettings>(() => new MoveSequenceSettings());

        private static readonly pb::FieldCodec<string> _repeated_sequence_codec
            = pb::FieldCodec.ForString(10);

        private readonly pbc::RepeatedField<string> sequence_ = new pbc::RepeatedField<string>();

        public MoveSequenceSettings()
        {
            OnConstruction();
        }

        public MoveSequenceSettings(MoveSequenceSettings other) : this()
        {
            sequence_ = other.sequence_.Clone();
        }

        public static pb::MessageParser<MoveSequenceSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[76]; }
        }

        public pbc::RepeatedField<string> Sequence
        {
            get { return sequence_; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MoveSequenceSettings Clone()
        {
            return new MoveSequenceSettings(this);
        }

        public bool Equals(MoveSequenceSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!sequence_.Equals(other.sequence_)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            sequence_.WriteTo(output, _repeated_sequence_codec);
        }

        public int CalculateSize()
        {
            var size = 0;
            size += sequence_.CalculateSize(_repeated_sequence_codec);
            return size;
        }

        public void MergeFrom(MoveSequenceSettings other)
        {
            if (other == null)
            {
                return;
            }
            sequence_.Add(other.sequence_);
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            sequence_.AddEntriesFrom(input, _repeated_sequence_codec);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as MoveSequenceSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= sequence_.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class MoveSettings : pb::IMessage<MoveSettings>
    {
        /// <summary>Field number for the "movement_id" field.</summary>
        public const int MovementIdFieldNumber = 1;

        /// <summary>Field number for the "animation_id" field.</summary>
        public const int AnimationIdFieldNumber = 2;

        /// <summary>Field number for the "pokemon_type" field.</summary>
        public const int PokemonTypeFieldNumber = 3;

        /// <summary>Field number for the "power" field.</summary>
        public const int PowerFieldNumber = 4;

        /// <summary>Field number for the "accuracy_chance" field.</summary>
        public const int AccuracyChanceFieldNumber = 5;

        /// <summary>Field number for the "critical_chance" field.</summary>
        public const int CriticalChanceFieldNumber = 6;

        /// <summary>Field number for the "heal_scalar" field.</summary>
        public const int HealScalarFieldNumber = 7;

        /// <summary>Field number for the "stamina_loss_scalar" field.</summary>
        public const int StaminaLossScalarFieldNumber = 8;

        /// <summary>Field number for the "trainer_level_min" field.</summary>
        public const int TrainerLevelMinFieldNumber = 9;

        /// <summary>Field number for the "trainer_level_max" field.</summary>
        public const int TrainerLevelMaxFieldNumber = 10;

        /// <summary>Field number for the "vfx_name" field.</summary>
        public const int VfxNameFieldNumber = 11;

        /// <summary>Field number for the "duration_ms" field.</summary>
        public const int DurationMsFieldNumber = 12;

        /// <summary>Field number for the "damage_window_start_ms" field.</summary>
        public const int DamageWindowStartMsFieldNumber = 13;

        /// <summary>Field number for the "damage_window_end_ms" field.</summary>
        public const int DamageWindowEndMsFieldNumber = 14;

        /// <summary>Field number for the "energy_delta" field.</summary>
        public const int EnergyDeltaFieldNumber = 15;

        private static readonly pb::MessageParser<MoveSettings> _parser =
            new pb::MessageParser<MoveSettings>(() => new MoveSettings());

        private float accuracyChance_;
        private int animationId_;
        private float criticalChance_;
        private int damageWindowEndMs_;
        private int damageWindowStartMs_;
        private int durationMs_;
        private int energyDelta_;
        private float healScalar_;
        private global::AllEnum.PokemonMovementType movementId_ = 0;
        private global::AllEnum.PokemonType pokemonType_ = 0;
        private float power_;
        private float staminaLossScalar_;
        private int trainerLevelMax_;
        private int trainerLevelMin_;
        private string vfxName_ = "";

        public MoveSettings()
        {
            OnConstruction();
        }

        public MoveSettings(MoveSettings other) : this()
        {
            movementId_ = other.movementId_;
            animationId_ = other.animationId_;
            pokemonType_ = other.pokemonType_;
            power_ = other.power_;
            accuracyChance_ = other.accuracyChance_;
            criticalChance_ = other.criticalChance_;
            healScalar_ = other.healScalar_;
            staminaLossScalar_ = other.staminaLossScalar_;
            trainerLevelMin_ = other.trainerLevelMin_;
            trainerLevelMax_ = other.trainerLevelMax_;
            vfxName_ = other.vfxName_;
            durationMs_ = other.durationMs_;
            damageWindowStartMs_ = other.damageWindowStartMs_;
            damageWindowEndMs_ = other.damageWindowEndMs_;
            energyDelta_ = other.energyDelta_;
        }

        public static pb::MessageParser<MoveSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[77]; }
        }

        public global::AllEnum.PokemonMovementType MovementId
        {
            get { return movementId_; }
            set { movementId_ = value; }
        }

        public int AnimationId
        {
            get { return animationId_; }
            set { animationId_ = value; }
        }

        public global::AllEnum.PokemonType PokemonType
        {
            get { return pokemonType_; }
            set { pokemonType_ = value; }
        }

        public float Power
        {
            get { return power_; }
            set { power_ = value; }
        }

        public float AccuracyChance
        {
            get { return accuracyChance_; }
            set { accuracyChance_ = value; }
        }

        public float CriticalChance
        {
            get { return criticalChance_; }
            set { criticalChance_ = value; }
        }

        public float HealScalar
        {
            get { return healScalar_; }
            set { healScalar_ = value; }
        }

        public float StaminaLossScalar
        {
            get { return staminaLossScalar_; }
            set { staminaLossScalar_ = value; }
        }

        public int TrainerLevelMin
        {
            get { return trainerLevelMin_; }
            set { trainerLevelMin_ = value; }
        }

        public int TrainerLevelMax
        {
            get { return trainerLevelMax_; }
            set { trainerLevelMax_ = value; }
        }

        public string VfxName
        {
            get { return vfxName_; }
            set { vfxName_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        public int DurationMs
        {
            get { return durationMs_; }
            set { durationMs_ = value; }
        }

        public int DamageWindowStartMs
        {
            get { return damageWindowStartMs_; }
            set { damageWindowStartMs_ = value; }
        }

        public int DamageWindowEndMs
        {
            get { return damageWindowEndMs_; }
            set { damageWindowEndMs_ = value; }
        }

        public int EnergyDelta
        {
            get { return energyDelta_; }
            set { energyDelta_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MoveSettings Clone()
        {
            return new MoveSettings(this);
        }

        public bool Equals(MoveSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (MovementId != other.MovementId) return false;
            if (AnimationId != other.AnimationId) return false;
            if (PokemonType != other.PokemonType) return false;
            if (Power != other.Power) return false;
            if (AccuracyChance != other.AccuracyChance) return false;
            if (CriticalChance != other.CriticalChance) return false;
            if (HealScalar != other.HealScalar) return false;
            if (StaminaLossScalar != other.StaminaLossScalar) return false;
            if (TrainerLevelMin != other.TrainerLevelMin) return false;
            if (TrainerLevelMax != other.TrainerLevelMax) return false;
            if (VfxName != other.VfxName) return false;
            if (DurationMs != other.DurationMs) return false;
            if (DamageWindowStartMs != other.DamageWindowStartMs) return false;
            if (DamageWindowEndMs != other.DamageWindowEndMs) return false;
            if (EnergyDelta != other.EnergyDelta) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (MovementId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)MovementId);
            }
            if (AnimationId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(AnimationId);
            }
            if (PokemonType != 0)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)PokemonType);
            }
            if (Power != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(Power);
            }
            if (AccuracyChance != 0F)
            {
                output.WriteRawTag(45);
                output.WriteFloat(AccuracyChance);
            }
            if (CriticalChance != 0F)
            {
                output.WriteRawTag(53);
                output.WriteFloat(CriticalChance);
            }
            if (HealScalar != 0F)
            {
                output.WriteRawTag(61);
                output.WriteFloat(HealScalar);
            }
            if (StaminaLossScalar != 0F)
            {
                output.WriteRawTag(69);
                output.WriteFloat(StaminaLossScalar);
            }
            if (TrainerLevelMin != 0)
            {
                output.WriteRawTag(72);
                output.WriteInt32(TrainerLevelMin);
            }
            if (TrainerLevelMax != 0)
            {
                output.WriteRawTag(80);
                output.WriteInt32(TrainerLevelMax);
            }
            if (VfxName.Length != 0)
            {
                output.WriteRawTag(90);
                output.WriteString(VfxName);
            }
            if (DurationMs != 0)
            {
                output.WriteRawTag(96);
                output.WriteInt32(DurationMs);
            }
            if (DamageWindowStartMs != 0)
            {
                output.WriteRawTag(104);
                output.WriteInt32(DamageWindowStartMs);
            }
            if (DamageWindowEndMs != 0)
            {
                output.WriteRawTag(112);
                output.WriteInt32(DamageWindowEndMs);
            }
            if (EnergyDelta != 0)
            {
                output.WriteRawTag(120);
                output.WriteInt32(EnergyDelta);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (MovementId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)MovementId);
            }
            if (AnimationId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(AnimationId);
            }
            if (PokemonType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonType);
            }
            if (Power != 0F)
            {
                size += 1 + 4;
            }
            if (AccuracyChance != 0F)
            {
                size += 1 + 4;
            }
            if (CriticalChance != 0F)
            {
                size += 1 + 4;
            }
            if (HealScalar != 0F)
            {
                size += 1 + 4;
            }
            if (StaminaLossScalar != 0F)
            {
                size += 1 + 4;
            }
            if (TrainerLevelMin != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(TrainerLevelMin);
            }
            if (TrainerLevelMax != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(TrainerLevelMax);
            }
            if (VfxName.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(VfxName);
            }
            if (DurationMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DurationMs);
            }
            if (DamageWindowStartMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DamageWindowStartMs);
            }
            if (DamageWindowEndMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DamageWindowEndMs);
            }
            if (EnergyDelta != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EnergyDelta);
            }
            return size;
        }

        public void MergeFrom(MoveSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.MovementId != 0)
            {
                MovementId = other.MovementId;
            }
            if (other.AnimationId != 0)
            {
                AnimationId = other.AnimationId;
            }
            if (other.PokemonType != 0)
            {
                PokemonType = other.PokemonType;
            }
            if (other.Power != 0F)
            {
                Power = other.Power;
            }
            if (other.AccuracyChance != 0F)
            {
                AccuracyChance = other.AccuracyChance;
            }
            if (other.CriticalChance != 0F)
            {
                CriticalChance = other.CriticalChance;
            }
            if (other.HealScalar != 0F)
            {
                HealScalar = other.HealScalar;
            }
            if (other.StaminaLossScalar != 0F)
            {
                StaminaLossScalar = other.StaminaLossScalar;
            }
            if (other.TrainerLevelMin != 0)
            {
                TrainerLevelMin = other.TrainerLevelMin;
            }
            if (other.TrainerLevelMax != 0)
            {
                TrainerLevelMax = other.TrainerLevelMax;
            }
            if (other.VfxName.Length != 0)
            {
                VfxName = other.VfxName;
            }
            if (other.DurationMs != 0)
            {
                DurationMs = other.DurationMs;
            }
            if (other.DamageWindowStartMs != 0)
            {
                DamageWindowStartMs = other.DamageWindowStartMs;
            }
            if (other.DamageWindowEndMs != 0)
            {
                DamageWindowEndMs = other.DamageWindowEndMs;
            }
            if (other.EnergyDelta != 0)
            {
                EnergyDelta = other.EnergyDelta;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            movementId_ = (global::AllEnum.PokemonMovementType)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            AnimationId = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            pokemonType_ = (global::AllEnum.PokemonType)input.ReadEnum();
                            break;
                        }
                    case 37:
                        {
                            Power = input.ReadFloat();
                            break;
                        }
                    case 45:
                        {
                            AccuracyChance = input.ReadFloat();
                            break;
                        }
                    case 53:
                        {
                            CriticalChance = input.ReadFloat();
                            break;
                        }
                    case 61:
                        {
                            HealScalar = input.ReadFloat();
                            break;
                        }
                    case 69:
                        {
                            StaminaLossScalar = input.ReadFloat();
                            break;
                        }
                    case 72:
                        {
                            TrainerLevelMin = input.ReadInt32();
                            break;
                        }
                    case 80:
                        {
                            TrainerLevelMax = input.ReadInt32();
                            break;
                        }
                    case 90:
                        {
                            VfxName = input.ReadString();
                            break;
                        }
                    case 96:
                        {
                            DurationMs = input.ReadInt32();
                            break;
                        }
                    case 104:
                        {
                            DamageWindowStartMs = input.ReadInt32();
                            break;
                        }
                    case 112:
                        {
                            DamageWindowEndMs = input.ReadInt32();
                            break;
                        }
                    case 120:
                        {
                            EnergyDelta = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as MoveSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (MovementId != 0) hash ^= MovementId.GetHashCode();
            if (AnimationId != 0) hash ^= AnimationId.GetHashCode();
            if (PokemonType != 0) hash ^= PokemonType.GetHashCode();
            if (Power != 0F) hash ^= Power.GetHashCode();
            if (AccuracyChance != 0F) hash ^= AccuracyChance.GetHashCode();
            if (CriticalChance != 0F) hash ^= CriticalChance.GetHashCode();
            if (HealScalar != 0F) hash ^= HealScalar.GetHashCode();
            if (StaminaLossScalar != 0F) hash ^= StaminaLossScalar.GetHashCode();
            if (TrainerLevelMin != 0) hash ^= TrainerLevelMin.GetHashCode();
            if (TrainerLevelMax != 0) hash ^= TrainerLevelMax.GetHashCode();
            if (VfxName.Length != 0) hash ^= VfxName.GetHashCode();
            if (DurationMs != 0) hash ^= DurationMs.GetHashCode();
            if (DamageWindowStartMs != 0) hash ^= DamageWindowStartMs.GetHashCode();
            if (DamageWindowEndMs != 0) hash ^= DamageWindowEndMs.GetHashCode();
            if (EnergyDelta != 0) hash ^= EnergyDelta.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PokemonSettings : pb::IMessage<PokemonSettings>
    {
        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 1;

        /// <summary>Field number for the "model_scale" field.</summary>
        public const int ModelScaleFieldNumber = 3;

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 4;

        /// <summary>Field number for the "type_2" field.</summary>
        public const int Type2FieldNumber = 5;

        /// <summary>Field number for the "camera" field.</summary>
        public const int CameraFieldNumber = 6;

        /// <summary>Field number for the "encounter" field.</summary>
        public const int EncounterFieldNumber = 7;

        /// <summary>Field number for the "stats" field.</summary>
        public const int StatsFieldNumber = 8;

        /// <summary>Field number for the "quick_moves" field.</summary>
        public const int QuickMovesFieldNumber = 9;

        /// <summary>Field number for the "cinematic_moves" field.</summary>
        public const int CinematicMovesFieldNumber = 10;

        /// <summary>Field number for the "animation_time" field.</summary>
        public const int AnimationTimeFieldNumber = 11;

        /// <summary>Field number for the "evolution_ids" field.</summary>
        public const int EvolutionIdsFieldNumber = 12;

        /// <summary>Field number for the "evolution_pips" field.</summary>
        public const int EvolutionPipsFieldNumber = 13;

        /// <summary>Field number for the "class" field.</summary>
        public const int ClassFieldNumber = 14;

        /// <summary>Field number for the "pokedex_height_m" field.</summary>
        public const int PokedexHeightMFieldNumber = 15;

        /// <summary>Field number for the "pokedex_weight_kg" field.</summary>
        public const int PokedexWeightKgFieldNumber = 16;

        /// <summary>Field number for the "parent_pokemon_id" field.</summary>
        public const int ParentPokemonIdFieldNumber = 17;

        /// <summary>Field number for the "height_std_dev" field.</summary>
        public const int HeightStdDevFieldNumber = 18;

        /// <summary>Field number for the "weight_std_dev" field.</summary>
        public const int WeightStdDevFieldNumber = 19;

        /// <summary>Field number for the "km_distance_to_hatch" field.</summary>
        public const int KmDistanceToHatchFieldNumber = 20;

        /// <summary>Field number for the "family_id" field.</summary>
        public const int FamilyIdFieldNumber = 21;

        /// <summary>Field number for the "candy_to_evolve" field.</summary>
        public const int CandyToEvolveFieldNumber = 22;

        private static readonly pb::MessageParser<PokemonSettings> _parser =
            new pb::MessageParser<PokemonSettings>(() => new PokemonSettings());

        private static readonly pb::FieldCodec<global::AllEnum.PokemonMove> _repeated_quickMoves_codec
            = pb::FieldCodec.ForEnum(74, x => (int)x, x => (global::AllEnum.PokemonMove)x);

        private static readonly pb::FieldCodec<global::AllEnum.PokemonMove> _repeated_cinematicMoves_codec
            = pb::FieldCodec.ForEnum(82, x => (int)x, x => (global::AllEnum.PokemonMove)x);

        private static readonly pb::FieldCodec<float> _repeated_animationTime_codec
            = pb::FieldCodec.ForFloat(90);

        private static readonly pb::FieldCodec<global::AllEnum.PokemonId> _repeated_evolutionIds_codec
            = pb::FieldCodec.ForEnum(98, x => (int)x, x => (global::AllEnum.PokemonId)x);

        private readonly pbc::RepeatedField<float> animationTime_ = new pbc::RepeatedField<float>();

        private readonly pbc::RepeatedField<global::AllEnum.PokemonMove> cinematicMoves_ =
            new pbc::RepeatedField<global::AllEnum.PokemonMove>();

        private readonly pbc::RepeatedField<global::AllEnum.PokemonId> evolutionIds_ =
            new pbc::RepeatedField<global::AllEnum.PokemonId>();

        private readonly pbc::RepeatedField<global::AllEnum.PokemonMove> quickMoves_ =
            new pbc::RepeatedField<global::AllEnum.PokemonMove>();

        private global::PokeGodar.WebAPI.GeneratedCode.CameraAttributes camera_;
        private int candyToEvolve_;
        private global::AllEnum.PokemonClass class_ = 0;
        private global::PokeGodar.WebAPI.GeneratedCode.EncounterAttributes encounter_;
        private int evolutionPips_;
        private global::AllEnum.PokemonFamilyId familyId_ = 0;
        private float heightStdDev_;
        private float kmDistanceToHatch_;
        private float modelScale_;
        private global::AllEnum.PokemonId parentPokemonId_ = 0;
        private float pokedexHeightM_;
        private float pokedexWeightKg_;
        private global::AllEnum.PokemonId pokemonId_ = 0;
        private global::PokeGodar.WebAPI.GeneratedCode.StatsAttributes stats_;
        private global::AllEnum.PokemonType type_ = 0;
        private global::AllEnum.PokemonType type2_ = 0;
        private float weightStdDev_;

        public PokemonSettings()
        {
            OnConstruction();
        }

        public PokemonSettings(PokemonSettings other) : this()
        {
            pokemonId_ = other.pokemonId_;
            modelScale_ = other.modelScale_;
            type_ = other.type_;
            type2_ = other.type2_;
            Camera = other.camera_ != null ? other.Camera.Clone() : null;
            Encounter = other.encounter_ != null ? other.Encounter.Clone() : null;
            Stats = other.stats_ != null ? other.Stats.Clone() : null;
            quickMoves_ = other.quickMoves_.Clone();
            cinematicMoves_ = other.cinematicMoves_.Clone();
            animationTime_ = other.animationTime_.Clone();
            evolutionIds_ = other.evolutionIds_.Clone();
            evolutionPips_ = other.evolutionPips_;
            class_ = other.class_;
            pokedexHeightM_ = other.pokedexHeightM_;
            pokedexWeightKg_ = other.pokedexWeightKg_;
            parentPokemonId_ = other.parentPokemonId_;
            heightStdDev_ = other.heightStdDev_;
            weightStdDev_ = other.weightStdDev_;
            kmDistanceToHatch_ = other.kmDistanceToHatch_;
            familyId_ = other.familyId_;
            candyToEvolve_ = other.candyToEvolve_;
        }

        public static pb::MessageParser<PokemonSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[78]; }
        }

        public global::AllEnum.PokemonId PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        public float ModelScale
        {
            get { return modelScale_; }
            set { modelScale_ = value; }
        }

        public global::AllEnum.PokemonType Type
        {
            get { return type_; }
            set { type_ = value; }
        }

        public global::AllEnum.PokemonType Type2
        {
            get { return type2_; }
            set { type2_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.CameraAttributes Camera
        {
            get { return camera_; }
            set { camera_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.EncounterAttributes Encounter
        {
            get { return encounter_; }
            set { encounter_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.StatsAttributes Stats
        {
            get { return stats_; }
            set { stats_ = value; }
        }

        public pbc::RepeatedField<global::AllEnum.PokemonMove> QuickMoves
        {
            get { return quickMoves_; }
        }

        public pbc::RepeatedField<global::AllEnum.PokemonMove> CinematicMoves
        {
            get { return cinematicMoves_; }
        }

        public pbc::RepeatedField<float> AnimationTime
        {
            get { return animationTime_; }
        }

        public pbc::RepeatedField<global::AllEnum.PokemonId> EvolutionIds
        {
            get { return evolutionIds_; }
        }

        public int EvolutionPips
        {
            get { return evolutionPips_; }
            set { evolutionPips_ = value; }
        }

        public global::AllEnum.PokemonClass Class
        {
            get { return class_; }
            set { class_ = value; }
        }

        public float PokedexHeightM
        {
            get { return pokedexHeightM_; }
            set { pokedexHeightM_ = value; }
        }

        public float PokedexWeightKg
        {
            get { return pokedexWeightKg_; }
            set { pokedexWeightKg_ = value; }
        }

        public global::AllEnum.PokemonId ParentPokemonId
        {
            get { return parentPokemonId_; }
            set { parentPokemonId_ = value; }
        }

        public float HeightStdDev
        {
            get { return heightStdDev_; }
            set { heightStdDev_ = value; }
        }

        public float WeightStdDev
        {
            get { return weightStdDev_; }
            set { weightStdDev_ = value; }
        }

        public float KmDistanceToHatch
        {
            get { return kmDistanceToHatch_; }
            set { kmDistanceToHatch_ = value; }
        }

        public global::AllEnum.PokemonFamilyId FamilyId
        {
            get { return familyId_; }
            set { familyId_ = value; }
        }

        public int CandyToEvolve
        {
            get { return candyToEvolve_; }
            set { candyToEvolve_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PokemonSettings Clone()
        {
            return new PokemonSettings(this);
        }

        public bool Equals(PokemonSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PokemonId != other.PokemonId) return false;
            if (ModelScale != other.ModelScale) return false;
            if (Type != other.Type) return false;
            if (Type2 != other.Type2) return false;
            if (!Equals(Camera, other.Camera)) return false;
            if (!Equals(Encounter, other.Encounter)) return false;
            if (!Equals(Stats, other.Stats)) return false;
            if (!quickMoves_.Equals(other.quickMoves_)) return false;
            if (!cinematicMoves_.Equals(other.cinematicMoves_)) return false;
            if (!animationTime_.Equals(other.animationTime_)) return false;
            if (!evolutionIds_.Equals(other.evolutionIds_)) return false;
            if (EvolutionPips != other.EvolutionPips) return false;
            if (Class != other.Class) return false;
            if (PokedexHeightM != other.PokedexHeightM) return false;
            if (PokedexWeightKg != other.PokedexWeightKg) return false;
            if (ParentPokemonId != other.ParentPokemonId) return false;
            if (HeightStdDev != other.HeightStdDev) return false;
            if (WeightStdDev != other.WeightStdDev) return false;
            if (KmDistanceToHatch != other.KmDistanceToHatch) return false;
            if (FamilyId != other.FamilyId) return false;
            if (CandyToEvolve != other.CandyToEvolve) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (PokemonId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)PokemonId);
            }
            if (ModelScale != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(ModelScale);
            }
            if (Type != 0)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)Type);
            }
            if (Type2 != 0)
            {
                output.WriteRawTag(40);
                output.WriteEnum((int)Type2);
            }
            if (camera_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(Camera);
            }
            if (encounter_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(Encounter);
            }
            if (stats_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(Stats);
            }
            quickMoves_.WriteTo(output, _repeated_quickMoves_codec);
            cinematicMoves_.WriteTo(output, _repeated_cinematicMoves_codec);
            animationTime_.WriteTo(output, _repeated_animationTime_codec);
            evolutionIds_.WriteTo(output, _repeated_evolutionIds_codec);
            if (EvolutionPips != 0)
            {
                output.WriteRawTag(104);
                output.WriteInt32(EvolutionPips);
            }
            if (Class != 0)
            {
                output.WriteRawTag(112);
                output.WriteEnum((int)Class);
            }
            if (PokedexHeightM != 0F)
            {
                output.WriteRawTag(125);
                output.WriteFloat(PokedexHeightM);
            }
            if (PokedexWeightKg != 0F)
            {
                output.WriteRawTag(133, 1);
                output.WriteFloat(PokedexWeightKg);
            }
            if (ParentPokemonId != 0)
            {
                output.WriteRawTag(136, 1);
                output.WriteEnum((int)ParentPokemonId);
            }
            if (HeightStdDev != 0F)
            {
                output.WriteRawTag(149, 1);
                output.WriteFloat(HeightStdDev);
            }
            if (WeightStdDev != 0F)
            {
                output.WriteRawTag(157, 1);
                output.WriteFloat(WeightStdDev);
            }
            if (KmDistanceToHatch != 0F)
            {
                output.WriteRawTag(165, 1);
                output.WriteFloat(KmDistanceToHatch);
            }
            if (FamilyId != 0)
            {
                output.WriteRawTag(168, 1);
                output.WriteEnum((int)FamilyId);
            }
            if (CandyToEvolve != 0)
            {
                output.WriteRawTag(176, 1);
                output.WriteInt32(CandyToEvolve);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (PokemonId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
            }
            if (ModelScale != 0F)
            {
                size += 1 + 4;
            }
            if (Type != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
            }
            if (Type2 != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type2);
            }
            if (camera_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Camera);
            }
            if (encounter_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Encounter);
            }
            if (stats_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stats);
            }
            size += quickMoves_.CalculateSize(_repeated_quickMoves_codec);
            size += cinematicMoves_.CalculateSize(_repeated_cinematicMoves_codec);
            size += animationTime_.CalculateSize(_repeated_animationTime_codec);
            size += evolutionIds_.CalculateSize(_repeated_evolutionIds_codec);
            if (EvolutionPips != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionPips);
            }
            if (Class != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Class);
            }
            if (PokedexHeightM != 0F)
            {
                size += 1 + 4;
            }
            if (PokedexWeightKg != 0F)
            {
                size += 2 + 4;
            }
            if (ParentPokemonId != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeEnumSize((int)ParentPokemonId);
            }
            if (HeightStdDev != 0F)
            {
                size += 2 + 4;
            }
            if (WeightStdDev != 0F)
            {
                size += 2 + 4;
            }
            if (KmDistanceToHatch != 0F)
            {
                size += 2 + 4;
            }
            if (FamilyId != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeEnumSize((int)FamilyId);
            }
            if (CandyToEvolve != 0)
            {
                size += 2 + pb::CodedOutputStream.ComputeInt32Size(CandyToEvolve);
            }
            return size;
        }

        public void MergeFrom(PokemonSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PokemonId != 0)
            {
                PokemonId = other.PokemonId;
            }
            if (other.ModelScale != 0F)
            {
                ModelScale = other.ModelScale;
            }
            if (other.Type != 0)
            {
                Type = other.Type;
            }
            if (other.Type2 != 0)
            {
                Type2 = other.Type2;
            }
            if (other.camera_ != null)
            {
                if (camera_ == null)
                {
                    camera_ = new global::PokeGodar.WebAPI.GeneratedCode.CameraAttributes();
                }
                Camera.MergeFrom(other.Camera);
            }
            if (other.encounter_ != null)
            {
                if (encounter_ == null)
                {
                    encounter_ = new global::PokeGodar.WebAPI.GeneratedCode.EncounterAttributes();
                }
                Encounter.MergeFrom(other.Encounter);
            }
            if (other.stats_ != null)
            {
                if (stats_ == null)
                {
                    stats_ = new global::PokeGodar.WebAPI.GeneratedCode.StatsAttributes();
                }
                Stats.MergeFrom(other.Stats);
            }
            quickMoves_.Add(other.quickMoves_);
            cinematicMoves_.Add(other.cinematicMoves_);
            animationTime_.Add(other.animationTime_);
            evolutionIds_.Add(other.evolutionIds_);
            if (other.EvolutionPips != 0)
            {
                EvolutionPips = other.EvolutionPips;
            }
            if (other.Class != 0)
            {
                Class = other.Class;
            }
            if (other.PokedexHeightM != 0F)
            {
                PokedexHeightM = other.PokedexHeightM;
            }
            if (other.PokedexWeightKg != 0F)
            {
                PokedexWeightKg = other.PokedexWeightKg;
            }
            if (other.ParentPokemonId != 0)
            {
                ParentPokemonId = other.ParentPokemonId;
            }
            if (other.HeightStdDev != 0F)
            {
                HeightStdDev = other.HeightStdDev;
            }
            if (other.WeightStdDev != 0F)
            {
                WeightStdDev = other.WeightStdDev;
            }
            if (other.KmDistanceToHatch != 0F)
            {
                KmDistanceToHatch = other.KmDistanceToHatch;
            }
            if (other.FamilyId != 0)
            {
                FamilyId = other.FamilyId;
            }
            if (other.CandyToEvolve != 0)
            {
                CandyToEvolve = other.CandyToEvolve;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            pokemonId_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 29:
                        {
                            ModelScale = input.ReadFloat();
                            break;
                        }
                    case 32:
                        {
                            type_ = (global::AllEnum.PokemonType)input.ReadEnum();
                            break;
                        }
                    case 40:
                        {
                            type2_ = (global::AllEnum.PokemonType)input.ReadEnum();
                            break;
                        }
                    case 50:
                        {
                            if (camera_ == null)
                            {
                                camera_ = new global::PokeGodar.WebAPI.GeneratedCode.CameraAttributes();
                            }
                            input.ReadMessage(camera_);
                            break;
                        }
                    case 58:
                        {
                            if (encounter_ == null)
                            {
                                encounter_ = new global::PokeGodar.WebAPI.GeneratedCode.EncounterAttributes();
                            }
                            input.ReadMessage(encounter_);
                            break;
                        }
                    case 66:
                        {
                            if (stats_ == null)
                            {
                                stats_ = new global::PokeGodar.WebAPI.GeneratedCode.StatsAttributes();
                            }
                            input.ReadMessage(stats_);
                            break;
                        }
                    case 74:
                    case 72:
                        {
                            quickMoves_.AddEntriesFrom(input, _repeated_quickMoves_codec);
                            break;
                        }
                    case 82:
                    case 80:
                        {
                            cinematicMoves_.AddEntriesFrom(input, _repeated_cinematicMoves_codec);
                            break;
                        }
                    case 90:
                    case 93:
                        {
                            animationTime_.AddEntriesFrom(input, _repeated_animationTime_codec);
                            break;
                        }
                    case 98:
                    case 96:
                        {
                            evolutionIds_.AddEntriesFrom(input, _repeated_evolutionIds_codec);
                            break;
                        }
                    case 104:
                        {
                            EvolutionPips = input.ReadInt32();
                            break;
                        }
                    case 112:
                        {
                            class_ = (global::AllEnum.PokemonClass)input.ReadEnum();
                            break;
                        }
                    case 125:
                        {
                            PokedexHeightM = input.ReadFloat();
                            break;
                        }
                    case 133:
                        {
                            PokedexWeightKg = input.ReadFloat();
                            break;
                        }
                    case 136:
                        {
                            parentPokemonId_ = (global::AllEnum.PokemonId)input.ReadEnum();
                            break;
                        }
                    case 149:
                        {
                            HeightStdDev = input.ReadFloat();
                            break;
                        }
                    case 157:
                        {
                            WeightStdDev = input.ReadFloat();
                            break;
                        }
                    case 165:
                        {
                            KmDistanceToHatch = input.ReadFloat();
                            break;
                        }
                    case 168:
                        {
                            familyId_ = (global::AllEnum.PokemonFamilyId)input.ReadEnum();
                            break;
                        }
                    case 176:
                        {
                            CandyToEvolve = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PokemonSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
            if (ModelScale != 0F) hash ^= ModelScale.GetHashCode();
            if (Type != 0) hash ^= Type.GetHashCode();
            if (Type2 != 0) hash ^= Type2.GetHashCode();
            if (camera_ != null) hash ^= Camera.GetHashCode();
            if (encounter_ != null) hash ^= Encounter.GetHashCode();
            if (stats_ != null) hash ^= Stats.GetHashCode();
            hash ^= quickMoves_.GetHashCode();
            hash ^= cinematicMoves_.GetHashCode();
            hash ^= animationTime_.GetHashCode();
            hash ^= evolutionIds_.GetHashCode();
            if (EvolutionPips != 0) hash ^= EvolutionPips.GetHashCode();
            if (Class != 0) hash ^= Class.GetHashCode();
            if (PokedexHeightM != 0F) hash ^= PokedexHeightM.GetHashCode();
            if (PokedexWeightKg != 0F) hash ^= PokedexWeightKg.GetHashCode();
            if (ParentPokemonId != 0) hash ^= ParentPokemonId.GetHashCode();
            if (HeightStdDev != 0F) hash ^= HeightStdDev.GetHashCode();
            if (WeightStdDev != 0F) hash ^= WeightStdDev.GetHashCode();
            if (KmDistanceToHatch != 0F) hash ^= KmDistanceToHatch.GetHashCode();
            if (FamilyId != 0) hash ^= FamilyId.GetHashCode();
            if (CandyToEvolve != 0) hash ^= CandyToEvolve.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CameraAttributes : pb::IMessage<CameraAttributes>
    {
        /// <summary>Field number for the "disk_radius_m" field.</summary>
        public const int DiskRadiusMFieldNumber = 1;

        /// <summary>Field number for the "cylinder_radius_m" field.</summary>
        public const int CylinderRadiusMFieldNumber = 2;

        /// <summary>Field number for the "cylinder_height_m" field.</summary>
        public const int CylinderHeightMFieldNumber = 3;

        /// <summary>Field number for the "cylinder_ground_m" field.</summary>
        public const int CylinderGroundMFieldNumber = 4;

        /// <summary>Field number for the "shoulder_mode_scale" field.</summary>
        public const int ShoulderModeScaleFieldNumber = 5;

        private static readonly pb::MessageParser<CameraAttributes> _parser =
            new pb::MessageParser<CameraAttributes>(() => new CameraAttributes());

        private float cylinderGroundM_;
        private float cylinderHeightM_;
        private float cylinderRadiusM_;
        private float diskRadiusM_;
        private float shoulderModeScale_;

        public CameraAttributes()
        {
            OnConstruction();
        }

        public CameraAttributes(CameraAttributes other) : this()
        {
            diskRadiusM_ = other.diskRadiusM_;
            cylinderRadiusM_ = other.cylinderRadiusM_;
            cylinderHeightM_ = other.cylinderHeightM_;
            cylinderGroundM_ = other.cylinderGroundM_;
            shoulderModeScale_ = other.shoulderModeScale_;
        }

        public static pb::MessageParser<CameraAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[79]; }
        }

        public float DiskRadiusM
        {
            get { return diskRadiusM_; }
            set { diskRadiusM_ = value; }
        }

        public float CylinderRadiusM
        {
            get { return cylinderRadiusM_; }
            set { cylinderRadiusM_ = value; }
        }

        public float CylinderHeightM
        {
            get { return cylinderHeightM_; }
            set { cylinderHeightM_ = value; }
        }

        public float CylinderGroundM
        {
            get { return cylinderGroundM_; }
            set { cylinderGroundM_ = value; }
        }

        public float ShoulderModeScale
        {
            get { return shoulderModeScale_; }
            set { shoulderModeScale_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CameraAttributes Clone()
        {
            return new CameraAttributes(this);
        }

        public bool Equals(CameraAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (DiskRadiusM != other.DiskRadiusM) return false;
            if (CylinderRadiusM != other.CylinderRadiusM) return false;
            if (CylinderHeightM != other.CylinderHeightM) return false;
            if (CylinderGroundM != other.CylinderGroundM) return false;
            if (ShoulderModeScale != other.ShoulderModeScale) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (DiskRadiusM != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(DiskRadiusM);
            }
            if (CylinderRadiusM != 0F)
            {
                output.WriteRawTag(21);
                output.WriteFloat(CylinderRadiusM);
            }
            if (CylinderHeightM != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(CylinderHeightM);
            }
            if (CylinderGroundM != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(CylinderGroundM);
            }
            if (ShoulderModeScale != 0F)
            {
                output.WriteRawTag(45);
                output.WriteFloat(ShoulderModeScale);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (DiskRadiusM != 0F)
            {
                size += 1 + 4;
            }
            if (CylinderRadiusM != 0F)
            {
                size += 1 + 4;
            }
            if (CylinderHeightM != 0F)
            {
                size += 1 + 4;
            }
            if (CylinderGroundM != 0F)
            {
                size += 1 + 4;
            }
            if (ShoulderModeScale != 0F)
            {
                size += 1 + 4;
            }
            return size;
        }

        public void MergeFrom(CameraAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.DiskRadiusM != 0F)
            {
                DiskRadiusM = other.DiskRadiusM;
            }
            if (other.CylinderRadiusM != 0F)
            {
                CylinderRadiusM = other.CylinderRadiusM;
            }
            if (other.CylinderHeightM != 0F)
            {
                CylinderHeightM = other.CylinderHeightM;
            }
            if (other.CylinderGroundM != 0F)
            {
                CylinderGroundM = other.CylinderGroundM;
            }
            if (other.ShoulderModeScale != 0F)
            {
                ShoulderModeScale = other.ShoulderModeScale;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            DiskRadiusM = input.ReadFloat();
                            break;
                        }
                    case 21:
                        {
                            CylinderRadiusM = input.ReadFloat();
                            break;
                        }
                    case 29:
                        {
                            CylinderHeightM = input.ReadFloat();
                            break;
                        }
                    case 37:
                        {
                            CylinderGroundM = input.ReadFloat();
                            break;
                        }
                    case 45:
                        {
                            ShoulderModeScale = input.ReadFloat();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as CameraAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (DiskRadiusM != 0F) hash ^= DiskRadiusM.GetHashCode();
            if (CylinderRadiusM != 0F) hash ^= CylinderRadiusM.GetHashCode();
            if (CylinderHeightM != 0F) hash ^= CylinderHeightM.GetHashCode();
            if (CylinderGroundM != 0F) hash ^= CylinderGroundM.GetHashCode();
            if (ShoulderModeScale != 0F) hash ^= ShoulderModeScale.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EncounterAttributes : pb::IMessage<EncounterAttributes>
    {
        /// <summary>Field number for the "base_capture_rate" field.</summary>
        public const int BaseCaptureRateFieldNumber = 1;

        /// <summary>Field number for the "base_flee_rate" field.</summary>
        public const int BaseFleeRateFieldNumber = 2;

        /// <summary>Field number for the "collision_radius_m" field.</summary>
        public const int CollisionRadiusMFieldNumber = 3;

        /// <summary>Field number for the "collision_height_m" field.</summary>
        public const int CollisionHeightMFieldNumber = 4;

        /// <summary>Field number for the "collision_head_radius_m" field.</summary>
        public const int CollisionHeadRadiusMFieldNumber = 5;

        /// <summary>Field number for the "movement_type" field.</summary>
        public const int MovementTypeFieldNumber = 6;

        /// <summary>Field number for the "movement_timer_s" field.</summary>
        public const int MovementTimerSFieldNumber = 7;

        /// <summary>Field number for the "jump_time_s" field.</summary>
        public const int JumpTimeSFieldNumber = 8;

        /// <summary>Field number for the "attack_timer_s" field.</summary>
        public const int AttackTimerSFieldNumber = 9;

        private static readonly pb::MessageParser<EncounterAttributes> _parser =
            new pb::MessageParser<EncounterAttributes>(() => new EncounterAttributes());

        private float attackTimerS_;
        private float baseCaptureRate_;
        private float baseFleeRate_;
        private float collisionHeadRadiusM_;
        private float collisionHeightM_;
        private float collisionRadiusM_;
        private float jumpTimeS_;
        private float movementTimerS_;
        private global::AllEnum.PokemonMovementType movementType_ = 0;

        public EncounterAttributes()
        {
            OnConstruction();
        }

        public EncounterAttributes(EncounterAttributes other) : this()
        {
            baseCaptureRate_ = other.baseCaptureRate_;
            baseFleeRate_ = other.baseFleeRate_;
            collisionRadiusM_ = other.collisionRadiusM_;
            collisionHeightM_ = other.collisionHeightM_;
            collisionHeadRadiusM_ = other.collisionHeadRadiusM_;
            movementType_ = other.movementType_;
            movementTimerS_ = other.movementTimerS_;
            jumpTimeS_ = other.jumpTimeS_;
            attackTimerS_ = other.attackTimerS_;
        }

        public static pb::MessageParser<EncounterAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[80]; }
        }

        public float BaseCaptureRate
        {
            get { return baseCaptureRate_; }
            set { baseCaptureRate_ = value; }
        }

        public float BaseFleeRate
        {
            get { return baseFleeRate_; }
            set { baseFleeRate_ = value; }
        }

        public float CollisionRadiusM
        {
            get { return collisionRadiusM_; }
            set { collisionRadiusM_ = value; }
        }

        public float CollisionHeightM
        {
            get { return collisionHeightM_; }
            set { collisionHeightM_ = value; }
        }

        public float CollisionHeadRadiusM
        {
            get { return collisionHeadRadiusM_; }
            set { collisionHeadRadiusM_ = value; }
        }

        public global::AllEnum.PokemonMovementType MovementType
        {
            get { return movementType_; }
            set { movementType_ = value; }
        }

        public float MovementTimerS
        {
            get { return movementTimerS_; }
            set { movementTimerS_ = value; }
        }

        public float JumpTimeS
        {
            get { return jumpTimeS_; }
            set { jumpTimeS_ = value; }
        }

        public float AttackTimerS
        {
            get { return attackTimerS_; }
            set { attackTimerS_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncounterAttributes Clone()
        {
            return new EncounterAttributes(this);
        }

        public bool Equals(EncounterAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (BaseCaptureRate != other.BaseCaptureRate) return false;
            if (BaseFleeRate != other.BaseFleeRate) return false;
            if (CollisionRadiusM != other.CollisionRadiusM) return false;
            if (CollisionHeightM != other.CollisionHeightM) return false;
            if (CollisionHeadRadiusM != other.CollisionHeadRadiusM) return false;
            if (MovementType != other.MovementType) return false;
            if (MovementTimerS != other.MovementTimerS) return false;
            if (JumpTimeS != other.JumpTimeS) return false;
            if (AttackTimerS != other.AttackTimerS) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (BaseCaptureRate != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(BaseCaptureRate);
            }
            if (BaseFleeRate != 0F)
            {
                output.WriteRawTag(21);
                output.WriteFloat(BaseFleeRate);
            }
            if (CollisionRadiusM != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(CollisionRadiusM);
            }
            if (CollisionHeightM != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(CollisionHeightM);
            }
            if (CollisionHeadRadiusM != 0F)
            {
                output.WriteRawTag(45);
                output.WriteFloat(CollisionHeadRadiusM);
            }
            if (MovementType != 0)
            {
                output.WriteRawTag(48);
                output.WriteEnum((int)MovementType);
            }
            if (MovementTimerS != 0F)
            {
                output.WriteRawTag(61);
                output.WriteFloat(MovementTimerS);
            }
            if (JumpTimeS != 0F)
            {
                output.WriteRawTag(69);
                output.WriteFloat(JumpTimeS);
            }
            if (AttackTimerS != 0F)
            {
                output.WriteRawTag(77);
                output.WriteFloat(AttackTimerS);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (BaseCaptureRate != 0F)
            {
                size += 1 + 4;
            }
            if (BaseFleeRate != 0F)
            {
                size += 1 + 4;
            }
            if (CollisionRadiusM != 0F)
            {
                size += 1 + 4;
            }
            if (CollisionHeightM != 0F)
            {
                size += 1 + 4;
            }
            if (CollisionHeadRadiusM != 0F)
            {
                size += 1 + 4;
            }
            if (MovementType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)MovementType);
            }
            if (MovementTimerS != 0F)
            {
                size += 1 + 4;
            }
            if (JumpTimeS != 0F)
            {
                size += 1 + 4;
            }
            if (AttackTimerS != 0F)
            {
                size += 1 + 4;
            }
            return size;
        }

        public void MergeFrom(EncounterAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.BaseCaptureRate != 0F)
            {
                BaseCaptureRate = other.BaseCaptureRate;
            }
            if (other.BaseFleeRate != 0F)
            {
                BaseFleeRate = other.BaseFleeRate;
            }
            if (other.CollisionRadiusM != 0F)
            {
                CollisionRadiusM = other.CollisionRadiusM;
            }
            if (other.CollisionHeightM != 0F)
            {
                CollisionHeightM = other.CollisionHeightM;
            }
            if (other.CollisionHeadRadiusM != 0F)
            {
                CollisionHeadRadiusM = other.CollisionHeadRadiusM;
            }
            if (other.MovementType != 0)
            {
                MovementType = other.MovementType;
            }
            if (other.MovementTimerS != 0F)
            {
                MovementTimerS = other.MovementTimerS;
            }
            if (other.JumpTimeS != 0F)
            {
                JumpTimeS = other.JumpTimeS;
            }
            if (other.AttackTimerS != 0F)
            {
                AttackTimerS = other.AttackTimerS;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            BaseCaptureRate = input.ReadFloat();
                            break;
                        }
                    case 21:
                        {
                            BaseFleeRate = input.ReadFloat();
                            break;
                        }
                    case 29:
                        {
                            CollisionRadiusM = input.ReadFloat();
                            break;
                        }
                    case 37:
                        {
                            CollisionHeightM = input.ReadFloat();
                            break;
                        }
                    case 45:
                        {
                            CollisionHeadRadiusM = input.ReadFloat();
                            break;
                        }
                    case 48:
                        {
                            movementType_ = (global::AllEnum.PokemonMovementType)input.ReadEnum();
                            break;
                        }
                    case 61:
                        {
                            MovementTimerS = input.ReadFloat();
                            break;
                        }
                    case 69:
                        {
                            JumpTimeS = input.ReadFloat();
                            break;
                        }
                    case 77:
                        {
                            AttackTimerS = input.ReadFloat();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EncounterAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (BaseCaptureRate != 0F) hash ^= BaseCaptureRate.GetHashCode();
            if (BaseFleeRate != 0F) hash ^= BaseFleeRate.GetHashCode();
            if (CollisionRadiusM != 0F) hash ^= CollisionRadiusM.GetHashCode();
            if (CollisionHeightM != 0F) hash ^= CollisionHeightM.GetHashCode();
            if (CollisionHeadRadiusM != 0F) hash ^= CollisionHeadRadiusM.GetHashCode();
            if (MovementType != 0) hash ^= MovementType.GetHashCode();
            if (MovementTimerS != 0F) hash ^= MovementTimerS.GetHashCode();
            if (JumpTimeS != 0F) hash ^= JumpTimeS.GetHashCode();
            if (AttackTimerS != 0F) hash ^= AttackTimerS.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class StatsAttributes : pb::IMessage<StatsAttributes>
    {
        /// <summary>Field number for the "base_stamina" field.</summary>
        public const int BaseStaminaFieldNumber = 1;

        /// <summary>Field number for the "base_attack" field.</summary>
        public const int BaseAttackFieldNumber = 2;

        /// <summary>Field number for the "base_defense" field.</summary>
        public const int BaseDefenseFieldNumber = 3;

        /// <summary>Field number for the "dodge_energy_delta" field.</summary>
        public const int DodgeEnergyDeltaFieldNumber = 8;

        private static readonly pb::MessageParser<StatsAttributes> _parser =
            new pb::MessageParser<StatsAttributes>(() => new StatsAttributes());

        private int baseAttack_;
        private int baseDefense_;
        private int baseStamina_;
        private int dodgeEnergyDelta_;

        public StatsAttributes()
        {
            OnConstruction();
        }

        public StatsAttributes(StatsAttributes other) : this()
        {
            baseStamina_ = other.baseStamina_;
            baseAttack_ = other.baseAttack_;
            baseDefense_ = other.baseDefense_;
            dodgeEnergyDelta_ = other.dodgeEnergyDelta_;
        }

        public static pb::MessageParser<StatsAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[81]; }
        }

        public int BaseStamina
        {
            get { return baseStamina_; }
            set { baseStamina_ = value; }
        }

        public int BaseAttack
        {
            get { return baseAttack_; }
            set { baseAttack_ = value; }
        }

        public int BaseDefense
        {
            get { return baseDefense_; }
            set { baseDefense_ = value; }
        }

        public int DodgeEnergyDelta
        {
            get { return dodgeEnergyDelta_; }
            set { dodgeEnergyDelta_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public StatsAttributes Clone()
        {
            return new StatsAttributes(this);
        }

        public bool Equals(StatsAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (BaseStamina != other.BaseStamina) return false;
            if (BaseAttack != other.BaseAttack) return false;
            if (BaseDefense != other.BaseDefense) return false;
            if (DodgeEnergyDelta != other.DodgeEnergyDelta) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (BaseStamina != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(BaseStamina);
            }
            if (BaseAttack != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(BaseAttack);
            }
            if (BaseDefense != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(BaseDefense);
            }
            if (DodgeEnergyDelta != 0)
            {
                output.WriteRawTag(64);
                output.WriteInt32(DodgeEnergyDelta);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (BaseStamina != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseStamina);
            }
            if (BaseAttack != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseAttack);
            }
            if (BaseDefense != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseDefense);
            }
            if (DodgeEnergyDelta != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DodgeEnergyDelta);
            }
            return size;
        }

        public void MergeFrom(StatsAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.BaseStamina != 0)
            {
                BaseStamina = other.BaseStamina;
            }
            if (other.BaseAttack != 0)
            {
                BaseAttack = other.BaseAttack;
            }
            if (other.BaseDefense != 0)
            {
                BaseDefense = other.BaseDefense;
            }
            if (other.DodgeEnergyDelta != 0)
            {
                DodgeEnergyDelta = other.DodgeEnergyDelta;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            BaseStamina = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            BaseAttack = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            BaseDefense = input.ReadInt32();
                            break;
                        }
                    case 64:
                        {
                            DodgeEnergyDelta = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as StatsAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (BaseStamina != 0) hash ^= BaseStamina.GetHashCode();
            if (BaseAttack != 0) hash ^= BaseAttack.GetHashCode();
            if (BaseDefense != 0) hash ^= BaseDefense.GetHashCode();
            if (DodgeEnergyDelta != 0) hash ^= DodgeEnergyDelta.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class ItemSettings : pb::IMessage<ItemSettings>
    {
        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;

        /// <summary>Field number for the "item_type" field.</summary>
        public const int ItemTypeFieldNumber = 2;

        /// <summary>Field number for the "category" field.</summary>
        public const int CategoryFieldNumber = 3;

        /// <summary>Field number for the "drop_freq" field.</summary>
        public const int DropFreqFieldNumber = 4;

        /// <summary>Field number for the "drop_trainer_level" field.</summary>
        public const int DropTrainerLevelFieldNumber = 5;

        /// <summary>Field number for the "pokeball" field.</summary>
        public const int PokeballFieldNumber = 6;

        /// <summary>Field number for the "potion" field.</summary>
        public const int PotionFieldNumber = 7;

        /// <summary>Field number for the "revive" field.</summary>
        public const int ReviveFieldNumber = 8;

        /// <summary>Field number for the "battle" field.</summary>
        public const int BattleFieldNumber = 9;

        /// <summary>Field number for the "food" field.</summary>
        public const int FoodFieldNumber = 10;

        /// <summary>Field number for the "inventory_upgrade" field.</summary>
        public const int InventoryUpgradeFieldNumber = 11;

        /// <summary>Field number for the "xp_boost" field.</summary>
        public const int XpBoostFieldNumber = 12;

        /// <summary>Field number for the "incense" field.</summary>
        public const int IncenseFieldNumber = 13;

        /// <summary>Field number for the "egg_incubator" field.</summary>
        public const int EggIncubatorFieldNumber = 14;

        /// <summary>Field number for the "fort_modifier" field.</summary>
        public const int FortModifierFieldNumber = 15;

        private static readonly pb::MessageParser<ItemSettings> _parser =
            new pb::MessageParser<ItemSettings>(() => new ItemSettings());

        private global::PokeGodar.WebAPI.GeneratedCode.BattleAttributes battle_;
        private global::AllEnum.ItemCategory category_ = 0;
        private float dropFreq_;
        private int dropTrainerLevel_;
        private global::PokeGodar.WebAPI.GeneratedCode.EggIncubatorAttributes eggIncubator_;
        private global::PokeGodar.WebAPI.GeneratedCode.FoodAttributes food_;
        private global::PokeGodar.WebAPI.GeneratedCode.FortModifierAttributes fortModifier_;
        private global::PokeGodar.WebAPI.GeneratedCode.IncenseAttributes incense_;
        private global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgradeAttributes inventoryUpgrade_;
        private global::AllEnum.ItemId itemId_ = 0;
        private global::AllEnum.ItemType itemType_ = 0;
        private global::PokeGodar.WebAPI.GeneratedCode.PokeballAttributes pokeball_;
        private global::PokeGodar.WebAPI.GeneratedCode.PotionAttributes potion_;
        private global::PokeGodar.WebAPI.GeneratedCode.ReviveAttributes revive_;
        private global::PokeGodar.WebAPI.GeneratedCode.ExperienceBoostAttributes xpBoost_;

        public ItemSettings()
        {
            OnConstruction();
        }

        public ItemSettings(ItemSettings other) : this()
        {
            itemId_ = other.itemId_;
            itemType_ = other.itemType_;
            category_ = other.category_;
            dropFreq_ = other.dropFreq_;
            dropTrainerLevel_ = other.dropTrainerLevel_;
            Pokeball = other.pokeball_ != null ? other.Pokeball.Clone() : null;
            Potion = other.potion_ != null ? other.Potion.Clone() : null;
            Revive = other.revive_ != null ? other.Revive.Clone() : null;
            Battle = other.battle_ != null ? other.Battle.Clone() : null;
            Food = other.food_ != null ? other.Food.Clone() : null;
            InventoryUpgrade = other.inventoryUpgrade_ != null ? other.InventoryUpgrade.Clone() : null;
            XpBoost = other.xpBoost_ != null ? other.XpBoost.Clone() : null;
            Incense = other.incense_ != null ? other.Incense.Clone() : null;
            EggIncubator = other.eggIncubator_ != null ? other.EggIncubator.Clone() : null;
            FortModifier = other.fortModifier_ != null ? other.FortModifier.Clone() : null;
        }

        public static pb::MessageParser<ItemSettings> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[82]; }
        }

        public global::AllEnum.ItemId ItemId
        {
            get { return itemId_; }
            set { itemId_ = value; }
        }

        public global::AllEnum.ItemType ItemType
        {
            get { return itemType_; }
            set { itemType_ = value; }
        }

        public global::AllEnum.ItemCategory Category
        {
            get { return category_; }
            set { category_ = value; }
        }

        public float DropFreq
        {
            get { return dropFreq_; }
            set { dropFreq_ = value; }
        }

        public int DropTrainerLevel
        {
            get { return dropTrainerLevel_; }
            set { dropTrainerLevel_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PokeballAttributes Pokeball
        {
            get { return pokeball_; }
            set { pokeball_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.PotionAttributes Potion
        {
            get { return potion_; }
            set { potion_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.ReviveAttributes Revive
        {
            get { return revive_; }
            set { revive_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.BattleAttributes Battle
        {
            get { return battle_; }
            set { battle_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.FoodAttributes Food
        {
            get { return food_; }
            set { food_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgradeAttributes InventoryUpgrade
        {
            get { return inventoryUpgrade_; }
            set { inventoryUpgrade_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.ExperienceBoostAttributes XpBoost
        {
            get { return xpBoost_; }
            set { xpBoost_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.IncenseAttributes Incense
        {
            get { return incense_; }
            set { incense_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.EggIncubatorAttributes EggIncubator
        {
            get { return eggIncubator_; }
            set { eggIncubator_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.FortModifierAttributes FortModifier
        {
            get { return fortModifier_; }
            set { fortModifier_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ItemSettings Clone()
        {
            return new ItemSettings(this);
        }

        public bool Equals(ItemSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ItemId != other.ItemId) return false;
            if (ItemType != other.ItemType) return false;
            if (Category != other.Category) return false;
            if (DropFreq != other.DropFreq) return false;
            if (DropTrainerLevel != other.DropTrainerLevel) return false;
            if (!Equals(Pokeball, other.Pokeball)) return false;
            if (!Equals(Potion, other.Potion)) return false;
            if (!Equals(Revive, other.Revive)) return false;
            if (!Equals(Battle, other.Battle)) return false;
            if (!Equals(Food, other.Food)) return false;
            if (!Equals(InventoryUpgrade, other.InventoryUpgrade)) return false;
            if (!Equals(XpBoost, other.XpBoost)) return false;
            if (!Equals(Incense, other.Incense)) return false;
            if (!Equals(EggIncubator, other.EggIncubator)) return false;
            if (!Equals(FortModifier, other.FortModifier)) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ItemId != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)ItemId);
            }
            if (ItemType != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)ItemType);
            }
            if (Category != 0)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)Category);
            }
            if (DropFreq != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(DropFreq);
            }
            if (DropTrainerLevel != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(DropTrainerLevel);
            }
            if (pokeball_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(Pokeball);
            }
            if (potion_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(Potion);
            }
            if (revive_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(Revive);
            }
            if (battle_ != null)
            {
                output.WriteRawTag(74);
                output.WriteMessage(Battle);
            }
            if (food_ != null)
            {
                output.WriteRawTag(82);
                output.WriteMessage(Food);
            }
            if (inventoryUpgrade_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(InventoryUpgrade);
            }
            if (xpBoost_ != null)
            {
                output.WriteRawTag(98);
                output.WriteMessage(XpBoost);
            }
            if (incense_ != null)
            {
                output.WriteRawTag(106);
                output.WriteMessage(Incense);
            }
            if (eggIncubator_ != null)
            {
                output.WriteRawTag(114);
                output.WriteMessage(EggIncubator);
            }
            if (fortModifier_ != null)
            {
                output.WriteRawTag(122);
                output.WriteMessage(FortModifier);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ItemId != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
            }
            if (ItemType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemType);
            }
            if (Category != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Category);
            }
            if (DropFreq != 0F)
            {
                size += 1 + 4;
            }
            if (DropTrainerLevel != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DropTrainerLevel);
            }
            if (pokeball_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pokeball);
            }
            if (potion_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Potion);
            }
            if (revive_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Revive);
            }
            if (battle_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Battle);
            }
            if (food_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Food);
            }
            if (inventoryUpgrade_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryUpgrade);
            }
            if (xpBoost_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(XpBoost);
            }
            if (incense_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Incense);
            }
            if (eggIncubator_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubator);
            }
            if (fortModifier_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortModifier);
            }
            return size;
        }

        public void MergeFrom(ItemSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ItemId != 0)
            {
                ItemId = other.ItemId;
            }
            if (other.ItemType != 0)
            {
                ItemType = other.ItemType;
            }
            if (other.Category != 0)
            {
                Category = other.Category;
            }
            if (other.DropFreq != 0F)
            {
                DropFreq = other.DropFreq;
            }
            if (other.DropTrainerLevel != 0)
            {
                DropTrainerLevel = other.DropTrainerLevel;
            }
            if (other.pokeball_ != null)
            {
                if (pokeball_ == null)
                {
                    pokeball_ = new global::PokeGodar.WebAPI.GeneratedCode.PokeballAttributes();
                }
                Pokeball.MergeFrom(other.Pokeball);
            }
            if (other.potion_ != null)
            {
                if (potion_ == null)
                {
                    potion_ = new global::PokeGodar.WebAPI.GeneratedCode.PotionAttributes();
                }
                Potion.MergeFrom(other.Potion);
            }
            if (other.revive_ != null)
            {
                if (revive_ == null)
                {
                    revive_ = new global::PokeGodar.WebAPI.GeneratedCode.ReviveAttributes();
                }
                Revive.MergeFrom(other.Revive);
            }
            if (other.battle_ != null)
            {
                if (battle_ == null)
                {
                    battle_ = new global::PokeGodar.WebAPI.GeneratedCode.BattleAttributes();
                }
                Battle.MergeFrom(other.Battle);
            }
            if (other.food_ != null)
            {
                if (food_ == null)
                {
                    food_ = new global::PokeGodar.WebAPI.GeneratedCode.FoodAttributes();
                }
                Food.MergeFrom(other.Food);
            }
            if (other.inventoryUpgrade_ != null)
            {
                if (inventoryUpgrade_ == null)
                {
                    inventoryUpgrade_ = new global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgradeAttributes();
                }
                InventoryUpgrade.MergeFrom(other.InventoryUpgrade);
            }
            if (other.xpBoost_ != null)
            {
                if (xpBoost_ == null)
                {
                    xpBoost_ = new global::PokeGodar.WebAPI.GeneratedCode.ExperienceBoostAttributes();
                }
                XpBoost.MergeFrom(other.XpBoost);
            }
            if (other.incense_ != null)
            {
                if (incense_ == null)
                {
                    incense_ = new global::PokeGodar.WebAPI.GeneratedCode.IncenseAttributes();
                }
                Incense.MergeFrom(other.Incense);
            }
            if (other.eggIncubator_ != null)
            {
                if (eggIncubator_ == null)
                {
                    eggIncubator_ = new global::PokeGodar.WebAPI.GeneratedCode.EggIncubatorAttributes();
                }
                EggIncubator.MergeFrom(other.EggIncubator);
            }
            if (other.fortModifier_ != null)
            {
                if (fortModifier_ == null)
                {
                    fortModifier_ = new global::PokeGodar.WebAPI.GeneratedCode.FortModifierAttributes();
                }
                FortModifier.MergeFrom(other.FortModifier);
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            itemId_ = (global::AllEnum.ItemId)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            itemType_ = (global::AllEnum.ItemType)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            category_ = (global::AllEnum.ItemCategory)input.ReadEnum();
                            break;
                        }
                    case 37:
                        {
                            DropFreq = input.ReadFloat();
                            break;
                        }
                    case 40:
                        {
                            DropTrainerLevel = input.ReadInt32();
                            break;
                        }
                    case 50:
                        {
                            if (pokeball_ == null)
                            {
                                pokeball_ = new global::PokeGodar.WebAPI.GeneratedCode.PokeballAttributes();
                            }
                            input.ReadMessage(pokeball_);
                            break;
                        }
                    case 58:
                        {
                            if (potion_ == null)
                            {
                                potion_ = new global::PokeGodar.WebAPI.GeneratedCode.PotionAttributes();
                            }
                            input.ReadMessage(potion_);
                            break;
                        }
                    case 66:
                        {
                            if (revive_ == null)
                            {
                                revive_ = new global::PokeGodar.WebAPI.GeneratedCode.ReviveAttributes();
                            }
                            input.ReadMessage(revive_);
                            break;
                        }
                    case 74:
                        {
                            if (battle_ == null)
                            {
                                battle_ = new global::PokeGodar.WebAPI.GeneratedCode.BattleAttributes();
                            }
                            input.ReadMessage(battle_);
                            break;
                        }
                    case 82:
                        {
                            if (food_ == null)
                            {
                                food_ = new global::PokeGodar.WebAPI.GeneratedCode.FoodAttributes();
                            }
                            input.ReadMessage(food_);
                            break;
                        }
                    case 90:
                        {
                            if (inventoryUpgrade_ == null)
                            {
                                inventoryUpgrade_ =
                                    new global::PokeGodar.WebAPI.GeneratedCode.InventoryUpgradeAttributes();
                            }
                            input.ReadMessage(inventoryUpgrade_);
                            break;
                        }
                    case 98:
                        {
                            if (xpBoost_ == null)
                            {
                                xpBoost_ = new global::PokeGodar.WebAPI.GeneratedCode.ExperienceBoostAttributes();
                            }
                            input.ReadMessage(xpBoost_);
                            break;
                        }
                    case 106:
                        {
                            if (incense_ == null)
                            {
                                incense_ = new global::PokeGodar.WebAPI.GeneratedCode.IncenseAttributes();
                            }
                            input.ReadMessage(incense_);
                            break;
                        }
                    case 114:
                        {
                            if (eggIncubator_ == null)
                            {
                                eggIncubator_ = new global::PokeGodar.WebAPI.GeneratedCode.EggIncubatorAttributes();
                            }
                            input.ReadMessage(eggIncubator_);
                            break;
                        }
                    case 122:
                        {
                            if (fortModifier_ == null)
                            {
                                fortModifier_ = new global::PokeGodar.WebAPI.GeneratedCode.FortModifierAttributes();
                            }
                            input.ReadMessage(fortModifier_);
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as ItemSettings);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ItemId != 0) hash ^= ItemId.GetHashCode();
            if (ItemType != 0) hash ^= ItemType.GetHashCode();
            if (Category != 0) hash ^= Category.GetHashCode();
            if (DropFreq != 0F) hash ^= DropFreq.GetHashCode();
            if (DropTrainerLevel != 0) hash ^= DropTrainerLevel.GetHashCode();
            if (pokeball_ != null) hash ^= Pokeball.GetHashCode();
            if (potion_ != null) hash ^= Potion.GetHashCode();
            if (revive_ != null) hash ^= Revive.GetHashCode();
            if (battle_ != null) hash ^= Battle.GetHashCode();
            if (food_ != null) hash ^= Food.GetHashCode();
            if (inventoryUpgrade_ != null) hash ^= InventoryUpgrade.GetHashCode();
            if (xpBoost_ != null) hash ^= XpBoost.GetHashCode();
            if (incense_ != null) hash ^= Incense.GetHashCode();
            if (eggIncubator_ != null) hash ^= EggIncubator.GetHashCode();
            if (fortModifier_ != null) hash ^= FortModifier.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class BattleAttributes : pb::IMessage<BattleAttributes>
    {
        /// <summary>Field number for the "sta_percent" field.</summary>
        public const int StaPercentFieldNumber = 1;

        private static readonly pb::MessageParser<BattleAttributes> _parser =
            new pb::MessageParser<BattleAttributes>(() => new BattleAttributes());

        private float staPercent_;

        public BattleAttributes()
        {
            OnConstruction();
        }

        public BattleAttributes(BattleAttributes other) : this()
        {
            staPercent_ = other.staPercent_;
        }

        public static pb::MessageParser<BattleAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[83]; }
        }

        public float StaPercent
        {
            get { return staPercent_; }
            set { staPercent_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BattleAttributes Clone()
        {
            return new BattleAttributes(this);
        }

        public bool Equals(BattleAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (StaPercent != other.StaPercent) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (StaPercent != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(StaPercent);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (StaPercent != 0F)
            {
                size += 1 + 4;
            }
            return size;
        }

        public void MergeFrom(BattleAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.StaPercent != 0F)
            {
                StaPercent = other.StaPercent;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            StaPercent = input.ReadFloat();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as BattleAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (StaPercent != 0F) hash ^= StaPercent.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EggIncubatorAttributes : pb::IMessage<EggIncubatorAttributes>
    {
        /// <summary>Field number for the "incubator_type" field.</summary>
        public const int IncubatorTypeFieldNumber = 1;

        /// <summary>Field number for the "uses" field.</summary>
        public const int UsesFieldNumber = 2;

        /// <summary>Field number for the "distance_multiplier" field.</summary>
        public const int DistanceMultiplierFieldNumber = 3;

        private static readonly pb::MessageParser<EggIncubatorAttributes> _parser =
            new pb::MessageParser<EggIncubatorAttributes>(() => new EggIncubatorAttributes());

        private float distanceMultiplier_;
        private global::AllEnum.EggIncubatorType incubatorType_ = 0;
        private int uses_;

        public EggIncubatorAttributes()
        {
            OnConstruction();
        }

        public EggIncubatorAttributes(EggIncubatorAttributes other) : this()
        {
            incubatorType_ = other.incubatorType_;
            uses_ = other.uses_;
            distanceMultiplier_ = other.distanceMultiplier_;
        }

        public static pb::MessageParser<EggIncubatorAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[84]; }
        }

        public global::AllEnum.EggIncubatorType IncubatorType
        {
            get { return incubatorType_; }
            set { incubatorType_ = value; }
        }

        public int Uses
        {
            get { return uses_; }
            set { uses_ = value; }
        }

        public float DistanceMultiplier
        {
            get { return distanceMultiplier_; }
            set { distanceMultiplier_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EggIncubatorAttributes Clone()
        {
            return new EggIncubatorAttributes(this);
        }

        public bool Equals(EggIncubatorAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IncubatorType != other.IncubatorType) return false;
            if (Uses != other.Uses) return false;
            if (DistanceMultiplier != other.DistanceMultiplier) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (IncubatorType != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)IncubatorType);
            }
            if (Uses != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Uses);
            }
            if (DistanceMultiplier != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(DistanceMultiplier);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (IncubatorType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)IncubatorType);
            }
            if (Uses != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Uses);
            }
            if (DistanceMultiplier != 0F)
            {
                size += 1 + 4;
            }
            return size;
        }

        public void MergeFrom(EggIncubatorAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.IncubatorType != 0)
            {
                IncubatorType = other.IncubatorType;
            }
            if (other.Uses != 0)
            {
                Uses = other.Uses;
            }
            if (other.DistanceMultiplier != 0F)
            {
                DistanceMultiplier = other.DistanceMultiplier;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            incubatorType_ = (global::AllEnum.EggIncubatorType)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            Uses = input.ReadInt32();
                            break;
                        }
                    case 29:
                        {
                            DistanceMultiplier = input.ReadFloat();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EggIncubatorAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (IncubatorType != 0) hash ^= IncubatorType.GetHashCode();
            if (Uses != 0) hash ^= Uses.GetHashCode();
            if (DistanceMultiplier != 0F) hash ^= DistanceMultiplier.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class ExperienceBoostAttributes : pb::IMessage<ExperienceBoostAttributes>
    {
        /// <summary>Field number for the "xp_multiplier" field.</summary>
        public const int XpMultiplierFieldNumber = 1;

        /// <summary>Field number for the "boost_duration_ms" field.</summary>
        public const int BoostDurationMsFieldNumber = 2;

        private static readonly pb::MessageParser<ExperienceBoostAttributes> _parser =
            new pb::MessageParser<ExperienceBoostAttributes>(() => new ExperienceBoostAttributes());

        private int boostDurationMs_;
        private float xpMultiplier_;

        public ExperienceBoostAttributes()
        {
            OnConstruction();
        }

        public ExperienceBoostAttributes(ExperienceBoostAttributes other) : this()
        {
            xpMultiplier_ = other.xpMultiplier_;
            boostDurationMs_ = other.boostDurationMs_;
        }

        public static pb::MessageParser<ExperienceBoostAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[85]; }
        }

        public float XpMultiplier
        {
            get { return xpMultiplier_; }
            set { xpMultiplier_ = value; }
        }

        public int BoostDurationMs
        {
            get { return boostDurationMs_; }
            set { boostDurationMs_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ExperienceBoostAttributes Clone()
        {
            return new ExperienceBoostAttributes(this);
        }

        public bool Equals(ExperienceBoostAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (XpMultiplier != other.XpMultiplier) return false;
            if (BoostDurationMs != other.BoostDurationMs) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (XpMultiplier != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(XpMultiplier);
            }
            if (BoostDurationMs != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(BoostDurationMs);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (XpMultiplier != 0F)
            {
                size += 1 + 4;
            }
            if (BoostDurationMs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BoostDurationMs);
            }
            return size;
        }

        public void MergeFrom(ExperienceBoostAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.XpMultiplier != 0F)
            {
                XpMultiplier = other.XpMultiplier;
            }
            if (other.BoostDurationMs != 0)
            {
                BoostDurationMs = other.BoostDurationMs;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            XpMultiplier = input.ReadFloat();
                            break;
                        }
                    case 16:
                        {
                            BoostDurationMs = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as ExperienceBoostAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (XpMultiplier != 0F) hash ^= XpMultiplier.GetHashCode();
            if (BoostDurationMs != 0) hash ^= BoostDurationMs.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FoodAttributes : pb::IMessage<FoodAttributes>
    {
        /// <summary>Field number for the "item_effect" field.</summary>
        public const int ItemEffectFieldNumber = 1;

        /// <summary>Field number for the "item_effect_percent" field.</summary>
        public const int ItemEffectPercentFieldNumber = 2;

        /// <summary>Field number for the "growth_percent" field.</summary>
        public const int GrowthPercentFieldNumber = 3;

        private static readonly pb::MessageParser<FoodAttributes> _parser =
            new pb::MessageParser<FoodAttributes>(() => new FoodAttributes());

        private static readonly pb::FieldCodec<global::AllEnum.ItemEffect> _repeated_itemEffect_codec
            = pb::FieldCodec.ForEnum(10, x => (int)x, x => (global::AllEnum.ItemEffect)x);

        private static readonly pb::FieldCodec<float> _repeated_itemEffectPercent_codec
            = pb::FieldCodec.ForFloat(18);

        private readonly pbc::RepeatedField<global::AllEnum.ItemEffect> itemEffect_ =
            new pbc::RepeatedField<global::AllEnum.ItemEffect>();

        private readonly pbc::RepeatedField<float> itemEffectPercent_ = new pbc::RepeatedField<float>();
        private float growthPercent_;

        public FoodAttributes()
        {
            OnConstruction();
        }

        public FoodAttributes(FoodAttributes other) : this()
        {
            itemEffect_ = other.itemEffect_.Clone();
            itemEffectPercent_ = other.itemEffectPercent_.Clone();
            growthPercent_ = other.growthPercent_;
        }

        public static pb::MessageParser<FoodAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[86]; }
        }

        public pbc::RepeatedField<global::AllEnum.ItemEffect> ItemEffect
        {
            get { return itemEffect_; }
        }

        public pbc::RepeatedField<float> ItemEffectPercent
        {
            get { return itemEffectPercent_; }
        }

        public float GrowthPercent
        {
            get { return growthPercent_; }
            set { growthPercent_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FoodAttributes Clone()
        {
            return new FoodAttributes(this);
        }

        public bool Equals(FoodAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!itemEffect_.Equals(other.itemEffect_)) return false;
            if (!itemEffectPercent_.Equals(other.itemEffectPercent_)) return false;
            if (GrowthPercent != other.GrowthPercent) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            itemEffect_.WriteTo(output, _repeated_itemEffect_codec);
            itemEffectPercent_.WriteTo(output, _repeated_itemEffectPercent_codec);
            if (GrowthPercent != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(GrowthPercent);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            size += itemEffect_.CalculateSize(_repeated_itemEffect_codec);
            size += itemEffectPercent_.CalculateSize(_repeated_itemEffectPercent_codec);
            if (GrowthPercent != 0F)
            {
                size += 1 + 4;
            }
            return size;
        }

        public void MergeFrom(FoodAttributes other)
        {
            if (other == null)
            {
                return;
            }
            itemEffect_.Add(other.itemEffect_);
            itemEffectPercent_.Add(other.itemEffectPercent_);
            if (other.GrowthPercent != 0F)
            {
                GrowthPercent = other.GrowthPercent;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    case 8:
                        {
                            itemEffect_.AddEntriesFrom(input, _repeated_itemEffect_codec);
                            break;
                        }
                    case 18:
                    case 21:
                        {
                            itemEffectPercent_.AddEntriesFrom(input, _repeated_itemEffectPercent_codec);
                            break;
                        }
                    case 29:
                        {
                            GrowthPercent = input.ReadFloat();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FoodAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            hash ^= itemEffect_.GetHashCode();
            hash ^= itemEffectPercent_.GetHashCode();
            if (GrowthPercent != 0F) hash ^= GrowthPercent.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FortModifierAttributes : pb::IMessage<FortModifierAttributes>
    {
        /// <summary>Field number for the "modifier_lifetime_seconds" field.</summary>
        public const int ModifierLifetimeSecondsFieldNumber = 1;

        /// <summary>Field number for the "troy_disk_num_pokemon_spawned" field.</summary>
        public const int TroyDiskNumPokemonSpawnedFieldNumber = 2;

        private static readonly pb::MessageParser<FortModifierAttributes> _parser =
            new pb::MessageParser<FortModifierAttributes>(() => new FortModifierAttributes());

        private int modifierLifetimeSeconds_;
        private int troyDiskNumPokemonSpawned_;

        public FortModifierAttributes()
        {
            OnConstruction();
        }

        public FortModifierAttributes(FortModifierAttributes other) : this()
        {
            modifierLifetimeSeconds_ = other.modifierLifetimeSeconds_;
            troyDiskNumPokemonSpawned_ = other.troyDiskNumPokemonSpawned_;
        }

        public static pb::MessageParser<FortModifierAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[87]; }
        }

        public int ModifierLifetimeSeconds
        {
            get { return modifierLifetimeSeconds_; }
            set { modifierLifetimeSeconds_ = value; }
        }

        public int TroyDiskNumPokemonSpawned
        {
            get { return troyDiskNumPokemonSpawned_; }
            set { troyDiskNumPokemonSpawned_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public FortModifierAttributes Clone()
        {
            return new FortModifierAttributes(this);
        }

        public bool Equals(FortModifierAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ModifierLifetimeSeconds != other.ModifierLifetimeSeconds) return false;
            if (TroyDiskNumPokemonSpawned != other.TroyDiskNumPokemonSpawned) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ModifierLifetimeSeconds != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(ModifierLifetimeSeconds);
            }
            if (TroyDiskNumPokemonSpawned != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(TroyDiskNumPokemonSpawned);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ModifierLifetimeSeconds != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(ModifierLifetimeSeconds);
            }
            if (TroyDiskNumPokemonSpawned != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(TroyDiskNumPokemonSpawned);
            }
            return size;
        }

        public void MergeFrom(FortModifierAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ModifierLifetimeSeconds != 0)
            {
                ModifierLifetimeSeconds = other.ModifierLifetimeSeconds;
            }
            if (other.TroyDiskNumPokemonSpawned != 0)
            {
                TroyDiskNumPokemonSpawned = other.TroyDiskNumPokemonSpawned;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            ModifierLifetimeSeconds = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            TroyDiskNumPokemonSpawned = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as FortModifierAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ModifierLifetimeSeconds != 0) hash ^= ModifierLifetimeSeconds.GetHashCode();
            if (TroyDiskNumPokemonSpawned != 0) hash ^= TroyDiskNumPokemonSpawned.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class IncenseAttributes : pb::IMessage<IncenseAttributes>
    {
        /// <summary>Field number for the "incense_lifetime_seconds" field.</summary>
        public const int IncenseLifetimeSecondsFieldNumber = 1;

        /// <summary>Field number for the "pokemon_type" field.</summary>
        public const int PokemonTypeFieldNumber = 2;

        /// <summary>Field number for the "pokemon_incense_type_probability" field.</summary>
        public const int PokemonIncenseTypeProbabilityFieldNumber = 3;

        /// <summary>Field number for the "standing_time_between_encounters_seconds" field.</summary>
        public const int StandingTimeBetweenEncountersSecondsFieldNumber = 4;

        /// <summary>Field number for the "moving_time_between_encounter_seconds" field.</summary>
        public const int MovingTimeBetweenEncounterSecondsFieldNumber = 5;

        /// <summary>Field number for the "distance_required_for_shorter_interval_meters" field.</summary>
        public const int DistanceRequiredForShorterIntervalMetersFieldNumber = 6;

        /// <summary>Field number for the "pokemon_attracted_length_sec" field.</summary>
        public const int PokemonAttractedLengthSecFieldNumber = 7;

        private static readonly pb::MessageParser<IncenseAttributes> _parser =
            new pb::MessageParser<IncenseAttributes>(() => new IncenseAttributes());

        private static readonly pb::FieldCodec<global::AllEnum.PokemonType> _repeated_pokemonType_codec
            = pb::FieldCodec.ForEnum(18, x => (int)x, x => (global::AllEnum.PokemonType)x);

        private readonly pbc::RepeatedField<global::AllEnum.PokemonType> pokemonType_ =
            new pbc::RepeatedField<global::AllEnum.PokemonType>();

        private int distanceRequiredForShorterIntervalMeters_;
        private int incenseLifetimeSeconds_;
        private int movingTimeBetweenEncounterSeconds_;
        private int pokemonAttractedLengthSec_;
        private float pokemonIncenseTypeProbability_;
        private int standingTimeBetweenEncountersSeconds_;

        public IncenseAttributes()
        {
            OnConstruction();
        }

        public IncenseAttributes(IncenseAttributes other) : this()
        {
            incenseLifetimeSeconds_ = other.incenseLifetimeSeconds_;
            pokemonType_ = other.pokemonType_.Clone();
            pokemonIncenseTypeProbability_ = other.pokemonIncenseTypeProbability_;
            standingTimeBetweenEncountersSeconds_ = other.standingTimeBetweenEncountersSeconds_;
            movingTimeBetweenEncounterSeconds_ = other.movingTimeBetweenEncounterSeconds_;
            distanceRequiredForShorterIntervalMeters_ = other.distanceRequiredForShorterIntervalMeters_;
            pokemonAttractedLengthSec_ = other.pokemonAttractedLengthSec_;
        }

        public static pb::MessageParser<IncenseAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[88]; }
        }

        public int IncenseLifetimeSeconds
        {
            get { return incenseLifetimeSeconds_; }
            set { incenseLifetimeSeconds_ = value; }
        }

        public pbc::RepeatedField<global::AllEnum.PokemonType> PokemonType
        {
            get { return pokemonType_; }
        }

        public float PokemonIncenseTypeProbability
        {
            get { return pokemonIncenseTypeProbability_; }
            set { pokemonIncenseTypeProbability_ = value; }
        }

        public int StandingTimeBetweenEncountersSeconds
        {
            get { return standingTimeBetweenEncountersSeconds_; }
            set { standingTimeBetweenEncountersSeconds_ = value; }
        }

        public int MovingTimeBetweenEncounterSeconds
        {
            get { return movingTimeBetweenEncounterSeconds_; }
            set { movingTimeBetweenEncounterSeconds_ = value; }
        }

        public int DistanceRequiredForShorterIntervalMeters
        {
            get { return distanceRequiredForShorterIntervalMeters_; }
            set { distanceRequiredForShorterIntervalMeters_ = value; }
        }

        public int PokemonAttractedLengthSec
        {
            get { return pokemonAttractedLengthSec_; }
            set { pokemonAttractedLengthSec_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IncenseAttributes Clone()
        {
            return new IncenseAttributes(this);
        }

        public bool Equals(IncenseAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IncenseLifetimeSeconds != other.IncenseLifetimeSeconds) return false;
            if (!pokemonType_.Equals(other.pokemonType_)) return false;
            if (PokemonIncenseTypeProbability != other.PokemonIncenseTypeProbability) return false;
            if (StandingTimeBetweenEncountersSeconds != other.StandingTimeBetweenEncountersSeconds) return false;
            if (MovingTimeBetweenEncounterSeconds != other.MovingTimeBetweenEncounterSeconds) return false;
            if (DistanceRequiredForShorterIntervalMeters != other.DistanceRequiredForShorterIntervalMeters)
                return false;
            if (PokemonAttractedLengthSec != other.PokemonAttractedLengthSec) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (IncenseLifetimeSeconds != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(IncenseLifetimeSeconds);
            }
            pokemonType_.WriteTo(output, _repeated_pokemonType_codec);
            if (PokemonIncenseTypeProbability != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(PokemonIncenseTypeProbability);
            }
            if (StandingTimeBetweenEncountersSeconds != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(StandingTimeBetweenEncountersSeconds);
            }
            if (MovingTimeBetweenEncounterSeconds != 0)
            {
                output.WriteRawTag(40);
                output.WriteInt32(MovingTimeBetweenEncounterSeconds);
            }
            if (DistanceRequiredForShorterIntervalMeters != 0)
            {
                output.WriteRawTag(48);
                output.WriteInt32(DistanceRequiredForShorterIntervalMeters);
            }
            if (PokemonAttractedLengthSec != 0)
            {
                output.WriteRawTag(56);
                output.WriteInt32(PokemonAttractedLengthSec);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (IncenseLifetimeSeconds != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(IncenseLifetimeSeconds);
            }
            size += pokemonType_.CalculateSize(_repeated_pokemonType_codec);
            if (PokemonIncenseTypeProbability != 0F)
            {
                size += 1 + 4;
            }
            if (StandingTimeBetweenEncountersSeconds != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(StandingTimeBetweenEncountersSeconds);
            }
            if (MovingTimeBetweenEncounterSeconds != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(MovingTimeBetweenEncounterSeconds);
            }
            if (DistanceRequiredForShorterIntervalMeters != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DistanceRequiredForShorterIntervalMeters);
            }
            if (PokemonAttractedLengthSec != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonAttractedLengthSec);
            }
            return size;
        }

        public void MergeFrom(IncenseAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.IncenseLifetimeSeconds != 0)
            {
                IncenseLifetimeSeconds = other.IncenseLifetimeSeconds;
            }
            pokemonType_.Add(other.pokemonType_);
            if (other.PokemonIncenseTypeProbability != 0F)
            {
                PokemonIncenseTypeProbability = other.PokemonIncenseTypeProbability;
            }
            if (other.StandingTimeBetweenEncountersSeconds != 0)
            {
                StandingTimeBetweenEncountersSeconds = other.StandingTimeBetweenEncountersSeconds;
            }
            if (other.MovingTimeBetweenEncounterSeconds != 0)
            {
                MovingTimeBetweenEncounterSeconds = other.MovingTimeBetweenEncounterSeconds;
            }
            if (other.DistanceRequiredForShorterIntervalMeters != 0)
            {
                DistanceRequiredForShorterIntervalMeters = other.DistanceRequiredForShorterIntervalMeters;
            }
            if (other.PokemonAttractedLengthSec != 0)
            {
                PokemonAttractedLengthSec = other.PokemonAttractedLengthSec;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            IncenseLifetimeSeconds = input.ReadInt32();
                            break;
                        }
                    case 18:
                    case 16:
                        {
                            pokemonType_.AddEntriesFrom(input, _repeated_pokemonType_codec);
                            break;
                        }
                    case 29:
                        {
                            PokemonIncenseTypeProbability = input.ReadFloat();
                            break;
                        }
                    case 32:
                        {
                            StandingTimeBetweenEncountersSeconds = input.ReadInt32();
                            break;
                        }
                    case 40:
                        {
                            MovingTimeBetweenEncounterSeconds = input.ReadInt32();
                            break;
                        }
                    case 48:
                        {
                            DistanceRequiredForShorterIntervalMeters = input.ReadInt32();
                            break;
                        }
                    case 56:
                        {
                            PokemonAttractedLengthSec = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as IncenseAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (IncenseLifetimeSeconds != 0) hash ^= IncenseLifetimeSeconds.GetHashCode();
            hash ^= pokemonType_.GetHashCode();
            if (PokemonIncenseTypeProbability != 0F) hash ^= PokemonIncenseTypeProbability.GetHashCode();
            if (StandingTimeBetweenEncountersSeconds != 0) hash ^= StandingTimeBetweenEncountersSeconds.GetHashCode();
            if (MovingTimeBetweenEncounterSeconds != 0) hash ^= MovingTimeBetweenEncounterSeconds.GetHashCode();
            if (DistanceRequiredForShorterIntervalMeters != 0)
                hash ^= DistanceRequiredForShorterIntervalMeters.GetHashCode();
            if (PokemonAttractedLengthSec != 0) hash ^= PokemonAttractedLengthSec.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class InventoryUpgradeAttributes : pb::IMessage<InventoryUpgradeAttributes>
    {
        /// <summary>Field number for the "additional_storage" field.</summary>
        public const int AdditionalStorageFieldNumber = 1;

        /// <summary>Field number for the "upgrade_type" field.</summary>
        public const int UpgradeTypeFieldNumber = 2;

        private static readonly pb::MessageParser<InventoryUpgradeAttributes> _parser =
            new pb::MessageParser<InventoryUpgradeAttributes>(() => new InventoryUpgradeAttributes());

        private int additionalStorage_;
        private global::AllEnum.InventoryUpgradeType upgradeType_ = 0;

        public InventoryUpgradeAttributes()
        {
            OnConstruction();
        }

        public InventoryUpgradeAttributes(InventoryUpgradeAttributes other) : this()
        {
            additionalStorage_ = other.additionalStorage_;
            upgradeType_ = other.upgradeType_;
        }

        public static pb::MessageParser<InventoryUpgradeAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[89]; }
        }

        public int AdditionalStorage
        {
            get { return additionalStorage_; }
            set { additionalStorage_ = value; }
        }

        public global::AllEnum.InventoryUpgradeType UpgradeType
        {
            get { return upgradeType_; }
            set { upgradeType_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InventoryUpgradeAttributes Clone()
        {
            return new InventoryUpgradeAttributes(this);
        }

        public bool Equals(InventoryUpgradeAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (AdditionalStorage != other.AdditionalStorage) return false;
            if (UpgradeType != other.UpgradeType) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (AdditionalStorage != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(AdditionalStorage);
            }
            if (UpgradeType != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)UpgradeType);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (AdditionalStorage != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdditionalStorage);
            }
            if (UpgradeType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)UpgradeType);
            }
            return size;
        }

        public void MergeFrom(InventoryUpgradeAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.AdditionalStorage != 0)
            {
                AdditionalStorage = other.AdditionalStorage;
            }
            if (other.UpgradeType != 0)
            {
                UpgradeType = other.UpgradeType;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            AdditionalStorage = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            upgradeType_ = (global::AllEnum.InventoryUpgradeType)input.ReadEnum();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as InventoryUpgradeAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (AdditionalStorage != 0) hash ^= AdditionalStorage.GetHashCode();
            if (UpgradeType != 0) hash ^= UpgradeType.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PokeballAttributes : pb::IMessage<PokeballAttributes>
    {
        /// <summary>Field number for the "item_effect" field.</summary>
        public const int ItemEffectFieldNumber = 1;

        /// <summary>Field number for the "capture_multi" field.</summary>
        public const int CaptureMultiFieldNumber = 2;

        /// <summary>Field number for the "capture_multi_effect" field.</summary>
        public const int CaptureMultiEffectFieldNumber = 3;

        /// <summary>Field number for the "item_effect_mod" field.</summary>
        public const int ItemEffectModFieldNumber = 4;

        private static readonly pb::MessageParser<PokeballAttributes> _parser =
            new pb::MessageParser<PokeballAttributes>(() => new PokeballAttributes());

        private float captureMulti_;
        private float captureMultiEffect_;
        private global::AllEnum.ItemEffect itemEffect_ = 0;
        private float itemEffectMod_;

        public PokeballAttributes()
        {
            OnConstruction();
        }

        public PokeballAttributes(PokeballAttributes other) : this()
        {
            itemEffect_ = other.itemEffect_;
            captureMulti_ = other.captureMulti_;
            captureMultiEffect_ = other.captureMultiEffect_;
            itemEffectMod_ = other.itemEffectMod_;
        }

        public static pb::MessageParser<PokeballAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[90]; }
        }

        public global::AllEnum.ItemEffect ItemEffect
        {
            get { return itemEffect_; }
            set { itemEffect_ = value; }
        }

        public float CaptureMulti
        {
            get { return captureMulti_; }
            set { captureMulti_ = value; }
        }

        public float CaptureMultiEffect
        {
            get { return captureMultiEffect_; }
            set { captureMultiEffect_ = value; }
        }

        public float ItemEffectMod
        {
            get { return itemEffectMod_; }
            set { itemEffectMod_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PokeballAttributes Clone()
        {
            return new PokeballAttributes(this);
        }

        public bool Equals(PokeballAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ItemEffect != other.ItemEffect) return false;
            if (CaptureMulti != other.CaptureMulti) return false;
            if (CaptureMultiEffect != other.CaptureMultiEffect) return false;
            if (ItemEffectMod != other.ItemEffectMod) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ItemEffect != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)ItemEffect);
            }
            if (CaptureMulti != 0F)
            {
                output.WriteRawTag(21);
                output.WriteFloat(CaptureMulti);
            }
            if (CaptureMultiEffect != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(CaptureMultiEffect);
            }
            if (ItemEffectMod != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(ItemEffectMod);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (ItemEffect != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemEffect);
            }
            if (CaptureMulti != 0F)
            {
                size += 1 + 4;
            }
            if (CaptureMultiEffect != 0F)
            {
                size += 1 + 4;
            }
            if (ItemEffectMod != 0F)
            {
                size += 1 + 4;
            }
            return size;
        }

        public void MergeFrom(PokeballAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ItemEffect != 0)
            {
                ItemEffect = other.ItemEffect;
            }
            if (other.CaptureMulti != 0F)
            {
                CaptureMulti = other.CaptureMulti;
            }
            if (other.CaptureMultiEffect != 0F)
            {
                CaptureMultiEffect = other.CaptureMultiEffect;
            }
            if (other.ItemEffectMod != 0F)
            {
                ItemEffectMod = other.ItemEffectMod;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            itemEffect_ = (global::AllEnum.ItemEffect)input.ReadEnum();
                            break;
                        }
                    case 21:
                        {
                            CaptureMulti = input.ReadFloat();
                            break;
                        }
                    case 29:
                        {
                            CaptureMultiEffect = input.ReadFloat();
                            break;
                        }
                    case 37:
                        {
                            ItemEffectMod = input.ReadFloat();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PokeballAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (ItemEffect != 0) hash ^= ItemEffect.GetHashCode();
            if (CaptureMulti != 0F) hash ^= CaptureMulti.GetHashCode();
            if (CaptureMultiEffect != 0F) hash ^= CaptureMultiEffect.GetHashCode();
            if (ItemEffectMod != 0F) hash ^= ItemEffectMod.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class PotionAttributes : pb::IMessage<PotionAttributes>
    {
        /// <summary>Field number for the "sta_percent" field.</summary>
        public const int StaPercentFieldNumber = 1;

        /// <summary>Field number for the "sta_amount" field.</summary>
        public const int StaAmountFieldNumber = 2;

        private static readonly pb::MessageParser<PotionAttributes> _parser =
            new pb::MessageParser<PotionAttributes>(() => new PotionAttributes());

        private int staAmount_;
        private float staPercent_;

        public PotionAttributes()
        {
            OnConstruction();
        }

        public PotionAttributes(PotionAttributes other) : this()
        {
            staPercent_ = other.staPercent_;
            staAmount_ = other.staAmount_;
        }

        public static pb::MessageParser<PotionAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[91]; }
        }

        public float StaPercent
        {
            get { return staPercent_; }
            set { staPercent_ = value; }
        }

        public int StaAmount
        {
            get { return staAmount_; }
            set { staAmount_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PotionAttributes Clone()
        {
            return new PotionAttributes(this);
        }

        public bool Equals(PotionAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (StaPercent != other.StaPercent) return false;
            if (StaAmount != other.StaAmount) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (StaPercent != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(StaPercent);
            }
            if (StaAmount != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(StaAmount);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (StaPercent != 0F)
            {
                size += 1 + 4;
            }
            if (StaAmount != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(StaAmount);
            }
            return size;
        }

        public void MergeFrom(PotionAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.StaPercent != 0F)
            {
                StaPercent = other.StaPercent;
            }
            if (other.StaAmount != 0)
            {
                StaAmount = other.StaAmount;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            StaPercent = input.ReadFloat();
                            break;
                        }
                    case 16:
                        {
                            StaAmount = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as PotionAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (StaPercent != 0F) hash ^= StaPercent.GetHashCode();
            if (StaAmount != 0) hash ^= StaAmount.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class ReviveAttributes : pb::IMessage<ReviveAttributes>
    {
        /// <summary>Field number for the "sta_percent" field.</summary>
        public const int StaPercentFieldNumber = 1;

        private static readonly pb::MessageParser<ReviveAttributes> _parser =
            new pb::MessageParser<ReviveAttributes>(() => new ReviveAttributes());

        private float staPercent_;

        public ReviveAttributes()
        {
            OnConstruction();
        }

        public ReviveAttributes(ReviveAttributes other) : this()
        {
            staPercent_ = other.staPercent_;
        }

        public static pb::MessageParser<ReviveAttributes> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[92]; }
        }

        public float StaPercent
        {
            get { return staPercent_; }
            set { staPercent_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ReviveAttributes Clone()
        {
            return new ReviveAttributes(this);
        }

        public bool Equals(ReviveAttributes other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (StaPercent != other.StaPercent) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (StaPercent != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(StaPercent);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (StaPercent != 0F)
            {
                size += 1 + 4;
            }
            return size;
        }

        public void MergeFrom(ReviveAttributes other)
        {
            if (other == null)
            {
                return;
            }
            if (other.StaPercent != 0F)
            {
                StaPercent = other.StaPercent;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 13:
                        {
                            StaPercent = input.ReadFloat();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as ReviveAttributes);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (StaPercent != 0F) hash ^= StaPercent.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     POKEMON TRANSFER
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class TransferPokemon : pb::IMessage<TransferPokemon>
    {
        /// <summary>Field number for the "PokemonId" field.</summary>
        public const int PokemonIdFieldNumber = 1;

        private static readonly pb::MessageParser<TransferPokemon> _parser =
            new pb::MessageParser<TransferPokemon>(() => new TransferPokemon());

        private ulong pokemonId_;

        public TransferPokemon()
        {
            OnConstruction();
        }

        public TransferPokemon(TransferPokemon other) : this()
        {
            pokemonId_ = other.pokemonId_;
        }

        public static pb::MessageParser<TransferPokemon> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[93]; }
        }

        public ulong PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TransferPokemon Clone()
        {
            return new TransferPokemon(this);
        }

        public bool Equals(TransferPokemon other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PokemonId != other.PokemonId) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (PokemonId != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(PokemonId);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (PokemonId != 0UL)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(TransferPokemon other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PokemonId != 0UL)
            {
                PokemonId = other.PokemonId;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            PokemonId = input.ReadFixed64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as TransferPokemon);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class TransferPokemonOut : pb::IMessage<TransferPokemonOut>
    {
        /// <summary>Field number for the "Status" field.</summary>
        public const int StatusFieldNumber = 1;

        /// <summary>Field number for the "CandyAwarded" field.</summary>
        public const int CandyAwardedFieldNumber = 2;

        private static readonly pb::MessageParser<TransferPokemonOut> _parser =
            new pb::MessageParser<TransferPokemonOut>(() => new TransferPokemonOut());

        private int candyAwarded_;
        private int status_;

        public TransferPokemonOut()
        {
            OnConstruction();
        }

        public TransferPokemonOut(TransferPokemonOut other) : this()
        {
            status_ = other.status_;
            candyAwarded_ = other.candyAwarded_;
        }

        public static pb::MessageParser<TransferPokemonOut> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[94]; }
        }

        public int Status
        {
            get { return status_; }
            set { status_ = value; }
        }

        public int CandyAwarded
        {
            get { return candyAwarded_; }
            set { candyAwarded_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TransferPokemonOut Clone()
        {
            return new TransferPokemonOut(this);
        }

        public bool Equals(TransferPokemonOut other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Status != other.Status) return false;
            if (CandyAwarded != other.CandyAwarded) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Status != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Status);
            }
            if (CandyAwarded != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(CandyAwarded);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Status != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Status);
            }
            if (CandyAwarded != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(CandyAwarded);
            }
            return size;
        }

        public void MergeFrom(TransferPokemonOut other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Status != 0)
            {
                Status = other.Status;
            }
            if (other.CandyAwarded != 0)
            {
                CandyAwarded = other.CandyAwarded;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Status = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            CandyAwarded = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as TransferPokemonOut);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Status != 0) hash ^= Status.GetHashCode();
            if (CandyAwarded != 0) hash ^= CandyAwarded.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    /// <summary>
    ///     EVOLVE
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EvolvePokemon : pb::IMessage<EvolvePokemon>
    {
        /// <summary>Field number for the "PokemonId" field.</summary>
        public const int PokemonIdFieldNumber = 1;

        private static readonly pb::MessageParser<EvolvePokemon> _parser =
            new pb::MessageParser<EvolvePokemon>(() => new EvolvePokemon());

        private ulong pokemonId_;

        public EvolvePokemon()
        {
            OnConstruction();
        }

        public EvolvePokemon(EvolvePokemon other) : this()
        {
            pokemonId_ = other.pokemonId_;
        }

        public static pb::MessageParser<EvolvePokemon> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[95]; }
        }

        public ulong PokemonId
        {
            get { return pokemonId_; }
            set { pokemonId_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EvolvePokemon Clone()
        {
            return new EvolvePokemon(this);
        }

        public bool Equals(EvolvePokemon other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PokemonId != other.PokemonId) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (PokemonId != 0UL)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(PokemonId);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (PokemonId != 0UL)
            {
                size += 1 + 8;
            }
            return size;
        }

        public void MergeFrom(EvolvePokemon other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PokemonId != 0UL)
            {
                PokemonId = other.PokemonId;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 9:
                        {
                            PokemonId = input.ReadFixed64();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EvolvePokemon);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class EvolvePokemonOut : pb::IMessage<EvolvePokemonOut>
    {
        /// <summary>Field number for the "Result" field.</summary>
        public const int ResultFieldNumber = 1;

        /// <summary>Field number for the "EvolvedPokemon" field.</summary>
        public const int EvolvedPokemonFieldNumber = 2;

        /// <summary>Field number for the "ExpAwarded" field.</summary>
        public const int ExpAwardedFieldNumber = 3;

        /// <summary>Field number for the "CandyAwarded" field.</summary>
        public const int CandyAwardedFieldNumber = 4;

        private static readonly pb::MessageParser<EvolvePokemonOut> _parser =
            new pb::MessageParser<EvolvePokemonOut>(() => new EvolvePokemonOut());

        private int candyAwarded_;
        private global::PokeGodar.WebAPI.GeneratedCode.Pokemon evolvedPokemon_;
        private int expAwarded_;
        private int result_;

        public EvolvePokemonOut()
        {
            OnConstruction();
        }

        public EvolvePokemonOut(EvolvePokemonOut other) : this()
        {
            result_ = other.result_;
            EvolvedPokemon = other.evolvedPokemon_ != null ? other.EvolvedPokemon.Clone() : null;
            expAwarded_ = other.expAwarded_;
            candyAwarded_ = other.candyAwarded_;
        }

        public static pb::MessageParser<EvolvePokemonOut> Parser
        {
            get { return _parser; }
        }

        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::PokeGodar.WebAPI.GeneratedCode.PayloadsReflection.Descriptor.MessageTypes[96]; }
        }

        public int Result
        {
            get { return result_; }
            set { result_ = value; }
        }

        public global::PokeGodar.WebAPI.GeneratedCode.Pokemon EvolvedPokemon
        {
            get { return evolvedPokemon_; }
            set { evolvedPokemon_ = value; }
        }

        public int ExpAwarded
        {
            get { return expAwarded_; }
            set { expAwarded_ = value; }
        }

        public int CandyAwarded
        {
            get { return candyAwarded_; }
            set { candyAwarded_ = value; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EvolvePokemonOut Clone()
        {
            return new EvolvePokemonOut(this);
        }

        public bool Equals(EvolvePokemonOut other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Result != other.Result) return false;
            if (!Equals(EvolvedPokemon, other.EvolvedPokemon)) return false;
            if (ExpAwarded != other.ExpAwarded) return false;
            if (CandyAwarded != other.CandyAwarded) return false;
            return true;
        }

        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Result != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Result);
            }
            if (evolvedPokemon_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(EvolvedPokemon);
            }
            if (ExpAwarded != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(ExpAwarded);
            }
            if (CandyAwarded != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(CandyAwarded);
            }
        }

        public int CalculateSize()
        {
            var size = 0;
            if (Result != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
            }
            if (evolvedPokemon_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(EvolvedPokemon);
            }
            if (ExpAwarded != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(ExpAwarded);
            }
            if (CandyAwarded != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(CandyAwarded);
            }
            return size;
        }

        public void MergeFrom(EvolvePokemonOut other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Result != 0)
            {
                Result = other.Result;
            }
            if (other.evolvedPokemon_ != null)
            {
                if (evolvedPokemon_ == null)
                {
                    evolvedPokemon_ = new global::PokeGodar.WebAPI.GeneratedCode.Pokemon();
                }
                EvolvedPokemon.MergeFrom(other.EvolvedPokemon);
            }
            if (other.ExpAwarded != 0)
            {
                ExpAwarded = other.ExpAwarded;
            }
            if (other.CandyAwarded != 0)
            {
                CandyAwarded = other.CandyAwarded;
            }
        }

        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            Result = input.ReadInt32();
                            break;
                        }
                    case 18:
                        {
                            if (evolvedPokemon_ == null)
                            {
                                evolvedPokemon_ = new global::PokeGodar.WebAPI.GeneratedCode.Pokemon();
                            }
                            input.ReadMessage(evolvedPokemon_);
                            break;
                        }
                    case 24:
                        {
                            ExpAwarded = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            CandyAwarded = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as EvolvePokemonOut);
        }

        public override int GetHashCode()
        {
            var hash = 1;
            if (Result != 0) hash ^= Result.GetHashCode();
            if (evolvedPokemon_ != null) hash ^= EvolvedPokemon.GetHashCode();
            if (ExpAwarded != 0) hash ^= ExpAwarded.GetHashCode();
            if (CandyAwarded != 0) hash ^= CandyAwarded.GetHashCode();
            return hash;
        }

        partial void OnConstruction();

        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    #endregion
}

#endregion Designer generated code