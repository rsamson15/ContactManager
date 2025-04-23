using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactContext _context;

        public ContactController(ContactContext context)
        {
            _context = context;
        }

        // Read (Index): Redirect to home page
        public async Task<IActionResult> Index()
        {
            return RedirectToAction("Index", "Home"); // Redirects the user to the Home page’s Index action.
        }

        //Read (Details) - View Contact Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)    // Checks if the id is null
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contact == null)  //  if contacts does not exist it will returns
            {
                return NotFound();  
            }

            return View(contact);   // displays the contact details
        }

        // Create (GET) - Show Add Contact Form
        public IActionResult Create()
        {
            ViewBag.Name = new SelectList(_context.Categories, "CategoryID", "Name");
            return View();
        }

        // Create (POST) - Save New Contact
        [HttpPost] //Specifies this method handles POST requests.
        [ValidateAntiForgeryToken]    //Prevents Cross-Site Request Forgery (CSRF) attacks.
        public async Task<IActionResult> Create([Bind("ID,Firstname,Lastname,Phone,Email,CategoryId")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.DateAdded = DateTime.Now;
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Name = new SelectList(_context.Categories, "CategoryID", "Name", contact.CategoryId);
            return View(contact);
        }


        // Edit (GET) - Show Contact Edit Form
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)   // Checks if id is null and returns
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewBag.Name = new SelectList(_context.Categories, "CategoryID", "Name", contact.CategoryId);
            return View(contact);
        }

        // Edit (POST) - Save Edited Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Firstname,Lastname,Phone,Email,CategoryId,DateAdded")] Contact contact)
        {
            if (id != contact.ID)    // Ensures the URL id matches the contact’s ID
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Name = new SelectList(_context.Categories, "CategoryID", "Name", contact.CategoryId);
            return View(contact);   // If validation fails, reloads the form with the previous values.
        }

        // Delete (GET) - Show Contact Deletion Confirmation
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // Delete (POST) - Confirm and Delete Contact
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.ID == id);
        }
    }
}
