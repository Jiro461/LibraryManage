import React, { useEffect, useState } from 'react'
import axios from "axios"

export default function HomePage() {
  const [books, setBooks] = useState(null)

  // useEffect(() => {
  //   const fetchBooks = async () => {
  //     const books = await axios.get("https://potterapi-fedeperin.vercel.app/en/books")
  //     setBooks(books)
  //   }

  //   fetchBooks
  // }, [])

  return (
    <div>HomePage</div>
  )
}
