using System.ComponentModel.DataAnnotations;

namespace TodoList.Server.Dtos
{
    public class TodoItemDTO
    {
        public class TodoItemBase
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
            public required bool IsCompleted { get; set; }
        }

        public class TodoItemResponseBase : ResponseBase
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
            public required bool IsCompleted { get; set; }
        }

        public class GetAll
        {
            public class Response : ResponseBase
            {
                public required IReadOnlyList<TodoItemBase> Items { get; set; }
            }
        }

        public class Get
        {
            public class Response : TodoItemResponseBase
            {
            }
        }

        public class Create
        {
            public class Command
            {
                [Required]
                public required string Title { get; set; }
            }

            public class Response : TodoItemResponseBase
            {
            }
        }

        public class Update
        {
            public class Command
            {
                public required string Title { get; set; }
                public required bool IsCompleted { get; set; }
            }

            public class Response : ResponseBase
            {
                public required string Title { get; set; }
                public required bool IsCompleted { get; set; }
            }
        }

        public class UpdateTitle
        {
            public class Command
            {
                public required string Title { get; set; }
            }

            public class Response : ResponseBase
            {
                public required string Title { get; set; }
            }
        }

        public class UpdateIsCompleted
        {
            public class Command
            {
                public required bool IsCompleted { get; set; }
            }

            public class Response : ResponseBase
            {
                public required bool IsCompleted { get; set; }
            }
        }
    }
}
