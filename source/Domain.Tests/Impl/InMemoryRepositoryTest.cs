using System.Collections.Generic;
using System.Linq;
using Naftan.Infrastructure.Domain.Impl;
using NUnit.Framework;

namespace Naftan.Infrastructure.Domain.Tests.Impl
{
    public class TestEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class InMemoryRepositoryTest
    {
        private IRepository repository;

        [SetUp]
        public void SetUp()
        {
            repository = new InMemoryRepository();
        }

        [Test]
        public void SaveEntityTest()
        {
            var entity = new TestEntity();
            var entity2 = new TestEntity();
            repository.Save(entity);
            repository.Save(entity2);
            Assert.AreEqual(repository.All<TestEntity>().Count(), 2);
        }

        [Test]
        public void GetNotFoundEntityTest()
        {
            Assert.Throws(typeof (KeyNotFoundException), () => repository.Get<TestEntity>(1));
        }

        [Test]
        public void GetEntityTest()
        {
            repository.Save(new TestEntity());
            var entity = repository.Get<TestEntity>(1);
            Assert.IsNotNull(entity);
        }

        [Test]
        public void RemoveEntityTest()
        {
            var entity = new TestEntity();
            var entity2 = new TestEntity();
            repository.Save(entity);
            repository.Save(entity2);
            repository.Remove(entity2);
            Assert.AreEqual(repository.All<TestEntity>().Count(), 1);
        }

        [Test]
        public void GenerateIdTest()
        {
            var entity = new TestEntity();
            repository.Save(entity);
            Assert.AreEqual(entity.Id, 1);
        }

        [Test]
        public void GenerateIdTwiceTest()
        {
            var entity = new TestEntity();
            repository.Save(entity);
            var entity2 = new TestEntity();
            repository.Save(entity2);
            Assert.AreEqual(entity2.Id, 2);
        }

        [Test]
        public void GenerateIdAfterRemoveTest()
        {
            var entity = new TestEntity();
            var entity2 = new TestEntity();
            repository.Save(entity);
            repository.Save(entity2);
            repository.Remove(entity2);

            var entity3 = new TestEntity();
            repository.Save(entity3);
            Assert.AreEqual(entity3.Id, 3);
        }
    }
}
