using System.ComponentModel.DataAnnotations;

namespace TodoList.Server.Dtos
{
    public class TodoGroupDTO
    {
        public class TodoGroupBase
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
        }

        public class TodoGroupResponseBase : ResponseBase
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
        }

        public class GetAll
        {
            public class Response : ResponseBase
            {
                public required IReadOnlyList<TodoGroupBase> Groups { get; set; }
            }
        }

        public class Get
        {
            public class Response : TodoGroupResponseBase
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

            public class Response : TodoGroupResponseBase
            {
            }
        }

        public class Update
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
    }
}
