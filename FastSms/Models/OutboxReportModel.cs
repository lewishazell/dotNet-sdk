﻿namespace FastSms.Models {
	/// <summary>
	///    Outbox report model.
	/// </summary>
	public class OutboxReportModel : ReportModel {
		/// <summary>
		///    Message id.
		/// </summary>
		public string MessageId { get; set; }

		/// <summary>
		///    Username.
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		///    Destination.
		/// </summary>
		public string Destination { get; set; }

		/// <summary>
		///    Status.
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		///    Schedule date.
		/// </summary>
		public string ScheduleDate { get; set; }

		/// <summary>
		///    Sent date.
		/// </summary>
		public string SentDate { get; set; }

		/// <summary>
		///    Delivery date.
		/// </summary>
		public string DeliveryDate { get; set; }
	}
}