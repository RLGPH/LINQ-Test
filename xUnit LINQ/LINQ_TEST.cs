using LINQ_Test;

namespace xUnit_LINQ
{
    public class LINQ_Methods_Tests
    {
        private readonly LINQ_Methods _methods;
        private readonly DataForLINQ _data;

        public LINQ_Methods_Tests()
        {
            _methods = new LINQ_Methods();
            _data = new DataForLINQ();
            _data.MakeLists();
        }

        [Fact]
        public void SelectedUser_ShouldReturnCorrectUser()
        {
            
            int userId = 3;

            
            var result = _methods.SelectedUser(_data.users, userId);

            
            Assert.NotNull(result);
            Assert.Equal("Special Doe", result.FullName);
        }

        [Fact]
        public void SelectedUser_ShouldReturnNull_WhenUserDoesNotExist()
        {
            
            int userId = 10;

            
            var result = _methods.SelectedUser(_data.users, userId);

            
            Assert.Null(result);
        }

        [Fact]
        public void EvenNumbers_ShouldReturnEvenNumbers()
        {
            
            var result = _methods.evenNumbers(_data.numbers);

            
            Assert.Equal(new int[] { 2, 4, 6, 8, 10 }, result);
        }

        [Fact]
        public void OddNumbers_ShouldReturnOddNumbers()
        {
            
            var result = _methods.OddNumbers(_data.numbers);

            
            Assert.Equal(new int[] { 1, 3, 5, 7, 9 }, result);
        }

        [Fact]
        public void NewUser_ShouldAddUserWithCorrectId()
        {
            
            var newUser = new User(0, "Jane Doe", "Jane", "Doe", "+45 987654321", "jane@somewhere.some");

            
            _data.NewUser(newUser);

            
            var addedUser = _data.users.Find(u => u.FullName == "Jane Doe");
            Assert.NotNull(addedUser);
            Assert.Equal(7, addedUser.UserId);  
        }

        [Fact]
        public void NewUser_ShouldIncreaseListCount()
        {
            
            var initialCount = _data.users.Count;
            var newUser = new User(0, "Jane Doe", "Jane", "Doe", "+45 987654321", "jane@somewhere.some");

            
            _data.NewUser(newUser);

            
            Assert.Equal(initialCount + 1, _data.users.Count);
        }
    }
}