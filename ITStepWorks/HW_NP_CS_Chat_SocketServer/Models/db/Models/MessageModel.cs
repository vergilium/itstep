using DB.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SocketServer.Models;

namespace DB.Models {
	public class MessageModel {
		public long id { get; set; }
		public string command { get; set; }
		public string text { get; set; }
		public long sender { get; set; }
		public long receiver { get; set; }
		public DateTime sendTime { get; set; }
		public DateTime viewTime { get; set; }

		public MessageModel(Message msg) {
			id = msg.Id;
			command = msg.command;
			text = msg.text;
			sender = msg.sender_id;
			receiver = msg.receiver_id;
			sendTime = msg.sendTime;
			viewTime = msg.viewTime;
		}

		public static implicit operator MessageVM(MessageModel model) {
			return new MessageVM {
				id = model.id,
				text = model.text,
				sendTime = model.sendTime,
				viewTime = model.viewTime
			};
		}

		public static IEnumerable<MessageModel> GetAllMessage() {
			return Unit.MessageRepository.AllItems
				.Include(m => m.Id)
				.Include(m => m.command)
				.Include(m => m.text)
				.Include(m => m.sender_id)
				.Include(m => m.receiver_id)
				.Include(m => m.sendTime)
				.Include(m => m.viewTime)
				.Select(m => new MessageModel(m))
				.ToList();
		}

		public static IEnumerable<MessageVM> GetAllMessageVM() {
			return Unit.MessageRepository.AllItems
				.Include(m => m.Id)
				.Include(m => m.text)
				.Include(m => m.sendTime)
				.Include(m => m.viewTime)
				.Select(m => (MessageVM) new MessageModel(m))
				.ToList();
		}
	}

}
