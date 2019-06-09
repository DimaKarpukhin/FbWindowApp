namespace AppLogic
{
    using System.Collections;
    using System.Collections.Generic;

    public class TaggedFriends : IEnumerable<TaggedFriend>
    {
        private readonly List<TaggedFriend> m_Friends;

        public TaggedFriends(List<TaggedFriend> i_Friends)
        {
            m_Friends = i_Friends;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TaggedFriendsIterator(this);
        }

        IEnumerator<TaggedFriend> IEnumerable<TaggedFriend>.GetEnumerator()
        {
            for (int i = 0; i < m_Friends.Count; i++)
            {
                yield return m_Friends[i];
            }
        }

        private class TaggedFriendsIterator : IEnumerator
        {
            private TaggedFriends m_Collection;
            private int m_CurrentIndex = -1;
            private int m_Count = -1;

            public TaggedFriendsIterator(TaggedFriends i_Collection)
            {
                m_Collection = i_Collection;
            }

            public object Current
            {
                get { return m_Collection.m_Friends[m_CurrentIndex]; }
            }

            public bool MoveNext()
            {
                ++m_CurrentIndex;
                return m_CurrentIndex < m_Count;
            }

            public void Reset()
            {
                m_CurrentIndex = 0;
            }
        }
    }
}
