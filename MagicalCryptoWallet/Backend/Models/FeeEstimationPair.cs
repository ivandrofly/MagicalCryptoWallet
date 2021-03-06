﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MagicalCryptoWallet.Backend.Models
{
	/// <summary>
	/// satoshi per bytes
	/// </summary>
    public class FeeEstimationPair
	{
		[Required]
		public int Economical { get; set; }
		[Required]
		public int Conservative { get; set; }
	}
}
