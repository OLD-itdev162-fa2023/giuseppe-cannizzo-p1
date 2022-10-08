using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context) {
            if(!context.Posts.Any()) {
                var Posts = new List <Post> 
                {
                    new Post {
                        Title = "First Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi volutpat porta magna eget aliquam. Praesent vitae orci vestibulum erat dictum gravida maximus ut sem. Suspendisse malesuada elit ut erat faucibus, id congue turpis aliquam. Donec purus nibh, fermentum eu interdum vitae, posuere non eros. Fusce aliquam et mauris imperdiet commodo. Nulla vel orci turpis. Integer eleifend erat nulla. Ut sed lectus eros. Phasellus laoreet at massa eu sollicitudin. Sed tincidunt enim eu diam eleifend, id placerat tellus suscipit. Mauris aliquet interdum fermentum. Pellentesque ante urna, hendrerit id condimentum sit amet, venenatis et lectus.",
                        Date = DateTime.Now.AddDays(-10)
                        },
                    new Post {
                        Title = "Second Post",
                        Body = "Quisque non mauris dui. Proin egestas quis eros in interdum. Quisque scelerisque pretium justo a egestas. Praesent a auctor erat. In quis leo dignissim, maximus nunc sit amet, efficitur tellus. Aenean convallis pharetra enim et vulputate. In tincidunt leo vitae velit varius, nec ornare tellus semper. Phasellus ultricies augue eget augue rutrum pulvinar. Morbi malesuada tincidunt porttitor. Nulla quis tortor congue, aliquam turpis mattis, cursus justo. Phasellus ac lacus sem. Praesent sem diam, tempor quis odio eu, fermentum porta elit. Vestibulum malesuada eros at ornare blandit. Pellentesque sit amet congue metus, a rutrum lacus.",
                        Date = DateTime.Now.AddDays(-7)
                        },
                    new Post {
                        Title = "Third Post",
                        Body = "Nullam sollicitudin, quam molestie elementum rhoncus, lectus tellus sodales urna, sed egestas lacus tortor in diam. Nam vel lectus sit amet metus eleifend efficitur. Suspendisse vehicula faucibus nulla, vel rhoncus risus blandit non. Sed accumsan placerat ante eu rhoncus. Fusce pellentesque, lacus sed suscipit blandit, ligula erat ornare eros, eget dapibus nisi neque sed nulla. Phasellus at lectus molestie, mollis lectus a, mollis lorem. Pellentesque neque odio, tristique eget ullamcorper ac, ultrices eu mauris. Nam sagittis nisi quis vulputate ultrices. Fusce euismod rhoncus odio vel convallis. Cras id tempor felis, eu luctus urna. Suspendisse nec dolor dui.",
                        Date = DateTime.Now.AddDays(-4)
                        }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}